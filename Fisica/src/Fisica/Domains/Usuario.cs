﻿using Fisica.Enums;

namespace Fisica.Domains
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int TipoUsuario { get; set; }
        public TipoUsuario TipoUsuarioEnum => (TipoUsuario)TipoUsuario;

        public long PerfilId { get; set; }
        private Perfil _Perfil;
        public virtual Perfil Perfil { get { return _Perfil; } set { _Perfil = value; SetPerfil(value); } }

        public long? InstituicaoId { get; set; }
        private Instituicao _Instituicao;
        public Instituicao Instituicao { get { return _Instituicao; } set { _Instituicao = value; SetInstituicao(value); } }

        public IEnumerable<Favorito>? Favoritos { get; set; }

        public IEnumerable<Widget>? Widgets { get; set; }

        public IEnumerable<Noticia>? Noticias { get; set; }

        public IEnumerable<Usuario>? Seguidores { get; set; }

        public IEnumerable<Usuario>? Seguindo { get; set; }

        public IEnumerable<TopicoForum>? TopicosForum { get; set; }

        public IEnumerable<RespostaTopico>? RespostasTopicos { get; set; }

        public IEnumerable<Replica>? Replicas { get; set; }

        public IEnumerable<ComentarioAula>? Comentarios { get; set; }

        public IEnumerable<VisualizacaoAula>? Visualizacoes { get; set; }

        public IEnumerable<Aula>? Aulas { get; set; }

        private void SetPerfil(Perfil value)
        {
            PerfilId = value is null ? 0 : value.Id;
        }

        private void SetInstituicao(Instituicao value)
        {
            InstituicaoId = value is null ? 0 : value.Id;
        }
    }
}
