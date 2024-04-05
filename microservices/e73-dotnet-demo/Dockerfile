# Start with the official .NET 7 SDK image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Set the working directory to /app
WORKDIR /app

# Copy the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code and build the app
COPY . ./
RUN dotnet publish -c Release -o out

# Start with a minimal runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine

# Set the working directory to /app
WORKDIR /app

# Copy the output from the build environment to the runtime image
COPY --from=build-env /app/out .

# Expose the port number that the app listens on
ENV ASPNETCORE_URLS=http://*:8081
EXPOSE 8081

# Start the app when the container starts
ENTRYPOINT ["dotnet", "e73-dotnet-demo.dll"]
