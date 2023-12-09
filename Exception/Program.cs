using Exceptions;

ExcUsage excUsage = new ExcUsage();
//excUsage.Template();
excUsage.ManyCatch();
excUsage.FilterCatch(0, 1);

ThrowExceptions throwExceptions = new ThrowExceptions();
throwExceptions.CheckUsername();

CustomExceptionUsage customExceptionUsage = new CustomExceptionUsage();
//customExceptionUsage.Run();
//customExceptionUsage.ProcessInput("  ");
customExceptionUsage.UseCustomArgumentException();