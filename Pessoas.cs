using System;
using System.Text;
using System.Collections.Generic;


namespace SIGE.Domain {
    
    public partial class Pessoas {
        public Pessoas() {
			DocentesDisciplinas = new List<DocentesDisciplinas>();
			Documentos = new List<Documentos>();
			EstudantesContactos = new List<EstudantesContactos>();
			Matriculas = new List<Matriculas>();
			MoradasPessoas = new List<MoradasPessoas>();
			RecursosHumanos = new List<RecursosHumanos>();
			Salarios = new List<Salarios>();
			TurmasDocentes = new List<TurmasDocentes>();
        }
        public virtual int Id { get; set; }
        public virtual Funcoes Funcoes { get; set; }
        public virtual Paises Paises { get; set; }
        public virtual Funcoes Funcoes { get; set; }
        public virtual Municipios Municipios { get; set; }
        public virtual string Sexo { get; set; }
        public virtual string Apelidos { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<DocentesDisciplinas> DocentesDisciplinas { get; set; }
        public virtual IList<Documentos> Documentos { get; set; }
        public virtual IList<EstudantesContactos> EstudantesContactos { get; set; }
        public virtual IList<Matriculas> Matriculas { get; set; }
        public virtual IList<MoradasPessoas> MoradasPessoas { get; set; }
        public virtual IList<RecursosHumanos> RecursosHumanos { get; set; }
        public virtual IList<Salarios> Salarios { get; set; }
        public virtual IList<TurmasDocentes> TurmasDocentes { get; set; }
    }
}
