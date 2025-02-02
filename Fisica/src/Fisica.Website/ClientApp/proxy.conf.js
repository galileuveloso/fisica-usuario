const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:18912';

const PROXY_CONFIG = [
  {
    context: [
      "/api/usuario",
      "/api/instituicao",
      "/api/cidade",
      "/api/noticia",
      "/api/topicoforum",
      "/api/respostatopico",
      "/api/replica",
      "/api/aula",
      "/api/segue",
      "/api/widget",
      "/api/favorito",
   ],
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  }
]

module.exports = PROXY_CONFIG;
