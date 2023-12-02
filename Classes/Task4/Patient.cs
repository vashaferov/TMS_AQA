namespace Classes.Task4;

public class Patient
{
    public string name;
    public int age;
    public int treatmentPlan;
    public string doctor;

    public Patient(string name, int age, int treatmentPlan)
    {
        this.name = name;
        this.age = age;
        this.treatmentPlan = treatmentPlan;
    }

    public void GoToHospital(int treatmentPlan)
    {
        switch (treatmentPlan)
        {
            case 1:
            {
                doctor = "Хирург";
                
                break;
            }
            case 2:
            {
                doctor = "Дантист";
                
                break;
            }
            default:
            {
                doctor = "Терапевт";
                
                break;
            }
        }
    }
}