# Functional Requirements

The following requirements have been identified for successful completion of the project.

| ID | Requirement | Notes | Priority |
| :--- | :--- | :--- | :---: |
| **1.1** | The system will provide an API endpoint to retrieve the complete inventory list of registered HVAC units. | Implemented via `GET /api/HVACUnits` in the `HVACUnitsController`. | 1 |
| **1.2** | The system will provide search and filter functionality to query HVAC units by brand name. | Case-insensitive matching implemented in `InventoryManager` via `GET /api/HVACUnits/{brand}`. | 1 |
| **1.3** | The system will maintain core HVAC unit data attributes including Brand, Model Number, System Type, Tonnage, and SEER Rating. | Includes calculated properties such as BTU capacity (`Tonnage * 12000`). | 1 |
| **1.4** | The system will support a specialized `SmartHVACUnit` class that inherits from `HVACUnit` with Wi-Fi connectivity tracking. | Includes parameterless constructors to ensure seamless XML serialization compatibility. | 2 |
| **1.5** | The system will implement an `IDiagnosable` interface to execute hardware and network system diagnostics. | Integrated directly into `SmartHVACUnit` to return real-time operational status messages. | 2 |
| **1.6** | The system will manage data persistence and inventory state using an `InventoryManager` service. | Registered as a Singleton service via ASP.NET Core dependency injection in `Program.cs`. | 1 |
| **1.7** | The system will support both JSON and XML serialization formats for all API responses. | Configured using `.AddJsonOptions()` with indented formatting and `.AddXmlSerializerFormatters()`. | 1 |
