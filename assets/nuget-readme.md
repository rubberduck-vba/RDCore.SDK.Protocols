# RDCore.SDK.Protocols

The messages a client exchanges with [RDCore](https://github.com/rubberduck-vba/RDCore), a language platform for VBA built on the Language Server Protocol and the MS-VBAL specification, with no dependency on the platform itself.

**This is an alpha.** The API will change before 1.0, and a later alpha may break code built against an earlier one.

## What the package holds

The `RDCore.SDK.Protocols` assembly: the `rdcore/*` methods and their messages, the platform handshake, how to start the language server, and the files of the languages the platform serves. It depends on the .NET base library only. Its French resources (`fr`) are beside the English ones.

The [RDCore.SDK](https://www.nuget.org/packages/RDCore.SDK) package, the RDCore language model and the plumbing every process and extension of the platform shares, depends on this package.

## Getting started

```bash
dotnet add package RDCore.SDK.Protocols --prerelease
```

The package targets .NET 11 (`net11.0`).

## Documentation

- [API reference](https://rubberduck-vba.github.io/RDCore.SDK.Protocols/api/RDCore.SDK.html), generated from the xmldocs of the package's assembly.
- [RD-VBAL](https://rubberduck-vba.github.io/RDCore/specs/rd-vbal.html), the language specification RDCore implements.
- [Source and issues](https://github.com/rubberduck-vba/RDCore.SDK.Protocols).

## License

MIT. The license text is in the package and in the [repository](https://github.com/rubberduck-vba/RDCore.SDK.Protocols/blob/main/LICENSE). A French version of the license is available on request.

The RDCore platform built on this package, the RD-VBA runtime included, is licensed under the GNU GPL v3 or later, in the [RDCore](https://github.com/rubberduck-vba/RDCore) repository.

## Contributing

Contributions are open to individuals, under the [CLA](https://github.com/rubberduck-vba/RDCore.SDK.Protocols/blob/main/CLA.md). One signature covers every repository of the RDCore platform.
