﻿namespace Fisica.Domains
{
    public class Widget : Entity
    {
        public string Descricao { get; set; }

        public long UsuarioId { get; set; }
        private Usuario _Usuario;
        public virtual Usuario Usuario { get { return _Usuario; } set { _Usuario = value; SetUsuario(value); } }

        public IEnumerable<WidgetAula>? Aulas { get; set; }

        private void SetUsuario(Usuario value)
        {
            UsuarioId = value is null ? 0 : value.Id;
        }
    }
}
