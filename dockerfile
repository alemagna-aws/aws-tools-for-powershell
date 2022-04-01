FROM public.ecr.aws/amazonlinux/amazonlinux:latest

RUN yum install -y curl libunwind libicu libcurl openssl libuuid.x86_64 wget tar gzip
RUN wget https://raw.githubusercontent.com/PowerShell/PowerShell/master/docker/InstallTarballPackage.sh

RUN chmod +x InstallTarballPackage.sh
RUN ./InstallTarballPackage.sh 7.2.2 powershell-7.2.2-linux-x64.tar.gz
SHELL ["pwsh", "-Command"]

# Install from local source
RUN Install-Module -Name AWSPowerShell.NetCore -Force

# RUN Import-Module -Name AWSPowerShell.NetCore
WORKDIR /root
ENTRYPOINT [ "pwsh" ]