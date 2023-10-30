# DevOps Web Application

## About the Project

This is a simple `.NET Core application` that implements a controller-based web API for generating random numbers. To create this application, I started by following this [tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio) from Microsoft's official documentation.

For this project, I also defined a `GitHub Actions` pipeline for continuous integration. It builds and tests the application and, finally, publishes the created package to an `Amazon S3 bucket`. This package will later be used to create a custom Windows image using [HashiCorp Packer](https://www.packer.io/).

## Getting Started

### Prerequisites
* This application is developed using `.NET Core 7`. You can find the official documentation for installing .NET Core [here](https://learn.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70).

### Usage

To start the application, you can either open the .sln file in Visual Studio or use the following commands in PowerShell or a Linux terminal:

0. Clone the repository
    ```sh
    git clone repoURL
    ```
1. Navigate to the solution directory
    ```sh
    cd RepoName/DevopsWebApp
    ```
2. Install the required dependencies
    ```sh
    dotnet restore
    ```
3. Build the solution
    ```sh
    # This is the default build path; you can change it if needed
    dotnet \bin\Debug\net7.0\DevopsWebApp.dll
    ```
#### Unit Tests
The solution also provides a Test project that runs unit tests for the defined methods. To test the project, use the following commands:

1. Navigate to the solution directory
    ```sh
    cd RepoName
    ```
2. Install the required dependencies
    ```sh
    dotnet restore
    ```
3. Run unit tests
    ```sh
    dotnet test --no-restore --verbosity normal
    ```

## Continuous Integration Pipeline

The GitHub Actions workflow automatically builds, tests, and publishes a package with the latest version of the application to an Amazon S3 Bucket when pushing or creating a pull request to the `master` branch. It can also be triggered manually if needed.

### Configure Secrets and Variables
Since the pipeline uploads the package to an S3 Bucket, you need to define the following variables and secrets for your repository:

1. Secrets
    ```js
    AWS_ACCESS_KEY_ID
    AWS_SECRET_ACCESS_KEY
    ```
2. Variables
    ```js
    AWS_BUCKET
    ```

## Web API
You can access the Web API and interact with it through [Swagger UI](https://swagger.io/) using the following URLs:

1. For development:
    ```
    http://localhost:5252/swagger/index.html
    ```
2. For release:
    ```
    http://localhost:5000/swagger/index.html
    ```
