# CMP205 Lab 08: Programming with Databases

Starter project for Lab 08. Follow the tasks in the lab sheet on MyLearningSpace.

## What is included

- `UniversityLab.sln`: a Windows Forms App (.NET 8)
- `Models/`: the `Person`, `Student` and `Department` classes from Week 6
- `Form1`: one tab per lab task, with all the controls you need for Tasks 1 to 6.
  The buttons have no code yet: double-click a button in the designer to create its Click handler.
- NuGet packages, already referenced: `Microsoft.Data.SqlClient` and
  `Microsoft.Extensions.Configuration.UserSecrets`
- `University_Week8.sql`: creates and fills the `Department` and `Student` tables

## Getting started

1. Run `University_Week8.sql` in SSMS on your own database on the Tolmount server.
2. Open `UniversityLab.sln` in Visual Studio and build it once, so the NuGet packages are restored.
3. Store your connection string with Manage User Secrets, as described in the lab sheet.
   Never put your connection string or password in the code: this repository is on GitHub.
4. Commit and push your work at the end of each session.

## Use of generative AI

The starter code and this README were generated with Claude (Anthropic) from the module's
Week 6 class design, then reviewed and tested by the module tutor.
