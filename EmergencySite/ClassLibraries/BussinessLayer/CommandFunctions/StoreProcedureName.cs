namespace EmergencySite.ClassLibraries.BusinessLayer.CommanFunctions
{
    public static class StoreProcedureName
    {
        #region Comman Store Procedure

        public const string SpInsertUpdateTrash = "spInsertUpdateTrash";
        public const string SpCheckExistance = "spCheckExistance";
        public const string SpCheckExistanceWithWhere = "spCheckExistanceWithWhere";
        public const string SpReturnTableData = "spReturnTableData";
        public const string SpCheckExistanceByWhere = "spCheckExistanceByWhere";

        public const string SpCheckUser = "spCheckUser";
        public const string SpChangePassword = "spChangePassword";
        public const string SpUserApplicationMenuRights = "spUserApplicationMenuRights";
        public const string SpApplicationWithUserRight = "spApplicationWithUserRight";
        public const string SpUserApplicationRight = "spUserApplicationRight";
        public const string SpInsertUpdateUserInApplication = "spInsertUpdateUserInApplication";
        public const string SpUserApplicationMenuAccess = "spUserApplicationMenuAccess";
        public const string SpInsertUpdateUserApplicationMenuAccess = "spInsertUpdateUserApplicationMenuAccess";
        public const string SpSelectPrivilege = "spSelectPrivilege";

        public const string SpSelectUserCompanyCircleAccess = "spSelectUserCompanyCircleAccess";

        public const string SpUpdateAuth = "spUpdateAuth";

        public const string SpSelectApplication = "spSelectApplication";
        public const string SpInsertUpdateApplication = "spInsertUpdateApplication";

        public const string SpSelectDepartment = "spSelectDepartment";
        public const string SpInsertUpdateDepartment = "spInsertUpdateDepartment";

        public const string SpSelectQualification = "spSelectQualification";
        public const string SpInsertUpdateQualification = "spInsertUpdateQualification";

        public const string SpSelectDesignation = "spSelectDesignation";
        public const string SpInsertUpdateDesignation = "spInsertUpdateDesignation";

        public const string SpSelectProject = "spSelectProject";
        public const string SpInsertUpdateProject = "spInsertUpdateProject";

        public const string SpSelectUserCategory = "spSelectUserCategory";
        public const string SpInsertUpdateUserCategory = "spInsertUpdateUserCategory";

        public const string SpSelectUser = "spSelectUser";
        public const string SpSelectLevel = "spSelectLevel";
        //public const string SpInsertUpdateUser = "spInsertUpdateUser";
        public const string SpSelectUserByLoginRid = "spSelectUserByLoginRid";
        public const string SpSelectUserForExport = "spSelectUserForExport";

        public const string SpSelectUserCustomer = "spSelectUserCustomer";
        public const string SpInsertUpdateUserCustomer = "spInsertUpdateUserCustomer";
        public const string SpInsertUpdateUserCompanyCircleAccess = "spInsertUpdateUserCompanyCircleAccess";

        public const string SpSelectMenu = "spSelectMenu";
        public const string SpSelectSubMenu = "spSelectSubMenu";
        public const string SpSelectApplicationMenu = "spSelectApplicationMenu";
        public const string SpInsertUpdateApplicationMenuAccess = "spInsertUpdateApplicationMenuAccess";

        public const string SpInsertUpdateAgreement = "spInsertUpdateAgreement";
        public const string SpSelectAgreement = "spSelectAgreement";
        public const string SpSelectAgreementById = "spSelectAgreementById";

        public const string SpSelectPODetails = "spSelectPODetails";
        public const string SpSelectPODetailsAttachments = "spSelectPODetailsAttachments";
        public const string SpInsertUpdatePoType = "spInsertUpdatePoType";
        public const string SpValidatePODetailsMaterials = "spValidatePODetailsMaterials";
        public const string SpUploadPODetailsMaterials = "spUploadPODetailsMaterials";
        public const string SpInsertUpdatePODetailsAttachments = "spInsertUpdatePODetailsAttachments";

        public const string SpSelectBusinessApplication = "spSelectBusinessApplication";
        public const string SpInsertUpdateBusinessApplication = "spInsertUpdateBusinessApplication";

        public const string SpSelectMaterialCategory = "spSelectMaterialCategory";
        public const string SpInsertUpdateMaterialCategory = "spInsertUpdateMaterialCategory";

        public const string SpSelectMaterial = "spSelectMaterial";
        public const string SpSelectMaterialBill = "spSelectMaterialBill";
        public const string SpSelectMaterialBillDetails = "spSelectMaterialBillDetails";
        public const string SpSelectMaterialById = "spSelectMaterialById";
        public const string SpSelectMaterialName = "SpSelectMaterialName";
        public const string SpSelectMaterialNameForServiceList = "spSelectMaterialNameForServiceList";
        public const string SpInsertUpdateMaterial = "spInsertUpdateMaterial";
        public const string SpInsertUpdateMaterialUsedRequiredInPIU = "spInsertUpdateMaterialUsedRequiredInPIU";
        public const string SpInsertUpdateMaterialInvoiceQuantityInPIU = "spInsertUpdateMaterialInvoiceQuantityInPIU";
        public const string SpUpdateMaterialUsedAmount = "spUpdateMaterialUsedAmount";

        public const string SpInsertUpdateMaterialUsedInSiteDetails = "spInsertUpdateMaterialUsedInSiteDetails";
        public const string SpSelectMaterialForServiceList = "spSelectMaterialForServiceList";
        public const string SpSelectMaterialHSNCodeForServiceList = "spSelectMaterialHSNCodeForServiceList";
        public const string SpSelectMaterialHSNCode = "spSelectMaterialHSNCode";
        public const string SpSelectMaterialForServiceListFromStock = "spSelectMaterialForServiceListFromStock";
        public const string SpSelectMaterialForServiceListForCalalogue = "spSelectMaterialForServiceListForCalalogue";
        public const string SpSelectMaterialUsedRequiredInPIU = "spSelectMaterialUsedRequiredInPIU";
        public const string SpSelectMaterialUsedInSiteDetails = "spSelectMaterialUsedInSiteDetails";
        public const string SpInsertUpdateMaterialName = "spInsertUpdateMaterialName";
        public const string SpSelectMaterialCheckList = "spSelectMaterialCheckList";
        public const string SpSelectMaterialCheckListPiuRepairedDetails = "spSelectMaterialCheckListPiuRepairedDetails";

        public const string SpSelectMaterialCheckListPODetails = "spSelectMaterialCheckListPODetails";

        public const string SpSelectVendor = "spSelectVendor";
        public const string SpInsertUpdateVendor = "spInsertUpdateVendor";
        public const string SpSelectVendorByVendorId = "spSelectVendorByVendorId";

        public const string SpSelectBillCategory = "spSelectBillCategory";
        public const string SpInsertUpdateBillCategory = "spInsertUpdateBillCategory";

        public const string SpSelectMaterialCatalogue = "spSelectMaterialCatalogue";
        public const string SpInsertUpdateMaterialCatalogue = "spInsertUpdateMaterialCatalogue";
        public const string SpSelectMaterialCatalogueByMaterialCatalogueId = "spSelectMaterialCatalogueByMaterialCatalogueId";

        public const string SpSelectMaterialCatalogueDetails = "spSelectMaterialCatalogueDetails";
        public const string SpInsertUpdateMaterialCatalogueDetails = "spInsertUpdateMaterialCatalogueDetails";

        public const string SpSelectMaterialCatalogueDetailsByCatalogueId = "spSelectMaterialCatalogueDetailsByCatalogueId";

        //public const string SpInsertUpdateMaterialBill = "spInsertUpdateMaterialBill";
        public const string SpInsertUpdateMaterialDetails = "spInsertUpdateMaterialDetails";

        public const string SpSelectMaterialRequestPODetails = "spSelectMaterialRequestPODetails";

        public const string SpSelectMaterialRequest = "spSelectMaterialRequest";
        public const string SpInsertUpdateMaterialRequest = "spInsertUpdateMaterialRequest";
        public const string SpSelectUsedReturnAndInStockMaterial = "spSelectUsedReturnAndInStockMaterial";
        public const string SpSelectMaterialRequestStatus = "spSelectMaterialRequestStatus";

        public const string SpSelectMaterialRequestL2 = "spSelectMaterialRequestL2";
        public const string SpSelectMaterialRequestL2Details = "spSelectMaterialRequestL2Details";

        public const string SpSelectPendingMaterialDetails = "spSelectPendingMaterialDetails";
        public const string SpSelectPendingMaterialDetailsSiteDetails = "spSelectPendingMaterialDetailsSiteDetails";
        public const string SpSelectApprovedMaterialDetails = "spSelectApprovedMaterialDetails";
        public const string SpSelectApprovedMaterialDetailsWithoutSerial = "SpSelectApprovedMaterialDetailsWithoutSerial";
        public const string SpSelectApprovedMaterialRackNo = "spSelectApprovedMaterialRackNo";
        public const string SpSelectMaterialStockById = "spSelectMaterialStockById";

        public const string SpSelectMaterialApproved = "spSelectMaterialApproved";
        public const string SpInsertUpdateMaterialApproved = "spInsertUpdateMaterialApproved";

        public const string SpSelectPendingChallan = "spSelectPendingChallan";
        public const string SpSelectPendingChallanById = "spSelectPendingChallanById";
        public const string SpSelectMaterialForChallan = "spSelectMaterialForChallan";
        public const string SpSelectGeneratedChallan = "spSelectGeneratedChallan";
        public const string SpSelectMaterialChallanTax = "spSelectMaterialChallanTax";
        public const string SpSelectAnnexureChallanById = "spSelectAnnexureChallanById";        
        public const string SpSelectMaterialReturnChallan = "spSelectMaterialReturnChallan";
        public const string SpSelectMaterialReturnDetails = "spSelectMaterialReturnDetails";

        public const string SpSelectRequestDetails = "spSelectRequestDetails";
        public const string SpInsertUpdateMaterialIssue = "spInsertUpdateMaterialIssue";

        public const string SpCheckPreviousRequest = "spCheckPreviousRequest";

        public const string SpInsertUpdateMaterialReturn = "spInsertUpdateMaterialReturn";
        public const string SpInsertUpdateMaterialStoreIssue = "spInsertUpdateMaterialStoreIssue";
        public const string SpSelectMaterialChallanStore = "spSelectMaterialChallanStore";

        public const string SpInsertUpdateMaterialHandOver = "SpInsertUpdateMaterialHandOver";
        public const string SpInsertUpdateMaterialIssueWarehouse = "SpInsertUpdateMaterialIssueWarehouse";

        public const string SpInsertUpdatePiuRepairedDetails = "spInsertUpdatePiuRepairedDetails";
        public const string SpUpdateActualParameter = "spUpdateActualParameter";

        public const string SpInsertUpdatePiuRepairedDetailsAttachment = "spInsertUpdatePiuRepairedDetailsAttachment";
        public const string SpInsertUpdateValidation = "spInsertUpdateValidation";

        public const string SpSelectPiuRepairedDetails = "spSelectPiuRepairedDetails";
        public const string SpSelectPiuRepairedDetailsAttachment = "spSelectPiuRepairedDetailsAttachment";

        public const string SpSelectReportPiuRepairedDetails = "spSelectReportPiuRepairedDetails";
        public const string SpSelectValidation = "spSelectValidation";

        public const string SpSelectReportPiuRepairedDetailsBeginDate = "spSelectReportPiuRepairedDetailsBeginDate";
        public const string SpSelectReportPiuRepairedDetailsDistinct = "spSelectReportPiuRepairedDetailsDistinct";

        public const string SpSelectZone = "spSelectZone";
        public const string SpInsertUpdateZone = "spInsertUpdateZone";

        public const string SpSelectCircle = "spSelectCircle";
        public const string SpInsertUpdateCircle = "spInsertUpdateCircle";
        public const string SpSelectCircleForServiceList = "spSelectCircleForServiceList";

        public const string SpSelectStateForServiceList = "spSelectStateForServiceList";

        public const string SpSelectCluster = "spSelectCluster";
        public const string SpInsertUpdateCluster = "spInsertUpdateCluster";
        public const string SpSelectClusterForServiceList = "spSelectClusterForServiceList";

        public const string SpSelectDistrict = "spSelectDistrict";
        public const string SpInsertUpdateDistrict = "spInsertUpdateDistrict";
        //public const string SpSelectDistrictForServiceList = "spSelectDistrictForServiceList";

        public const string SpSelectSite = "spSelectSite";
        public const string SpInsertUpdateSite = "spInsertUpdateSite";
        public const string SpUploadSite = "spUploadSite";
        public const string SpSelectSiteBySiteId = "spSelectSiteBySiteId";
        public const string SpValidateSiteDetails = "spValidateSiteDetails";
        public const string SpSelectSiteForServiceList = "spSelectSiteForServiceList";
        public const string SpSelectSiteForServiceListPiuRepairedDetails = "spSelectSiteForServiceListPiuRepairedDetails";
        public const string SpSelectSiteForListBox = "spSelectSiteForListBox";
        public const string SpSelectMaterialRequestSite = "spSelectMaterialRequestSite";

        public const string SpValidateSiteMaster = "spValidateSiteMaster";
        public const string SpUploadSiteMaster = "spUploadSiteMaster";

        public const string SpSelectCompany = "spSelectCompany";
        public const string SpInsertUpdateCompany = "spInsertUpdateCompany";
        public const string SpSelectCompanyByCompanyId = "spSelectCompanyByCompanyId";
        public const string SpSelectCompanyForServiceList = "SpSelectCompanyForServiceList";
        public const string SpSelectMaterialChallanAddress = "spSelectMaterialChallanAddress";
        public const string SpInsertUpdateMaterialChallanAddress = "spInsertUpdateMaterialChallanAddress";

        public const string SpSelectSubCompany = "spSelectSubCompany";/// <summary>
                                                                      /// ////////////
                                                                      /// </summary>
        public const string SpInsertUpdateSubCompany = "spInsertUpdateSubCompany";
        public const string SpSelectSubCompanyForServiceList = "spSelectSubCompanyForServiceList";

        public const string SpGenerateChallan = "spGenerateChallan";

        public const string SpSelectReportStock = "spSelectReportStock";
        public const string SpSelectReportPurchageDetails = "spSelectReportPurchageDetails";
        public const string SpSelectStockForSerialNumber = "spSelectStockForSerialNumber";
        public const string SpSelectPurchageDetailsForSerialNumber = "spSelectPurchageDetailsForSerialNumber";
        public const string SpSelectMaterialDetails = "spSelectMaterialDetails";

        public const string SpSelectReportIssueMaterialEmployeeWise = "spSelectReportIssueMaterialEmployeeWise";
        public const string SpSelectReportIssueMaterialMaterialWise = "spSelectReportIssueMaterialMaterialWise";

        public const string SpSelectPriceList = "spSelectPriceList";
        public const string SpInsertUpdatePriceList = "spInsertUpdatePriceList";

        public const string SpSelectRCService = "spSelectRCService";
        public const string SpInsertUpdateRCService = "spInsertUpdateRCService";

        //public const string SpSelectPriceListByMaterialId = "spSelectPriceListByMaterialId";
        public const string SpSelectPriceListByMaterialRequestPOId = "spSelectPriceListByMaterialRequestPOId";
        public const string SpSelectPriceListByIdInType = "spSelectPriceListByIdInType";
        public const string SpSelectPriceUsedMaterial = "spSelectPriceUsedMaterial";
        public const string SpSelectPriceRequiredMaterial = "spSelectPriceRequiredMaterial";
        public const string SpSelectPriceListByTableType = "spSelectPriceListByTableType";
        public const string SpSelectPriceListByTableTypePODetails = "spSelectPriceListByTableTypePODetails";

        public const string SpSelectAgreementPrice = "spSelectAgreementPrice";

        public const string SpSelectInvoice = "spSelectInvoice";
        public const string SpSelectInvoiceAttachments = "spSelectInvoiceAttachments";
        public const string SpSelectInvoiceSupportingSheet = "spSelectInvoiceSupportingSheet";
        public const string SpSelectInvoiceSupportingSheetList = "spSelectInvoiceSupportingSheetList";
        public const string SpSelectInvoiceVisits = "spSelectInvoiceVisits";
        public const string SpSelectInvoiceSupportingSheetStage = "spSelectInvoiceSupportingSheetStage";
        public const string SpSelectSitesForInvoice = "spSelectSitesForInvoice";
        public const string SpSelectInvoiceSupportingSheetDetails = "spSelectInvoiceSupportingSheetDetails";
        public const string SpSelectSiteListByPO = "spSelectSiteListByPO";
        public const string SpSelectSiteListForPO = "spSelectSiteListForPO";

        public const string SpInsertUpdateInvoice = "spInsertUpdateInvoice";
        public const string SpInsertUpdateInvoiceDispatchDelete = "spInsertUpdateInvoiceDispatchDelete";
        public const string SpInsertUpdateInvoiceAttachment = "spInsertUpdateInvoiceAttachment";
        public const string SpInsertUpdateInvoiceSummarySigned = "spInsertUpdateInvoiceSummarySigned";
        public const string SpUpdateInvoiceFollowUpMailCount = "spUpdateInvoiceFollowUpMailCount";

        public const string SpSelectRequisitionForPO = "spSelectRequisitionForPO";
        public const string SpSelectPORequest = "spSelectPORequest";
        public const string SpSelectApprovedPOMaterialDetails = "spSelectApprovedPOMaterialDetails";
        public const string SpSelectPendingPODetails = "spSelectPendingPODetails";        
        public const string SpInsertUpdatePOMaterialApproved = "spInsertUpdatePOMaterialApproved";

        public const string SpSelectPendingRequestAlert = "spSelectPendingRequestAlert";

        public const string SpSelectAutoGeneratedNumber = "spSelectAutoGeneratedNumber";

        public const string SpSelectLogin = "spSelectLogin";

        public const string SpInsertUpdateMaterialPurchage = "spInsertUpdateMaterialPurchage";

        public const string SpSelectReportMaterialPurchage = "spSelectReportMaterialPurchage";
        public const string SpSelectReportMaterialReturn = "SpSelectReportMaterialReturn";
        public const string SpSelectReportMaterialIssue = "spSelectReportMaterialIssue";
        public const string SpSelectReportMaterialStoreIssue = "spSelectReportMaterialStoreIssue";
        public const string SpValidateMaterialRequest = "spValidateMaterialRequest";

        public const string SpSelectSiteAllot = "spSelectSiteAllot";
        public const string SpSelectSiteAllottedPendingQuantity = "spSelectSiteAllottedPendingQuantity";
        public const string SpInsertUpdateSiteAllotted = "spInsertUpdateSiteAllotted";
        public const string SpInsertUpdateSiteHold = "spInsertUpdateSiteHold";
        public const string SpSelectSiteAllotByEmployeeId = "spSelectSiteAllotByEmployeeId";
        public const string SpSelectPIUSiteHoldDetails = "spSelectPIUSiteHoldDetails";

        public const string SpSelectSiteDetailsForComplaint = "spSelectSiteDetailsForComplaint";
        public const string SpSelectMaterialConsumedPIU = "spSelectMaterialConsumedPIU";
        public const string SpSelectPIUProblemDiagnosis = "spSelectPIUProblemDiagnosis";

        public const string SpSelectMaterialSerialNoIssueConsume = "spSelectMaterialSerialNoIssueConsume";

        public const string SpValidateSite = "spValidateSite";
        public const string SpSelectPIUComplaint = "spSelectPIUComplaint";
        public const string SpSelectPIUComplaintByQuotationId = "spSelectPIUComplaintByQuotationId";
        public const string SpSelectPIUComplaintMaterial = "spSelectPIUComplaintMaterial";
        public const string SpSelectPIUComplaintMaterialForQuotation = "spSelectPIUComplaintMaterialForQuotation";
        public const string SpInsertUpdatePIUComplaintMaterial = "spInsertUpdatePIUComplaintMaterial";
        public const string SpSelectReportPIUComplaint = "spSelectReportPIUComplaint";
        public const string SpSelectReportPIUComplaintByDate = "spSelectReportPIUComplaintByDate";
        public const string SpInsertUpdatePIUComplaint = "spInsertUpdatePIUComplaint";
        public const string SpInsertUpdateQuotation = "spInsertUpdateQuotation";
        public const string SpSelectPIUComplaintById = "spSelectPIUComplaintById";
        public const string SpInsertUpdatePIUComplaintHandling = "spInsertUpdatePIUComplaintHandling";
        public const string SpSelectQuotation = "spSelectQuotation";

        public const string SpSelectReportMaterialChallan = "spSelectReportMaterialChallan";
        public const string SpSelectReportMaterialChallanDetails = "spSelectReportMaterialChallanDetails";
        public const string SpSelectReportMaterialChallanMaterial = "spSelectReportMaterialChallanMaterial";

        public const string SpSelectMaterialChallanForInvoice = "spSelectMaterialChallanForInvoice";
        public const string SpSelectInvoiceDetails = "spSelectInvoiceDetails";

        public const string SpSelectDispatchedStock = "spSelectDispatchedStock";
        public const string SpSelectMaterialAccount = "spSelectMaterialAccount";
        public const string SpSelectMaterialAccountEmployee = "spSelectMaterialAccountEmployee";
        public const string SpSelectMaterialAccountEmployeeDetails = "spSelectMaterialAccountEmployeeDetails";

        public const string SpSelectReportCoordination = "spSelectReportCoordination";
        public const string SpSelectReportCoordinationJobScheduler = "spSelectReportCoordinationJobScheduler";

        public const string SpSelectExpense = "spSelectExpense";
        public const string SpInsertUpdateExpense = "spInsertUpdateExpense";
        public const string SpValidateUploadExpense = "spValidateUploadExpense";
        public const string SpInsertUpdateExpenseAttachment = "spInsertUpdateExpenseAttachment";

        public const string SpInsertUpdateAttendance = "spInsertUpdateAttendance";
        public const string SpUploadAttendance = "spUploadAttendance";
        public const string SpSelectAttendance = "spSelectAttendance";

        public const string SpSelectFetchData = "spSelectFetchData";
        public const string SpSelectInvoiceSummary = "spSelectInvoiceSummary";

        public const string SpInsertUpdateMailBox = "spInsertUpdateMailBox";
        public const string SpSelectMailBox = "spSelectMailBox";
        public const string SpInsertUpdateCronPlan = "spInsertUpdateCronPlan";
        public const string SpSelectCronPlan = "spSelectCronPlan";

        public const string SpSelectService = "spSelectService";
        public const string SpInsertUpdateService = "spInsertUpdateService";

        public const string SpSelectServiceSACCode = "spSelectServiceSACCode";

        public const string SpSelectServiceConsumed = "spSelectServiceConsumed";
        public const string SpInsertUpdateServiceConsumed = "spInsertUpdateServiceConsumed";

        public const string SpInsertUpdateSitePO = "spInsertUpdateSitePO";

        public const string SpSelectReportFSRVerification = "spSelectReportFSRVerification";
        public const string SpSelectReportInvoiceSummary = "spSelectReportInvoiceSummary";

        public const string SpCheckConcurrency = "spCheckConcurrency";

        public const string SpInsertUpdateLoginSession = "spInsertUpdateLoginSession";
        public const string SpSelectLoginSession = "spSelectLoginSession";

        public const string SpSelectLocation = "spSelectLocation";
        public const string SpSelectSelfCompany = "spSelectSelfCompany";

        public const string SpSelectVendorService = "spSelectVendorService";
        public const string SpSelectVendorAgreement = "spSelectVendorAgreement";
        public const string SpInsertUpdateVendorAgreement = "spInsertUpdateVendorAgreement";
        public const string SpSelectVendorPriceList = "spSelectVendorPriceList";
        public const string SpSelectVendorActualParameter = "spSelectVendorActualParameter";
        public const string SpInsertUpdateVendorPriceList = "spInsertUpdateVendorPriceList";
        public const string SpSelectReportVendorSites = "spSelectReportVendorSites";
        public const string SpInsertUpdateVendorInvoice = "spInsertUpdateVendorInvoice";
        public const string SpSelectVendorInvoiceSummary = "spSelectVendorInvoiceSummary";
        public const string SpInsertUpdateVendorAmount = "spInsertUpdateVendorAmount";
        public const string SpSelectSiteAmounts = "spSelectSiteAmounts";
        public const string SpSelectVendorSiteAmounts = "spSelectVendorSiteAmounts";
        public const string SpAddUpdateSiteAmounts = "spAddUpdateSiteAmounts";
        public const string SpSelectInvoiceSites = "spSelectInvoiceSites";
        public const string SpSelectSiteMaterial = "spSelectSiteMaterial";

        public const string SpSelectTransaction = "spSelectTransaction";
        public const string SpSelectVendorStatement = "spSelectVendorStatement";
        public const string SpSelectWallet = "spSelectWallet";
        public const string SpInsertTransaction = "spInsertTransaction";

        public const string SpSelectDownload = "spSelectDownload";
        public const string SpInsertUpdateDownload = "spInsertUpdateDownload";

        #endregion

        #region API Stored Procedure

        public const string SpApiValidateUser = "spApiValidateUser";
        public const string SpApiSelectSiteAllotByEmployeeId = "spApiSelectSiteAllotByEmployeeId";
        public const string SpApiSelectMaterialRequestSiteBySiteId = "spApiSelectMaterialRequestSiteBySiteId";
        public const string SpApiSelectMaterialRequestSiteByInTypeId = "spApiSelectMaterialRequestSiteByInTypeId";
        public const string SpApiSelectMaterial = "spApiSelectMaterial";
        public const string SpApiInsertUpdatePiuRepairedDetails = "spApiInsertUpdatePiuRepairedDetails";
        public const string SpApiSelectReportPiuRepairedDetails = "spApiSelectReportPiuRepairedDetails";
        public const string SpApiInsertUpdatePiuRepairedDetailsAttachment = "spApiInsertUpdatePiuRepairedDetailsAttachment";
        public const string SpHybridInsertUpdateException = "spHybridInsertUpdateException";
        public const string SpApiSelectMaterialAccountEmployee = "spApiSelectMaterialAccountEmployee";
        public const string SpApiSelectExpense = "spApiSelectExpense";
        public const string SpApiInsertUpdateMaterialRequestSingleSite = "spApiInsertUpdateMaterialRequestSingleSite";
        public const string SpApiSelectRequestMaterialSites = "spApiSelectRequestMaterialSites";
        public const string SpApiSelectMaterialChallanAddress = "spApiSelectMaterialChallanAddress";
        public const string SpApiInsertUpdateAttendance = "spApiInsertUpdateAttendance";
        public const string SpApiSelectAttendance = "spApiSelectAttendance";
        public const string SpApiSelectSiteAllotByCurrentDate = "spApiSelectSiteAllotByCurrentDate";
        public const string SpApiSetLocation = "spApiSetLocation";
        public const string SpApiInsertUpdateSelectLeaveRequest = "spApiInsertUpdateSelectLeaveRequest";

        #endregion
    }
}
