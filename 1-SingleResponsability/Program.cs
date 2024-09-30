using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelperCsv = new();
exportHelperCsv.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");