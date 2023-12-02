using System.Globalization;

namespace Classes.Task4;

public class Doctors
{
    public string surgeon = "Хирург";
    public string dentist = "Дантист";
    public string therapist = "Терапевт";

    public int Heal(string doctor)
    {
        if (doctor == surgeon)
        {
            Console.WriteLine("Хирург обследовал пациента и назначил ему операцию. Операция прошла успешно. Код лечения изменен на \"0\"");
            return 0;
        } else if (doctor == dentist)
        {
            Console.WriteLine("Дантист обследовал пациента и удалил ему зуб мудрости. Код лечения изменен на \"0\"");
            return 0;
        }
        else
        {
            Console.WriteLine("Терапевт обследовал пациента и назначил ему нужные лекарства. Код лечения изменен на \"0\"");
            return 0;
        }
    }
}