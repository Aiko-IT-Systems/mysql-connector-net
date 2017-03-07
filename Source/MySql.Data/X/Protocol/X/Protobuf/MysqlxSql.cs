// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: mysqlx_sql.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mysqlx.Sql {

  /// <summary>Holder for reflection information generated from mysqlx_sql.proto</summary>
  internal static partial class MysqlxSqlReflection {

    #region Descriptor
    /// <summary>File descriptor for mysqlx_sql.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MysqlxSqlReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBteXNxbHhfc3FsLnByb3RvEgpNeXNxbHguU3FsGhZteXNxbHhfZGF0YXR5",
            "cGVzLnByb3RvIm0KC1N0bXRFeGVjdXRlEhEKCW5hbWVzcGFjZRgDIAEoCRIM",
            "CgRzdG10GAEgASgMEiMKBGFyZ3MYAiADKAsyFS5NeXNxbHguRGF0YXR5cGVz",
            "LkFueRIYChBjb21wYWN0X21ldGFkYXRhGAQgASgIIg8KDVN0bXRFeGVjdXRl",
            "T2tCHgocY29tLm15c3FsLmNqLm15c3FseC5wcm90b2J1ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mysqlx.Datatypes.MysqlxDatatypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Sql.StmtExecute), global::Mysqlx.Sql.StmtExecute.Parser, new[]{ "Namespace", "Stmt", "Args", "CompactMetadata" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Sql.StmtExecuteOk), global::Mysqlx.Sql.StmtExecuteOk.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  execute a statement in the given namespace
  ///
  ///  .. uml::
  ///
  ///    client -> server: StmtExecute
  ///    ... zero or more Resultsets ...
  ///    server --> client: StmtExecuteOk
  ///
  ///  Notices:
  ///    This message may generate a notice containing WARNINGs generated by its execution.
  ///    This message may generate a notice containing INFO messages generated by its execution.
  ///
  ///  :param namespace: namespace of the statement to be executed
  ///  :param stmt: statement that shall be executed.
  ///  :param args: values for wildcard replacements
  ///  :param compact_metadata: send only type information for :protobuf:msg:`Mysqlx.Resultset::ColumnMetadata`, skipping names and others
  ///  :returns:
  ///     * zero or one :protobuf:msg:`Mysqlx.Resultset::` followed by :protobuf:msg:`Mysqlx.Sql::StmtExecuteOk`
  /// </summary>
  internal sealed partial class StmtExecute : pb::IMessage<StmtExecute> {
    private static readonly pb::MessageParser<StmtExecute> _parser = new pb::MessageParser<StmtExecute>(() => new StmtExecute());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StmtExecute> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Sql.MysqlxSqlReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StmtExecute() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StmtExecute(StmtExecute other) : this() {
      namespace_ = other.namespace_;
      stmt_ = other.stmt_;
      args_ = other.args_.Clone();
      compactMetadata_ = other.compactMetadata_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StmtExecute Clone() {
      return new StmtExecute(this);
    }

    /// <summary>Field number for the "namespace" field.</summary>
    public const int NamespaceFieldNumber = 3;
    private string namespace_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Namespace {
      get { return namespace_; }
      set {
        namespace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stmt" field.</summary>
    public const int StmtFieldNumber = 1;
    private pb::ByteString stmt_ = pb::ByteString.Empty;
    /// <summary>
    /// required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Stmt {
      get { return stmt_; }
      set {
        stmt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "args" field.</summary>
    public const int ArgsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Mysqlx.Datatypes.Any> _repeated_args_codec
        = pb::FieldCodec.ForMessage(18, global::Mysqlx.Datatypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Mysqlx.Datatypes.Any> args_ = new pbc::RepeatedField<global::Mysqlx.Datatypes.Any>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Mysqlx.Datatypes.Any> Args {
      get { return args_; }
    }

    /// <summary>Field number for the "compact_metadata" field.</summary>
    public const int CompactMetadataFieldNumber = 4;
    private bool compactMetadata_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CompactMetadata {
      get { return compactMetadata_; }
      set {
        compactMetadata_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StmtExecute);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StmtExecute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Namespace != other.Namespace) return false;
      if (Stmt != other.Stmt) return false;
      if(!args_.Equals(other.args_)) return false;
      if (CompactMetadata != other.CompactMetadata) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Namespace.Length != 0) hash ^= Namespace.GetHashCode();
      if (Stmt.Length != 0) hash ^= Stmt.GetHashCode();
      hash ^= args_.GetHashCode();
      if (CompactMetadata != false) hash ^= CompactMetadata.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Stmt.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Stmt);
      }
      args_.WriteTo(output, _repeated_args_codec);
      if (Namespace.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Namespace);
      }
      if (CompactMetadata != false) {
        output.WriteRawTag(32);
        output.WriteBool(CompactMetadata);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Namespace.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Namespace);
      }
      if (Stmt.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Stmt);
      }
      size += args_.CalculateSize(_repeated_args_codec);
      if (CompactMetadata != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StmtExecute other) {
      if (other == null) {
        return;
      }
      if (other.Namespace.Length != 0) {
        Namespace = other.Namespace;
      }
      if (other.Stmt.Length != 0) {
        Stmt = other.Stmt;
      }
      args_.Add(other.args_);
      if (other.CompactMetadata != false) {
        CompactMetadata = other.CompactMetadata;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Stmt = input.ReadBytes();
            break;
          }
          case 18: {
            args_.AddEntriesFrom(input, _repeated_args_codec);
            break;
          }
          case 26: {
            Namespace = input.ReadString();
            break;
          }
          case 32: {
            CompactMetadata = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  statement executed successful
  /// </summary>
  internal sealed partial class StmtExecuteOk : pb::IMessage<StmtExecuteOk> {
    private static readonly pb::MessageParser<StmtExecuteOk> _parser = new pb::MessageParser<StmtExecuteOk>(() => new StmtExecuteOk());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StmtExecuteOk> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Sql.MysqlxSqlReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StmtExecuteOk() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StmtExecuteOk(StmtExecuteOk other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StmtExecuteOk Clone() {
      return new StmtExecuteOk(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StmtExecuteOk);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StmtExecuteOk other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StmtExecuteOk other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
