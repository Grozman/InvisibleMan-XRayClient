# Invisible Man - XRay Client

> A client for xray core

[![Downloads](https://img.shields.io/github/downloads/invisiblemanvpn/InvisibleMan-XRayClient/total.svg?label=downloads%20%28total%29)](https://github.com/InvisibleManVPN/InvisibleMan-XRayClient/releases)
[![DownloadsLatest](https://img.shields.io/github/downloads/InvisibleManVPN/InvisibleMan-XRayClient/latest/total?label=downloads%20%28latest%29)](https://github.com/InvisibleManVPN/InvisibleMan-XRayClient/releases/latest)
[![LatestVersion](https://img.shields.io/github/v/release/invisiblemanvpn/InvisibleMan-XRayClient?label=latest%20version)](https://github.com/InvisibleManVPN/InvisibleMan-XRayClient/releases/latest)
[![CodeFactor](https://www.codefactor.io/repository/github/invisiblemanvpn/InvisibleMan-XRayClient/badge)](https://www.codefactor.io/repository/github/invisiblemanvpn/InvisibleMan-XRayClient)

Invisible Man XRay is an open-source and free client that supports [xray core](https://github.com/XTLS/Xray-core). It provides an easy-to-use interface to configure and manage proxies and allows users to switch between different server locations.

![Image1](https://github.com/InvisibleManVPN/InvisibleMan-XRayClient/blob/master/Images/image-1.png)
![Image2](https://github.com/InvisibleManVPN/InvisibleMan-XRayClient/blob/master/Images/image-2.png)

## Getting started

- If you are new to this, please download the application from [releases](https://github.com/InvisibleManVPN/InvisibleMan-XRayClient/releases/latest).

- But if you want to get the source of the client, follow these steps:
  - Download the [requirements](#requirements)
  - Clone a copy of the repository:
    ```
    git clone "https://github.com/InvisibleManVPN/InvisibleMan-XRayClient.git"
    ```
  - Change to the directory:
    ```
    cd InvisibleMan-XRayClient
    ```
  - Make `XRayCore.dll` file and copy to the `/InvisibleMan-XRay/Libraries` directory:
    ```
    cd XRay-Wrapper
    go build --buildmode=c-shared -o XRayCore.dll -trimpath -ldflags "-s -w -buildid=" .
    md ..\InvisileMan-XRay\Libraries
    copy XRayCore.dll ..\InvisibleMan-XRay\Libraries   
    ```
    
  - Download `InvisibleMan-TUN` service (based on your OS) from [this](https://github.com/InvisibleManVPN/InvisibleMan-TUN/releases/latest) link, extract and copy to the `/InvisibleMan-XRay/TUN` directory.

  - Download `geoip.dat` and `geosite.dat` files and copy to the `/InvisibleMan-XRay` directory:
    ```
    cd ..\InvisibleMan-XRay
    curl https://github.com/v2fly/geoip/releases/latest/download/geoip.dat -o geoip.dat -L
    curl https://github.com/v2fly/domain-list-community/releases/latest/download/dlc.dat -o geosite.dat -L
    ```
  - Run the project:
    ```
    dotnet run
    ```

## Requirements

- Go https://go.dev/dl/
- .Net https://dotnet.microsoft.com/download
- Curl https://curl.se/download.html

## Contributing

You can help this project by reporting problems, suggestions or contributing to the code.

### Report a problem or suggestion

Go to our [Issue tracker](https://github.com/InvisibleManVPN/InvisibleMan-XRayClient/issues) and check if your problem/suggestion is already reported. If not, create a new issue with a descriptive title and detail your suggestion or steps to reproduce the problem.

### Add a new language

Invisible Man XRay supports multi-languages. So, you can contribute to adding new language to the app by following [this](./Language.md) instruction.

### Contribute to the code

If you know how to code, we welcome you to send fixes and new features!

## Donation


Please consider donating to support and sustain my activities.
<br/>
See: https://invisiblemanvpn.github.io/donation/

## Contacts

- Web [invisiblemanvpn.github.io](https://invisiblemanvpn.github.io)
- Email [invisiblemanvpn@gmail.com](mailto:invisiblemanvpn@gmail.com)

## Stargazers over time

[![Stargazers over time](https://starchart.cc/InvisibleManVPN/InvisibleMan-XRayClient.svg?variant=adaptive)](https://starchart.cc/InvisibleManVPN/InvisibleMan-XRayClient)