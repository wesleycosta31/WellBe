using WellBe.Business.Parceiros;

namespace WellBe.Business.Profissionais.Agenda
{
    public class Agendamento
    {
        /// <summary>Data e horário de início do agendamento.</summary>
        public DateTime InicioAgendamento { get; }

        /// <summary>Data e horário de início do agendamento.</summary>
        public DateTime FimAgendamento { get; }

        /// <summary>Profissional responsável pelo atendimento agendado.</summary>
        public Profissional Profissional { get; }
        
        /// <summary>Empresa do parceiro ao qual o profissional está associado.</summary>
        public EmpresaParceiro?  EmpresaPareciro { get; }
    }
}