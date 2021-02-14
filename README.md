# MovieWeb

Browse movies catalog

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them

#### Windows Environment

1. Install latest .NET 5 SDK
(https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-windows-x64-installer)

2. Visual Studio 2019
(https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=16)

##### Select components to install

<img src="https://user-images.githubusercontent.com/5947398/98497156-34ae6480-227e-11eb-9007-6c769ae658f5.png" width="600" />

```
Build and Run using Visual Studio 2019

-> Clone repository using VS, build and run application

```
#### Open Visual Studio and Clone Repository

<img src="https://user-images.githubusercontent.com/5947398/98497613-71c72680-227f-11eb-968a-d3bed8c2c1d8.png" width="600" />

<img src="https://user-images.githubusercontent.com/5947398/98497626-7c81bb80-227f-11eb-9b78-ba53fec3bd60.png" width="600" />

#### Wait for clone completion..

#### Once clone completes, visual studio should display the project structure

<img src="https://user-images.githubusercontent.com/5947398/98497975-9079ed00-2280-11eb-9441-504723bba262.png" width="600" />

#### Now, build the solution

<img src="https://user-images.githubusercontent.com/5947398/98498169-10a05280-2281-11eb-8950-3426160c6182.png" width="600" />

##### Verify build succeeded

<img src="https://user-images.githubusercontent.com/5947398/98498238-33cb0200-2281-11eb-8461-6a7a64797085.png" width="600" />


## Project Structure

| Backend Project Folder      | Type          | Sequence  | Details                                                                                                                  |
|-----------------------------|---------------|-----------|--------------------------------------------------------------------------------------------------------------------------|
| NumberGenerator.Api         | Main          | 1st layer | contains api controllers, application configuration (connectionstring, logging path, swagger, register DI container etc) |
| NumberGenerator.Application | Class Library | 2nd layer | contains application business logic                                                                                      |
| NumberGenerator.Data        | Class Library | 3rd layer | provides access to data access layer classes                                                                             |
| NumberGenerator.Core        | Class Library | common    | provides common utilities and shared infrastructure codes                                                                |
| NumberGenerator.Domain      | Class Library | common    | contains domain models                                                                                                   |                                                                          



## Built With

* [.NET 5](https://dotnet.microsoft.com/download) - Microsoft Technology
* [C#] - Programming language used
