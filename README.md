# gRPC Client-Server app

> App implementing my private grpc.heartbeats class library, using gRPC. It is used for communication between two apps, where server keeps list of clients and checks if they are alive, and clients send heartbeats to keep it's status on server.

## CLient
To implement library it needs to install packages:

- Google.Protobuf (3.26.1)
- Grpc.Core (2.46.1)
- Grpc.Net.Client (2.62.0)

## Server
To implement library it needs to install packages:

- Google.Protobuf (3.26.1)
- Grpc.Core (2.46.1)
