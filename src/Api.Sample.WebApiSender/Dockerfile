FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Api.Sample.WebApiSender/Api.Sample.WebApiSender.csproj", "src/Api.Sample.WebApiSender/"]
COPY ["src/Api.Sample.Infrastructure/Api.Sample.Infrastructure.csproj", "src/Api.Sample.Infrastructure/"]
COPY ["src/Api.Sample.Domain/Api.Sample.Domain.csproj", "src/Api.Sample.Domain/"]
COPY ["src/Api.Sample.Application/Api.Sample.Application.csproj", "src/Api.Sample.Application/"]
RUN dotnet restore "src/Api.Sample.WebApiSender/Api.Sample.WebApiSender.csproj"
COPY . .
WORKDIR "/src/src/Api.Sample.WebApiSender"
RUN dotnet build "Api.Sample.WebApiSender.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Sample.WebApiSender.csproj" -c Release -o /app/publish

ENV TZ=America/Sao_Paulo
ENV LANG pt-BR
ENV LANGUAGE pt-BR
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Sample.WebApiSender.dll"]