namespace WellBe.Business.Profissionais.Agenda
{
    public class Agenda
    {
        /// <summary>Código de identificação da agenda.</summary>
        public int IdAgenda { get; }

        /// <summary>Código de identificação da agenda do parceiro.</summary>
        public int? IdParceiro { get; }

        /// <summary>Código de identificação da agenda do profissional.</summary>
        public int? IdProfissional { get; }
        
        /// <summary>Data e horário de início do agendamento.</summary>
        public DateTime InicioAgendamento { get; }

        /// <summary>Data e horário de início do agendamento.</summary>
        public DateTime FimAgendamento { get; }
    }
}