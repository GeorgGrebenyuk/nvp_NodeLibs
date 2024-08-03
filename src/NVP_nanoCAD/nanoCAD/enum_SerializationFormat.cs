using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_SerializationFormat 
{


	[NVP_Manifest(
		Id = "96FC2B74-2B4E-4072-A899-4DDC916DBBB7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_SerializationFormat.enum_eST_INI", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_SerializationFormat", 
		NodeName = "enum_eST_INI", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_eST_INI : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.SerializationFormat.eST_INI);

		}
	}


	[NVP_Manifest(
		Id = "5FB62B39-ED64-44E6-B730-C5D54637C83A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_SerializationFormat.enum_eST_XMLRPC", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_SerializationFormat", 
		NodeName = "enum_eST_XMLRPC", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_eST_XMLRPC : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.SerializationFormat.eST_XMLRPC);

		}
	}


	[NVP_Manifest(
		Id = "BFEDB03C-7966-49CF-9976-15E7AB5939CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_SerializationFormat.enum_eST_JSON", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_SerializationFormat", 
		NodeName = "enum_eST_JSON", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_eST_JSON : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.SerializationFormat.eST_JSON);

		}
	}
}
