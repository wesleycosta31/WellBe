namespace WellBe.Business.Profissionais.Agenda
{
    public class Agenda
    {
        /// <summary>Código de identificação da agenda.</summary>
        public int IdAgenda { get; }

        /// <summary>Código de identificação da agenda do profissional.</summary>
        public int IdProfissional { get; }
        
        /// <summary>Data e horário da abertura da agenda do profissional.</summary>
        public DateTime HorarioAberturaAgenda { get; }

        /// <summary>Data e horário do fechamento da agenda.</summary>
        public DateTime HorarioFechamentoAgenda { get; }

        /// <summary>Horários de intervalo sem atendimento.</summary>
        public IEnumerable<DateTime> IntervalosAgenda { get; }

        /// <summary>Indica se a agenda do profissional pode receber agendamentos.</summary>
        public bool PodeReceberAgendamentos { get; }
    }
}