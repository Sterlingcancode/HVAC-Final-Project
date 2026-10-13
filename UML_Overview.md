# HVAC Inventory Management System: Architecture & UML Overview

## 1. System Architecture (MVC Breakdown)
* **Model (Data Layer):** Managed within the `HVAC_Core` project. Contains core data structures including `HVACUnit`, `SmartHVACUnit`, and properties like brand, model, tonnage, and SEER ratings.
* **Controller / Business Logic:** Handled by `InventoryManager`, which manages data state, filtering operations, and business rules (such as device diagnostics via the `IDiagnosable` interface).
* **Presentation (View / API Interface):** Handled by `HVAC_API` controllers (`HVACUnitsController`) and exposed interactively via Swagger UI, supporting both JSON and XML output formats.

## 2. Use Case Summary
* **UC-1: View All Inventory** - User requests the complete list of HVAC units via `GET /api/HVACUnits`.
* **UC-2: Filter Units by Brand** - User queries specific units using case-insensitive brand parameters via `GET /api/HVACUnits/{brand}`.
* **UC-3: Execute Diagnostics** - System invokes the `IDiagnosable` interface implementation on smart HVAC units to check operational status.
