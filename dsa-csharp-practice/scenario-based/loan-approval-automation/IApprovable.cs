// Interface defining loan approval and EMI calculation methods.
interface IApprovable{
    bool ApproveLoan(Applicant applicant);
    double CalculateEMI();
}
