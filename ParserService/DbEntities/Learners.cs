using ParserServices.DbEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebTools.ParserService.DbEntities
{
    public class Learners
    {
        #region Properties
        public int Id { get; set; }
        public string LearnRefNumber { get; set; }
        public string PrevLearnRefNumber { get; set; }
        public string PMUKPRN { get; set; }
        public string CampId { get; set; }
        public string ULN { get; set; }
        public string FamilyName { get; set; }
        public string GivenNames { get; set; }
        public string DateOfBirth { get; set; }
        public string Ethnicity { get; set; }
        public string Sex { get; set; }
        public string LLDDHealthProb { get; set; }
        public string NINumber { get; set; }
        public string PriorAttain { get; set; }
        public string Accom { get; set; }
        public string ALSCost { get; set; }
        public string PlanLearnHours { get; set; }
        public string PlanEEPHours { get; set; }
        public string MathGrade { get; set; }
        public string EngGrade { get; set; }
        public string PostcodePrior { get; set; }
        public string Postcode { get; set; }
        public string AddLine1 { get; set; }
        public string LLDDandHealthProblem { get; set; }
        public string LLDDandHealthProblemLLDDCat { get; set; }
        public string LLDDandHealthProblemPrimaryLLDD { get; set; }
        public string AddLine2 { get; set; }
        public string AddLine3 { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string ContactPreferenceContPrefType { get; set; }
        public string ContactPreferenceContPrefCode { get; set; }
        public string ProviderSpecLearnerMonitoringProvSpecLearnMonOccur { get; set; }
        public string ProvSpecLearnMon { get; set; }
        public string LearnerFAMLearnFAMType { get; set; }
        public string LearnerFAMLearnFAMCode { get; set; }
        public string LearnerEmploymentStatusEmpStat { get; set; }
        public string LearnerEmploymentStatusDateEmpStatApp { get; set; }
        public string LearnerEmploymentStatusEmpId { get; set; }
        public string LearnerEmploymentStatusEmploymentStatusMonitoringESMType { get; set; }
        public string LearnerEmploymentStatusEmploymentStatusMonitoringESMCode { get; set; }
        public string LearningDeliveryLearnAimRef { get; set; }
        public string LearningDeliveryAimType { get; set; }
        public string LearningDeliveryAimSeqNumber { get; set; }
        public string LearningDeliveryLearnStartDate { get; set; }
        public string LearningDeliveryOrigLearnStartDate { get; set; }
        public string LearningDeliveryLearnPlanEndDate { get; set; }
        public string LearningDeliveryFundModel { get; set; }
        public string LearningDeliveryPHours { get; set; }
        public string LearningDeliveryProgType { get; set; }
        public string LearningDeliveryStdCode { get; set; }
        public string LearningDeliveryFworkCode { get; set; }
        public string LearningDeliveryPwayCode { get; set; }
        public string LearningDeliveryDelLocPostCode { get; set; }
        public string LearningDeliveryEPAOrgID { get; set; }
        public string LearningDeliveryPriorLearnFundAdj { get; set; }
        public string LearningDeliveryConRefNumber { get; set; }
        public string LearningDeliveryLSDPostcode { get; set; }
        public string LearningDeliveryCompStatus { get; set; }
        public string LearningDeliveryLearnActEndDate { get; set; }
        public string LearningDeliveryWithdrawReason { get; set; }
        public string LearningDeliveryOutcome { get; set; }
        public string LearningDeliveryOutGrade { get; set; }
        public string LearningDeliveryAchDate { get; set; }
        public string LearningDeliverySWSupAimId { get; set; }
        public string LearningDeliveryLearningDeliveryFAMLearnDelFAMType { get; set; }
        public string LearningDeliveryLearningDeliveryFAMLearnDelFAMCode { get; set; }
        public string LearningDeliveryLearningDeliveryFAMLearnDelFAMDateFrom { get; set; }
        public string LearningDeliveryLearningDeliveryFAMLearnDelFAMDateTo { get; set; }
        public string LearningDeliveryProviderSpecDeliveryMonitoringProvSpecDelMonOccur { get; set; }
        public string LearningDeliveryProviderSpecDeliveryMonitoringProvSpecDelMon { get; set; }
        public string LearningDeliveryLearningDeliveryHENUMHUS { get; set; }
        public string LearningDeliveryLearningDeliveryHESSN { get; set; }
        public string LearningDeliveryLearningDeliveryHEQUALENT3 { get; set; }
        public string LearningDeliveryLearningDeliveryHESOC2000 { get; set; }
        public string LearningDeliveryLearningDeliveryHESEC { get; set; }
        public string LearningDeliveryLearningDeliveryHEUCASAPPID { get; set; }
        public string LearningDeliveryLearningDeliveryHETYPEYR { get; set; }
        public string LearningDeliveryLearningDeliveryHEMODESTUD { get; set; }
        public string LearningDeliveryLearningDeliveryHEFUNDLEV { get; set; }
        public string LearningDeliveryLearningDeliveryHEFUNDCOMP { get; set; }
        public string LearningDeliveryLearningDeliveryHESTULOAD { get; set; }
        public string LearningDeliveryLearningDeliveryHEYEARSTU { get; set; }
        public string LearningDeliveryLearningDeliveryHEMSTUFEE { get; set; }
        public string LearningDeliveryLearningDeliveryHEPCFLDCS { get; set; }
        public string LearningDeliveryLearningDeliveryHESPECFEE { get; set; }
        public string LearningDeliveryLearningDeliveryHENETFEE { get; set; }
        public string LearningDeliveryLearningDeliveryHEGROSSFEE { get; set; }
        public string LearningDeliveryLearningDeliveryHEDOMICILE { get; set; }
        public string LearningDeliveryLearningDeliveryHEELQ { get; set; }
        public string LearningDeliveryLearningDeliveryHEHEPostCode { get; set; }
        public string LearningDeliveryAppFinRecordAFinType { get; set; }
        public string LearningDeliveryAppFinRecordAFinCode { get; set; }
        public string LearningDeliveryAppFinRecordAFinDate { get; set; }
        public string LearningDeliveryAppFinRecordAFinAmount { get; set; }
        public string LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceStartDate { get; set; }
        public string LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEndDate { get; set; }
        public string LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceHours { get; set; }
        public string LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceMode { get; set; }
        public string LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEmpId { get; set; }
        public string LearnerHEUCASPERID { get; set; }
        public string LearnerHETTACCOM { get; set; }
        public string LearnerHELearnerHEFinancialSupportFINTYPE { get; set; }
        public string LearnerHELearnerHEFinancialSupportFINAMOUNT { get; set; }

        #endregion

        public Learners()
        {

        }
        public static List<Learners> CastMessageToLearner(Message message)
        {
            List<Learners> learners = new List<Learners>();
            if (message.Learner.Count() > 0)
            {
                Learners learner = new Learners();
                foreach (var item in message.Learner)
                {
                    learner.LearnRefNumber = item.Items[0].ToString();
                    learner.PMUKPRN = item.Items[1].ToString();
                    learner.CampId = item.Items[2].ToString();
                    learner.ULN = item.Items[3].ToString();
                    learner.FamilyName = item.Items[4].ToString();
                    learner.GivenNames = item.Items[5].ToString();
                    learner.DateOfBirth = item.Items[6].ToString();
                    learner.Ethnicity = item.Items[7].ToString();
                    learner.Sex = item.Items[8].ToString();
                    learner.LLDDHealthProb = item.Items[9].ToString();
                    learner.Accom = item.Items[10].ToString();
                    learner.PlanLearnHours = item.Items[11].ToString();
                    learner.PlanEEPHours = item.Items[12].ToString();
                    learner.MathGrade = item.Items[13].ToString();
                    learner.EngGrade = item.Items[14].ToString();
                    learner.PostcodePrior = item.Items[15].ToString();
                    learner.Postcode = item.Items[16].ToString();
                    learner.AddLine1 = item.Items[17].ToString();
                    learner.AddLine2 = item.Items[18].ToString();
                    break;
                }
                for (int i = 19; i < 23; i++)
                {
                    var messagelearningFam = (MessageLearnerLearnerFAM)message.Learner[0].Items[i];
                    learner.LearnerFAMLearnFAMCode = messagelearningFam.LearnFAMCode.ToString();
                    learner.LearnerFAMLearnFAMType = messagelearningFam.LearnFAMType.ToString();
                    learners.Add(learner);
                }
                for (int i = 23; i < 25; i++)
                {
                    var messageLearnerLearningDelivery = (MessageLearnerLearningDelivery)message.Learner[0].Items[i];
                    learner.LearningDeliveryAchDate = messageLearnerLearningDelivery.AchDate.ToString();
                    learner.LearningDeliveryAimSeqNumber = messageLearnerLearningDelivery.AimSeqNumber.ToString();
                    learner.LearningDeliveryAimType = messageLearnerLearningDelivery.AimType.ToString();
                    learner.LearningDeliveryAppFinRecordAFinAmount = messageLearnerLearningDelivery?.AppFinRecord?[0].AFinAmount.ToString();
                    learner.LearningDeliveryAppFinRecordAFinCode = messageLearnerLearningDelivery?.AppFinRecord?[0].AFinCode.ToString();
                    learner.LearningDeliveryAppFinRecordAFinDate = messageLearnerLearningDelivery?.AppFinRecord?[0].AFinDate.ToString();
                    learner.LearningDeliveryAppFinRecordAFinType = messageLearnerLearningDelivery?.AppFinRecord?[0].AFinType.ToString();

                    learner.LearningDeliveryCompStatus = messageLearnerLearningDelivery?.CompStatus.ToString();
                    learner.LearningDeliveryConRefNumber = messageLearnerLearningDelivery?.ConRefNumber?.ToString();
                    learner.LearningDeliveryDelLocPostCode = messageLearnerLearningDelivery?.DelLocPostCode?.ToString();
                    learner.LearningDeliveryEPAOrgID = messageLearnerLearningDelivery?.EPAOrgID?.ToString();
                    learner.LearningDeliveryFundModel = messageLearnerLearningDelivery?.FundModel.ToString();
                    learner.LearningDeliveryFworkCode = messageLearnerLearningDelivery?.FworkCode.ToString();
                    learner.LearningDeliveryLearnActEndDate = messageLearnerLearningDelivery?.LearnActEndDate.ToString();

                    learner.LearningDeliveryLearnAimRef = messageLearnerLearningDelivery.LearnAimRef.ToString();
                    learner.LearningDeliveryLearningDeliveryFAMLearnDelFAMCode = messageLearnerLearningDelivery.LearningDeliveryFAM?[0].LearnDelFAMCode.ToString();
                    learner.LearningDeliveryLearningDeliveryFAMLearnDelFAMDateFrom = messageLearnerLearningDelivery.LearningDeliveryFAM?[0]?.LearnDelFAMDateFrom.ToString();
                    learner.LearningDeliveryLearningDeliveryFAMLearnDelFAMDateTo = messageLearnerLearningDelivery.LearningDeliveryFAM?[0]?.LearnDelFAMDateTo.ToString();
                    learner.LearnerFAMLearnFAMType = messageLearnerLearningDelivery.LearningDeliveryFAM[0]?.LearnDelFAMType?.ToString();

                    learner.LearningDeliveryLearningDeliveryHEDOMICILE = messageLearnerLearningDelivery?.LearningDeliveryHE?.DOMICILE?.ToString();
                    learner.LearningDeliveryLearningDeliveryHEELQ = messageLearnerLearningDelivery?.LearningDeliveryHE?.ELQ.ToString();
                    learner.LearningDeliveryLearningDeliveryHEFUNDCOMP = messageLearnerLearningDelivery?.LearningDeliveryHE?.FUNDCOMP.ToString();
                    learner.LearningDeliveryLearningDeliveryHEFUNDLEV = messageLearnerLearningDelivery?.LearningDeliveryHE?.FUNDLEV.ToString();
                    learner.LearningDeliveryLearningDeliveryHEGROSSFEE = messageLearnerLearningDelivery?.LearningDeliveryHE?.GROSSFEE.ToString();
                    learner.LearningDeliveryLearningDeliveryHEHEPostCode = messageLearnerLearningDelivery?.LearningDeliveryHE?.HEPostCode?.ToString();
                    learner.LearningDeliveryLearningDeliveryHEMODESTUD = messageLearnerLearningDelivery?.LearningDeliveryHE?.MODESTUD.ToString();
                    learner.LearningDeliveryLearningDeliveryHEMSTUFEE = messageLearnerLearningDelivery?.LearningDeliveryHE?.MSTUFEE.ToString();
                    learner.LearningDeliveryLearningDeliveryHENETFEE = messageLearnerLearningDelivery?.LearningDeliveryHE?.NETFEE.ToString();
                    learner.LearningDeliveryLearningDeliveryHENUMHUS = messageLearnerLearningDelivery?.LearningDeliveryHE?.NUMHUS.ToString();
                    learner.LearningDeliveryLearningDeliveryHEPCFLDCS = messageLearnerLearningDelivery?.LearningDeliveryHE?.PCFLDCS.ToString();
                    learner.LearningDeliveryLearningDeliveryHEQUALENT3 = messageLearnerLearningDelivery?.LearningDeliveryHE?.QUALENT3.ToString();
                    learner.LearningDeliveryLearningDeliveryHESEC = messageLearnerLearningDelivery?.LearningDeliveryHE?.SEC.ToString();
                    learner.LearningDeliveryLearningDeliveryHESOC2000 = messageLearnerLearningDelivery?.LearningDeliveryHE?.SOC2000.ToString();
                    learner.LearningDeliveryLearningDeliveryHESPECFEE = messageLearnerLearningDelivery?.LearningDeliveryHE?.SPECFEE.ToString();
                    learner.LearningDeliveryLearningDeliveryHESSN = messageLearnerLearningDelivery?.LearningDeliveryHE?.SSN.ToString();
                    learner.LearningDeliveryLearningDeliveryHEMODESTUD = messageLearnerLearningDelivery?.LearningDeliveryHE?.STULOAD.ToString();
                    learner.LearningDeliveryLearningDeliveryHETYPEYR = messageLearnerLearningDelivery?.LearningDeliveryHE?.TYPEYR.ToString();
                    learner.LearningDeliveryLearningDeliveryHEUCASAPPID = messageLearnerLearningDelivery?.LearningDeliveryHE?.UCASAPPID.ToString();
                    learner.LearningDeliveryLearningDeliveryHEYEARSTU = messageLearnerLearningDelivery?.LearningDeliveryHE?.YEARSTU.ToString();


                    learner.LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEmpId = messageLearnerLearningDelivery?.LearningDeliveryWorkPlacement?.WorkPlaceEmpId.ToString();
                    learner.LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEndDate = messageLearnerLearningDelivery?.LearningDeliveryWorkPlacement?.WorkPlaceEndDate.ToString();
                    learner.LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEndDate = messageLearnerLearningDelivery?.LearningDeliveryWorkPlacement?.WorkPlaceEndDateSpecified.ToString();
                    learner.LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceHours = messageLearnerLearningDelivery?.LearningDeliveryWorkPlacement?.WorkPlaceHours.ToString();
                    learner.LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceMode = messageLearnerLearningDelivery?.LearningDeliveryWorkPlacement?.WorkPlaceMode.ToString();
                    learner.LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceStartDate = messageLearnerLearningDelivery?.LearningDeliveryWorkPlacement?.WorkPlaceStartDate.ToString();

                    learner.LearningDeliveryLearnPlanEndDate = messageLearnerLearningDelivery?.LearnPlanEndDate.ToString();
                    learner.LearningDeliveryLearnStartDate = messageLearnerLearningDelivery?.LearnStartDate.ToString();
                    learner.LearningDeliveryDelLocPostCode = messageLearnerLearningDelivery?.LSDPostcode?.ToString();
                    learner.LearningDeliveryOrigLearnStartDate = messageLearnerLearningDelivery?.OrigLearnStartDate.ToString();
                    learner.LearningDeliveryOutcome = messageLearnerLearningDelivery?.Outcome.ToString();
                    learner.LearningDeliveryOutGrade = messageLearnerLearningDelivery?.OutGrade?.ToString();
                    learner.LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceHours = messageLearnerLearningDelivery?.PHours.ToString();

                    learner.LearningDeliveryPriorLearnFundAdj = messageLearnerLearningDelivery?.PriorLearnFundAdj.ToString();
                    learner.LearningDeliveryProgType = messageLearnerLearningDelivery?.ProgType.ToString();
                    learner.LearningDeliveryProviderSpecDeliveryMonitoringProvSpecDelMon = messageLearnerLearningDelivery?.ProviderSpecDeliveryMonitoring?.ToString();
                    learner.LearningDeliveryPwayCode = messageLearnerLearningDelivery?.PwayCode.ToString();
                    learner.LearningDeliveryStdCode = messageLearnerLearningDelivery?.StdCode.ToString();
                    learner.LearningDeliverySWSupAimId = messageLearnerLearningDelivery?.SWSupAimId?.ToString();
                    learner.LearningDeliveryWithdrawReason = messageLearnerLearningDelivery?.WithdrawReason.ToString();
                    learners.Add(learner);
                }
            }
            return learners;
        }
        public static List<Learners> GetLearners()
        {
            List<Learners> lst = new List<Learners>();
            string connectionString = DbConstants.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = DbConstants.SelectLearner;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(new Learners
                    {
                        Id = int.Parse(reader.GetValue(0).ToString()),
                        LearnRefNumber = reader.GetValue(1).ToString(),
                        PrevLearnRefNumber = reader.GetValue(2).ToString(),
                        PMUKPRN = reader.GetValue(3).ToString(),
                        CampId = reader.GetValue(4).ToString(),
                        ULN = reader.GetValue(5).ToString(),
                        FamilyName = reader.GetValue(6).ToString(),
                        GivenNames = reader.GetValue(7).ToString(),
                        DateOfBirth = reader.GetValue(8).ToString(),
                        Ethnicity = reader.GetValue(9).ToString(),
                        Sex = reader.GetValue(10).ToString(),
                        LLDDHealthProb = reader.GetValue(11).ToString(),
                        NINumber = reader.GetValue(12).ToString(),
                        PriorAttain = reader.GetValue(13).ToString(),
                        Accom = reader.GetValue(14).ToString(),
                        ALSCost = reader.GetValue(15).ToString(),
                        PlanLearnHours = reader.GetValue(16).ToString(),
                        PlanEEPHours = reader.GetValue(17).ToString(),
                        MathGrade = reader.GetValue(18).ToString(),
                        EngGrade = reader.GetValue(19).ToString(),
                        PostcodePrior = reader.GetValue(20).ToString(),
                        Postcode = reader.GetValue(21).ToString(),
                        AddLine1 = reader.GetValue(22).ToString(),
                        LLDDandHealthProblem = reader.GetValue(23).ToString(),
                        LLDDandHealthProblemLLDDCat = reader.GetValue(24).ToString(),
                        LLDDandHealthProblemPrimaryLLDD = reader.GetValue(25).ToString(),
                        AddLine2 = reader.GetValue(26).ToString(),
                        AddLine3 = reader.GetValue(27).ToString(),
                        TelNo = reader.GetValue(28).ToString(),
                        Email = reader.GetValue(29).ToString(),
                        ContactPreferenceContPrefType = reader.GetValue(30).ToString(),
                        ContactPreferenceContPrefCode = reader.GetValue(31).ToString(),
                        ProviderSpecLearnerMonitoringProvSpecLearnMonOccur = reader.GetValue(32).ToString(),
                        ProvSpecLearnMon = reader.GetValue(33).ToString(),
                        LearnerFAMLearnFAMType = reader.GetValue(34).ToString(),
                        LearnerFAMLearnFAMCode = reader.GetValue(35).ToString(),
                        LearnerEmploymentStatusEmpStat = reader.GetValue(36).ToString(),
                        LearnerEmploymentStatusDateEmpStatApp = reader.GetValue(37).ToString(),
                        LearnerEmploymentStatusEmpId = reader.GetValue(38).ToString(),
                        LearnerEmploymentStatusEmploymentStatusMonitoringESMType = reader.GetValue(39).ToString(),
                        LearnerEmploymentStatusEmploymentStatusMonitoringESMCode = reader.GetValue(40).ToString(),
                        LearningDeliveryLearnAimRef = reader.GetValue(41).ToString(),
                        LearningDeliveryAimType = reader.GetValue(42).ToString(),
                        LearningDeliveryAimSeqNumber = reader.GetValue(43).ToString(),
                        LearningDeliveryLearnStartDate = reader.GetValue(44).ToString(),
                        LearningDeliveryOrigLearnStartDate = reader.GetValue(45).ToString(),
                        LearningDeliveryLearnPlanEndDate = reader.GetValue(46).ToString(),
                        LearningDeliveryFundModel = reader.GetValue(47).ToString(),
                        LearningDeliveryPHours = reader.GetValue(48).ToString(),
                        LearningDeliveryProgType = reader.GetValue(49).ToString(),
                        LearningDeliveryStdCode = reader.GetValue(50).ToString(),
                        LearningDeliveryFworkCode = reader.GetValue(51).ToString(),
                        LearningDeliveryPwayCode = reader.GetValue(52).ToString(),
                        LearningDeliveryDelLocPostCode = reader.GetValue(53).ToString(),
                        LearningDeliveryEPAOrgID = reader.GetValue(54).ToString(),
                        LearningDeliveryPriorLearnFundAdj = reader.GetValue(55).ToString(),
                        LearningDeliveryConRefNumber = reader.GetValue(56).ToString(),
                        LearningDeliveryLSDPostcode = reader.GetValue(57).ToString(),
                        LearningDeliveryCompStatus = reader.GetValue(58).ToString(),
                        LearningDeliveryLearnActEndDate = reader.GetValue(59).ToString(),
                        LearningDeliveryWithdrawReason = reader.GetValue(60).ToString(),
                        LearningDeliveryOutcome = reader.GetValue(61).ToString(),
                        LearningDeliveryOutGrade = reader.GetValue(62).ToString(),
                        LearningDeliveryAchDate = reader.GetValue(63).ToString(),
                        LearningDeliverySWSupAimId = reader.GetValue(64).ToString(),
                        LearningDeliveryLearningDeliveryFAMLearnDelFAMType = reader.GetValue(65).ToString(),
                        LearningDeliveryLearningDeliveryFAMLearnDelFAMCode = reader.GetValue(66).ToString(),
                        LearningDeliveryLearningDeliveryFAMLearnDelFAMDateFrom = reader.GetValue(67).ToString(),
                        LearningDeliveryLearningDeliveryFAMLearnDelFAMDateTo = reader.GetValue(68).ToString(),
                        LearningDeliveryProviderSpecDeliveryMonitoringProvSpecDelMonOccur = reader.GetValue(69).ToString(),
                        LearningDeliveryProviderSpecDeliveryMonitoringProvSpecDelMon = reader.GetValue(70).ToString(),
                        LearningDeliveryLearningDeliveryHENUMHUS = reader.GetValue(71).ToString(),
                        LearningDeliveryLearningDeliveryHESSN = reader.GetValue(72).ToString(),
                        LearningDeliveryLearningDeliveryHEQUALENT3 = reader.GetValue(73).ToString(),
                        LearningDeliveryLearningDeliveryHESOC2000 = reader.GetValue(74).ToString(),
                        LearningDeliveryLearningDeliveryHESEC = reader.GetValue(75).ToString(),
                        LearningDeliveryLearningDeliveryHEUCASAPPID = reader.GetValue(76).ToString(),
                        LearningDeliveryLearningDeliveryHETYPEYR = reader.GetValue(77).ToString(),
                        LearningDeliveryLearningDeliveryHEMODESTUD = reader.GetValue(78).ToString(),
                        LearningDeliveryLearningDeliveryHEFUNDLEV = reader.GetValue(79).ToString(),
                        LearningDeliveryLearningDeliveryHEFUNDCOMP = reader.GetValue(80).ToString(),
                        LearningDeliveryLearningDeliveryHESTULOAD = reader.GetValue(81).ToString(),
                        LearningDeliveryLearningDeliveryHEYEARSTU = reader.GetValue(82).ToString(),
                        LearningDeliveryLearningDeliveryHEMSTUFEE = reader.GetValue(83).ToString(),
                        LearningDeliveryLearningDeliveryHEPCFLDCS = reader.GetValue(84).ToString(),
                        LearningDeliveryLearningDeliveryHESPECFEE = reader.GetValue(85).ToString(),
                        LearningDeliveryLearningDeliveryHENETFEE = reader.GetValue(86).ToString(),
                        LearningDeliveryLearningDeliveryHEGROSSFEE = reader.GetValue(87).ToString(),
                        LearningDeliveryLearningDeliveryHEDOMICILE = reader.GetValue(88).ToString(),
                        LearningDeliveryLearningDeliveryHEELQ = reader.GetValue(89).ToString(),
                        LearningDeliveryLearningDeliveryHEHEPostCode = reader.GetValue(90).ToString(),
                        LearningDeliveryAppFinRecordAFinType = reader.GetValue(91).ToString(),
                        LearningDeliveryAppFinRecordAFinCode = reader.GetValue(92).ToString(),
                        LearningDeliveryAppFinRecordAFinDate = reader.GetValue(93).ToString(),
                        LearningDeliveryAppFinRecordAFinAmount = reader.GetValue(94).ToString(),
                        LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceStartDate = reader.GetValue(95).ToString(),
                        LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEndDate = reader.GetValue(96).ToString(),
                        LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceHours = reader.GetValue(97).ToString(),
                        LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceMode = reader.GetValue(98).ToString(),
                        LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEmpId = reader.GetValue(99).ToString(),
                        LearnerHEUCASPERID = reader.GetValue(100).ToString(),
                        LearnerHETTACCOM = reader.GetValue(101).ToString(),
                        LearnerHELearnerHEFinancialSupportFINTYPE = reader.GetValue(102).ToString(),
                        LearnerHELearnerHEFinancialSupportFINAMOUNT = reader.GetValue(103).ToString()
                    });
                }
                connection.Close();
            }
            return lst;
        }

        public int AddToDatabase()
        {
            int readerValue = 0;
            string connectionString = DbConstants.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = DbConstants.InsertLearner;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@LearnRefNumber", LearnRefNumber);
                command.Parameters.AddWithValue("@PrevLearnRefNumber", PrevLearnRefNumber);
                command.Parameters.AddWithValue("@PMUKPRN", PMUKPRN);
                command.Parameters.AddWithValue("@CampId", CampId);
                command.Parameters.AddWithValue("@ULN", ULN);
                command.Parameters.AddWithValue("@FamilyName", FamilyName);
                command.Parameters.AddWithValue("@GivenNames", GivenNames);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Ethnicity", Ethnicity);
                command.Parameters.AddWithValue("@Sex", Sex);
                command.Parameters.AddWithValue("@LLDDHealthProb", LLDDHealthProb);
                command.Parameters.AddWithValue("@NINumber", NINumber);
                command.Parameters.AddWithValue("@PriorAttain", PriorAttain);
                command.Parameters.AddWithValue("@Accom", Accom);
                command.Parameters.AddWithValue("@ALSCost", ALSCost);
                command.Parameters.AddWithValue("@PlanLearnHours", PlanLearnHours);
                command.Parameters.AddWithValue("@PlanEEPHours", PlanEEPHours);
                command.Parameters.AddWithValue("@MathGrade", MathGrade);
                command.Parameters.AddWithValue("@EngGrade", EngGrade);
                command.Parameters.AddWithValue("@PostcodePrior", PostcodePrior);
                command.Parameters.AddWithValue("@Postcode", Postcode);
                command.Parameters.AddWithValue("@AddLine1", AddLine1);
                command.Parameters.AddWithValue("@LLDDandHealthProblem", LLDDandHealthProblem);
                command.Parameters.AddWithValue("@LLDDandHealthProblemLLDDCat", LLDDandHealthProblemLLDDCat);
                command.Parameters.AddWithValue("@LLDDandHealthProblemPrimaryLLDD", LLDDandHealthProblemPrimaryLLDD);
                command.Parameters.AddWithValue("@AddLine2", AddLine2);
                command.Parameters.AddWithValue("@AddLine3", AddLine3);
                command.Parameters.AddWithValue("@TelNo", TelNo);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@ContactPreferenceContPrefType", ContactPreferenceContPrefType);
                command.Parameters.AddWithValue("@ContactPreferenceContPrefCode", ContactPreferenceContPrefCode);
                command.Parameters.AddWithValue("@ProviderSpecLearnerMonitoringProvSpecLearnMonOccur", ProviderSpecLearnerMonitoringProvSpecLearnMonOccur);
                command.Parameters.AddWithValue("@ProvSpecLearnMon", ProvSpecLearnMon);
                command.Parameters.AddWithValue("@LearnerFAMLearnFAMType", LearnerFAMLearnFAMType);
                command.Parameters.AddWithValue("@LearnerFAMLearnFAMCode", LearnerFAMLearnFAMCode);
                command.Parameters.AddWithValue("@LearnerEmploymentStatusEmpStat", LearnerEmploymentStatusEmpStat);
                command.Parameters.AddWithValue("@LearnerEmploymentStatusDateEmpStatApp", LearnerEmploymentStatusDateEmpStatApp);
                command.Parameters.AddWithValue("@LearnerEmploymentStatusEmpId", LearnerEmploymentStatusEmpId);
                command.Parameters.AddWithValue("@LearnerEmploymentStatusEmploymentStatusMonitoringESMType", LearnerEmploymentStatusEmploymentStatusMonitoringESMType);
                command.Parameters.AddWithValue("@LearnerEmploymentStatusEmploymentStatusMonitoringESMCode", LearnerEmploymentStatusEmploymentStatusMonitoringESMCode);
                command.Parameters.AddWithValue("@LearningDeliveryLearnAimRef", LearningDeliveryLearnAimRef);
                command.Parameters.AddWithValue("@LearningDeliveryAimType", LearningDeliveryAimType);
                command.Parameters.AddWithValue("@LearningDeliveryAimSeqNumber", LearningDeliveryAimSeqNumber);
                command.Parameters.AddWithValue("@LearningDeliveryLearnStartDate", LearningDeliveryLearnStartDate);
                command.Parameters.AddWithValue("@LearningDeliveryOrigLearnStartDate", LearningDeliveryOrigLearnStartDate);
                command.Parameters.AddWithValue("@LearningDeliveryLearnPlanEndDate", LearningDeliveryLearnPlanEndDate);
                command.Parameters.AddWithValue("@LearningDeliveryFundModel", LearningDeliveryFundModel);
                command.Parameters.AddWithValue("@LearningDeliveryPHours", LearningDeliveryPHours);
                command.Parameters.AddWithValue("@LearningDeliveryProgType", LearningDeliveryProgType);
                command.Parameters.AddWithValue("@LearningDeliveryStdCode", LearningDeliveryStdCode);
                command.Parameters.AddWithValue("@LearningDeliveryFworkCode", LearningDeliveryFworkCode);
                command.Parameters.AddWithValue("@LearningDeliveryPwayCode", LearningDeliveryPwayCode);
                command.Parameters.AddWithValue("@LearningDeliveryDelLocPostCode", LearningDeliveryDelLocPostCode);
                command.Parameters.AddWithValue("@LearningDeliveryEPAOrgID", LearningDeliveryEPAOrgID);
                command.Parameters.AddWithValue("@LearningDeliveryPriorLearnFundAdj", LearningDeliveryPriorLearnFundAdj);
                command.Parameters.AddWithValue("@LearningDeliveryConRefNumber", LearningDeliveryConRefNumber);
                command.Parameters.AddWithValue("@LearningDeliveryLSDPostcode", LearningDeliveryLSDPostcode);
                command.Parameters.AddWithValue("@LearningDeliveryCompStatus", LearningDeliveryCompStatus);
                command.Parameters.AddWithValue("@LearningDeliveryLearnActEndDate", LearningDeliveryLearnActEndDate);
                command.Parameters.AddWithValue("@LearningDeliveryWithdrawReason", LearningDeliveryWithdrawReason);
                command.Parameters.AddWithValue("@LearningDeliveryOutcome", LearningDeliveryOutcome);
                command.Parameters.AddWithValue("@LearningDeliveryOutGrade", LearningDeliveryOutGrade);
                command.Parameters.AddWithValue("@LearningDeliveryAchDate", LearningDeliveryAchDate);
                command.Parameters.AddWithValue("@LearningDeliverySWSupAimId", LearningDeliverySWSupAimId);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryFAMLearnDelFAMType", LearningDeliveryLearningDeliveryFAMLearnDelFAMType);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryFAMLearnDelFAMCode", LearningDeliveryLearningDeliveryFAMLearnDelFAMCode);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryFAMLearnDelFAMDateFrom", LearningDeliveryLearningDeliveryFAMLearnDelFAMDateFrom);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryFAMLearnDelFAMDateTo", LearningDeliveryLearningDeliveryFAMLearnDelFAMDateTo);
                command.Parameters.AddWithValue("@LearningDeliveryProviderSpecDeliveryMonitoringProvSpecDelMonOccur", LearningDeliveryProviderSpecDeliveryMonitoringProvSpecDelMonOccur);
                command.Parameters.AddWithValue("@LearningDeliveryProviderSpecDeliveryMonitoringProvSpecDelMon", LearningDeliveryProviderSpecDeliveryMonitoringProvSpecDelMon);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHENUMHUS", LearningDeliveryLearningDeliveryHENUMHUS);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHESSN", LearningDeliveryLearningDeliveryHESSN);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEQUALENT3", LearningDeliveryLearningDeliveryHEQUALENT3);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHESOC2000", LearningDeliveryLearningDeliveryHESOC2000);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHESEC", LearningDeliveryLearningDeliveryHESEC);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEUCASAPPID", LearningDeliveryLearningDeliveryHEUCASAPPID);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHETYPEYR", LearningDeliveryLearningDeliveryHETYPEYR);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEMODESTUD", LearningDeliveryLearningDeliveryHEMODESTUD);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEFUNDLEV", LearningDeliveryLearningDeliveryHEFUNDLEV);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEFUNDCOMP", LearningDeliveryLearningDeliveryHEFUNDCOMP);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHESTULOAD", LearningDeliveryLearningDeliveryHESTULOAD);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEYEARSTU", LearningDeliveryLearningDeliveryHEYEARSTU);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEMSTUFEE", LearningDeliveryLearningDeliveryHEMSTUFEE);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEPCFLDCS", LearningDeliveryLearningDeliveryHEPCFLDCS);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHESPECFEE", LearningDeliveryLearningDeliveryHESPECFEE);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHENETFEE", LearningDeliveryLearningDeliveryHENETFEE);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEGROSSFEE", LearningDeliveryLearningDeliveryHEGROSSFEE);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEDOMICILE", LearningDeliveryLearningDeliveryHEDOMICILE);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEELQ", LearningDeliveryLearningDeliveryHEELQ);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryHEHEPostCode", LearningDeliveryLearningDeliveryHEHEPostCode);
                command.Parameters.AddWithValue("@LearningDeliveryAppFinRecordAFinType", LearningDeliveryAppFinRecordAFinType);
                command.Parameters.AddWithValue("@LearningDeliveryAppFinRecordAFinCode", LearningDeliveryAppFinRecordAFinCode);
                command.Parameters.AddWithValue("@LearningDeliveryAppFinRecordAFinDate", LearningDeliveryAppFinRecordAFinDate);
                command.Parameters.AddWithValue("@LearningDeliveryAppFinRecordAFinAmount", LearningDeliveryAppFinRecordAFinAmount);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceStartDate", LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceStartDate);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEndDate", LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEndDate);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceHours", LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceHours);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceMode", LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceMode);
                command.Parameters.AddWithValue("@LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEmpId", LearningDeliveryLearningDeliveryWorkPlacementWorkPlaceEmpId);
                command.Parameters.AddWithValue("@LearnerHEUCASPERID", LearnerHEUCASPERID);
                command.Parameters.AddWithValue("@LearnerHETTACCOM", LearnerHETTACCOM);
                command.Parameters.AddWithValue("@LearnerHELearnerHEFinancialSupportFINTYPE", LearnerHELearnerHEFinancialSupportFINTYPE);
                command.Parameters.AddWithValue("@LearnerHELearnerHEFinancialSupportFINAMOUNT", LearnerHELearnerHEFinancialSupportFINAMOUNT);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    readerValue = int.Parse(reader.GetValue(0).ToString());
                }
                connection.Close();
            }
            return readerValue;
        }
    }
}
