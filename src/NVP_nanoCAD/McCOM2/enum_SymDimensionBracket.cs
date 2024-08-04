using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymDimensionBracket 
{


	[NVP_Manifest(
		Id = "2E03F4C3-FE0C-403F-939A-4D9736685066", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionBracket.enum_mcDimbracketNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionBracket", 
		NodeName = "enum_mcDimbracketNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimbracketNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionBracket.mcDimbracketNone);

		}
	}


	[NVP_Manifest(
		Id = "FDBD5D56-E0B0-430F-AA60-1A16F8A7CBEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionBracket.enum_mcDimbracketSquare", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionBracket", 
		NodeName = "enum_mcDimbracketSquare", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimbracketSquare : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionBracket.mcDimbracketSquare);

		}
	}


	[NVP_Manifest(
		Id = "FB108985-87C1-4814-A29F-5C757927FB22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionBracket.enum_mcDimbracketRound", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionBracket", 
		NodeName = "enum_mcDimbracketRound", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimbracketRound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionBracket.mcDimbracketRound);

		}
	}


	[NVP_Manifest(
		Id = "8A7DF3EE-2F65-4F73-A252-BE62B413F77B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionBracket.enum_mcDimbracketAngular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionBracket", 
		NodeName = "enum_mcDimbracketAngular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimbracketAngular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionBracket.mcDimbracketAngular);

		}
	}
}
