# Use the official ASP.NET Core runtime image as a base image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base

# Set the working directory to /app
WORKDIR /app

# Expose port 80 for the application
EXPOSE 80

# Copy the published output of the ASP.NET Core application
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

# Set the working directory to /src
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["CleanMovie.API.csproj", ""]
RUN dotnet restore "CleanMovie.API.csproj"

# Copy the remaining source code
COPY . .

# Build the application
RUN dotnet build "CleanMovie.API.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "CleanMovie.API.csproj" -c Release -o /app/publish

# Build the final runtime image
FROM base AS final

# Set the working directory to /app
WORKDIR /app

# Copy the published output from the publish stage
COPY --from=publish /app/publish .

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "CleanMovie.API.dll"]
