using Microsoft.Extensions.Logging;

// Instantiate LoggerFactory Object using SEQ
using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddSeq());

// Creating logger object
ILogger logger = factory.CreateLogger("Program");

// time to logging
logger.LogInformation("Hello World! Logging is {Description}.", "fun");
logger.LogInformation("Hello from SEQ");
