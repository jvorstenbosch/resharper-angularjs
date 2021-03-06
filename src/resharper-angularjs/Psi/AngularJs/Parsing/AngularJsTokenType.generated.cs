﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by TokenGenerator
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Parsing;

namespace JetBrains.ReSharper.Psi.AngularJs.Parsing
{
  public partial class AngularJsTokenType
  {
    #region UNDEFINED_KEYWORD
    private class UndefinedKeywordNodeType : KeywordTokenNodeType
    {
      public UndefinedKeywordNodeType(int index): base ("UNDEFINED_KEYWORD", "undefined", index) { }
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new UndefinedKeywordTokenElement(this);
      }
    }
    private class UndefinedKeywordTokenElement : FixedTokenElement
    {
      public UndefinedKeywordTokenElement(UndefinedKeywordNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType UNDEFINED_KEYWORD = new UndefinedKeywordNodeType(7000);
    #endregion
    #region TRACK_BY_KEYWORD
    private class TrackByKeywordNodeType : KeywordTokenNodeType
    {
      public TrackByKeywordNodeType(int index): base ("TRACK_BY_KEYWORD", "track by", index) { }
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new TrackByKeywordTokenElement(this);
      }
    }
    private class TrackByKeywordTokenElement : FixedTokenElement
    {
      public TrackByKeywordTokenElement(TrackByKeywordNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType TRACK_BY_KEYWORD = new TrackByKeywordNodeType(7001);
    #endregion


    private const int LAST_GENERATED_TOKEN_TYPE_INDEX = 7002;  }
}
