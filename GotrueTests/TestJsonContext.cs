using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GotrueTests;

[JsonSerializable(typeof(List<string>))]
public partial class TestJsonContext : JsonSerializerContext { }
