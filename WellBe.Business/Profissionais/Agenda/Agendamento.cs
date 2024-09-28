using WellBe.Business.Profissionais.Enums;

namespace WellBe.Business.Profissionais.Agenda
{
    public class Agendamento
    {
        /// <summary>Data e horário do início do agendamento.</summary>
        public DateTime HorarioInicioAtendimento{ get; }

        /// <summary>Data e horário do fim do agendamento.</summary>
        public DateTime HorarioFimAtendimento { get; }

        /// <summary>Código de identificação da agenda do profissional responsável pelo atendimento agendado.</summary>
        public int IdAgenda { get; }

        /// <summary>Còdigo de identificação do profissional responsável pelo atendimento agendado.</summary>
        public int IdProfissional { get; }

        /// <summary>Código de identificação do parceiro para o qual o profissional está atendendo.</summary>
        public int IdParceiro { get; }

        /// <summary>Status do agendamento</summary>
        public StatusAgendamento Status { get; }
    }
}