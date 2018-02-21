# Data conversion between Avro and C#

This folder included inside the CommonMessages project of the **csharp-test-bed-adapter** ensures proper conversion from Avro schemas to C# classes. It uses the `avrogen.exe` that is built from the [Apache Avro GitHub](https://github.com/apache/avro).

## Original Avro schema

The Avro schemas are located inside the `avro-schemas` folder. A test schema is located inside the folder. This is an Avro schema for a [Common Alerting Protocol](https://en.wikipedia.org/wiki/Common_Alerting_Protocol) (CAP) message, generated inside the [DRIVER-EU avro-schemas project](https://github.com/DRIVER-EU/avro-schemas).

## Conversion

Conversion from Avro schema to C# class file is located in the `avro-to-cs` folder and contains the following files:

* The compiled `avrogen.exe` ([source](https://github.com/apache/avro/tree/master/lang/csharp/src/apache/codegen)) and its required DLLs
* The Windows batch file `convert.bat` that calls the `avrogen.exe` with the correct parameters for converting the CAP Avro schema to corresponding C# class files.