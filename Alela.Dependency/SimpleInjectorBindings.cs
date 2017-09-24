//using Alela.BL.Interfaces;
//using Alela.BL.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;

namespace Alela.Dependency
{
    public static class SimpleInjectorBindings
    {
        public static Container GetContainer()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Register your types, for instance:
            //container.Register<ICompanyService, CompanyService>(Lifestyle.Scoped);
            //container.Register<IContractService, ContractService>(Lifestyle.Scoped);
            //container.Register<ICostCenterService, CostCenterService>(Lifestyle.Scoped);
            //container.Register<ICountryService, CountryService>(Lifestyle.Scoped);
            //container.Register<IDashboardAdminPanelService, DashboardAdminPanelService>(Lifestyle.Scoped);
            //container.Register<IDateTimeFormatService, DateTimeFormatService>(Lifestyle.Scoped);
            //container.Register<IEmployeeProfileSetupService, EmployeeProfileSetupService>(Lifestyle.Scoped);
            //container.Register<IEnterpriseUnitService, EnterpriseUnitService>(Lifestyle.Scoped);
            //container.Register<IFunctionalCompetencyService, FunctionalCompetencyService>(Lifestyle.Scoped);
            //container.Register<IFunctionalOrganizationService, FunctionalOrganizationService>(Lifestyle.Scoped);
            //container.Register<IGoalSheetAppraisalIntervalsService, GoalSheetAppraisalIntervalsService>(Lifestyle.Scoped);
            //container.Register<IGoalSheetService, GoalSheetService>(Lifestyle.Scoped);
            //container.Register<IGoalSheetTargetPeriodService, GoalSheetTargetPeriodService>(Lifestyle.Scoped);
            //container.Register<IGoalSheetReportService, GoalSheetReportService>(Lifestyle.Scoped);
            //container.Register<IJobService, JobService>(Lifestyle.Scoped);
            //container.Register<ILegalEntityService, LegalEntityService>(Lifestyle.Scoped);
            //container.Register<ILogExceptionService, LogExceptionService>(Lifestyle.Scoped);
            //container.Register<INotificationService, NotificationService>(Lifestyle.Scoped);
            //container.Register<IOrgUnitService, OrgUnitService>(Lifestyle.Scoped);
            //container.Register<IPersonalProfile, PersonalProfileService>(Lifestyle.Scoped);
            //container.Register<IPersonEmploymentService, PersonEmploymentsService>(Lifestyle.Scoped);
            //container.Register<IPersonService, PersonService>(Lifestyle.Scoped);
            //container.Register<IPositionService, PositionService>(Lifestyle.Scoped);
            //container.Register<ISubdomainInterface, SubdomainService>(Lifestyle.Scoped);
            //container.Register<ITemplateService, TemplateService>(Lifestyle.Scoped);
            //container.Register<ITenantService, TenantService>(Lifestyle.Scoped);
            //container.Register<ITimeZoneService, TimeZoneService>(Lifestyle.Scoped);
            //container.Register<IUserManagementService, UserManagementService>(Lifestyle.Scoped);
            //container.Register<IUserService, UserService>(Lifestyle.Scoped);
            //container.Register<IUserSetingsService, UserSetingsService>(Lifestyle.Scoped);
            //container.Register<IWorkCenterService, WorkCenterService>(Lifestyle.Scoped);
            //container.Register<ILanguageService, LanguageService>(Lifestyle.Scoped);
            //container.Register<IFileService, FileService>(Lifestyle.Scoped);
            //container.Register<IKeySuccessFactorService, KeySuccessFactorService>(Lifestyle.Scoped);
            //container.Register<IGeneralCompetenciesModelService, GeneralCompetenciesService>(Lifestyle.Scoped);
            //container.Register<IContractTemplatesService, ContractTemplatesService>(Lifestyle.Scoped);
            //container.Register<IGeneralCompetenciesLkpService, GeneralCompetenciesLKPService>(Lifestyle.Scoped);
            //container.Register<IACAssesmentService, ACAssesmentService>(Lifestyle.Scoped);
            //container.Register<ICalendarEventsService, CalendarEventsService>(Lifestyle.Scoped);
            //container.Register<IJobSystemizationService, JobSystemizationService>(Lifestyle.Scoped);
            //container.Register<IVariablePaymentListService, VariablePaymentListService>(Lifestyle.Scoped);
            //container.Register<IVariablePaymentService, VariablePaymentService>(Lifestyle.Scoped);
            //container.Register<IVariablePaymentPerformanceService, VariablePaymentPerformanceService>(Lifestyle.Scoped);
            //container.Register<IVariablePayListDetailsService, VariablePaymentListDetaliesService>(Lifestyle.Scoped);
            //container.Register<IFinancialGoalService, FinancialGoalService>(Lifestyle.Scoped);
            //container.Register<IFAQService, FAQService>(Lifestyle.Scoped);

            return container;
        }
    }
}
