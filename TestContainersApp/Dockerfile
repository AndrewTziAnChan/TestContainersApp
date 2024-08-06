FROM ubuntu AS linuxbase
ARG BUILD_CONFIGURATION=Release

ENV TESTCONTAINERS_HOST_OVERRIDE=host.docker.internal

RUN apt-get update \
    && apt-get install -y --no-install-recommends dotnet-sdk-8.0 \
    && rm -rf /var/lib/apt/lists/*

COPY [".", "."]
RUN dotnet restore "TestContainersApp/TestContainersApp.csproj"
RUN dotnet build "TestContainersApp/TestContainersApp.csproj"
RUN dotnet test "TestContainersAppTest/TestContainersAppTest.csproj"
RUN dotnet publish "TestContainersApp/TestContainersApp.csproj" -c $BUILD_CONFIGURATION /p:UseAppHost=false

ENTRYPOINT ["exec", "dotnet", "TestContainersApp.dll"]
