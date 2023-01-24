﻿namespace FisicaUsuario.Classes
{
    public class Favorito : Entity
    {
        public long UsuarioId { get; set; }
        private Usuario _Usuario;
        public virtual Usuario Usuario { get { return _Usuario; } set { _Usuario = value; SetUsuario(value); } }

        public long? IdAula { get; set; }

        public long? IdSessaoAula { get; set; }

        private void SetUsuario(Usuario value)
        {
            UsuarioId = value is null ? 0 : value.Id;
        }
    }
}