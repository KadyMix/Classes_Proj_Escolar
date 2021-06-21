using System;
using System.Text;
using System.Collections.Generic;


namespace SIGE.Domain {
    
    public partial class Matriculas {
        public Matriculas() {
			Avaliacoes = new List<Avaliacoes>();
			Facturas = new List<Facturas>();
			MatriculasOpcoes = new List<MatriculasOpcoes>();
			MatriculasServicos = new List<MatriculasServicos>();
			TurmasMatriculas = new List<TurmasMatriculas>();
        }
        public virtual string Id { get; set; }
        public virtual AnosLectivos AnosLectivos { get; set; }
        public virtual Pessoas Pessoas { get; set; }
        public virtual ModelosEnsino ModelosEnsino { get; set; }
        public virtual bool Reconfirmacao { get; set; }
        public virtual bool Pago { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual IList<Avaliacoes> Avaliacoes { get; set; }
        public virtual IList<Facturas> Facturas { get; set; }
        public virtual IList<MatriculasOpcoes> MatriculasOpcoes { get; set; }
        public virtual IList<MatriculasServicos> MatriculasServicos { get; set; }
        public virtual IList<TurmasMatriculas> TurmasMatriculas { get; set; }
    }
}
