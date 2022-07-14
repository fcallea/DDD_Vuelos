FROM mcr.microsoft.com/mssql/server:2019-latest

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=mssql1Ipw
ENV MSSQL_PID=Express
ENV MSSQL_TCP_PORT=1433

WORKDIR /src
COPY Create_database.sql ./Create_database.sql

RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" &&  /opt/mssql-tools/bin/sqlcmd -S127.0.0.1 -Usa -Pmssql1Ipw -i Create_database.sql