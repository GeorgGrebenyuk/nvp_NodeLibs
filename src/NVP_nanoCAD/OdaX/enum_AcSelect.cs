using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcSelect 
{


	[NVP_Manifest(
		Id = "4EED1A9F-53DD-45BD-B145-45D981C41C00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelect.enum_acSelectionSetWindow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelect", 
		NodeName = "enum_acSelectionSetWindow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelect.acSelectionSetWindow);

		}
	}


	[NVP_Manifest(
		Id = "2EA96D8A-4463-4087-A205-6816793392DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelect.enum_acSelectionSetCrossing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelect", 
		NodeName = "enum_acSelectionSetCrossing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetCrossing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelect.acSelectionSetCrossing);

		}
	}


	[NVP_Manifest(
		Id = "4BEAA5CD-7F9C-4420-BE5C-0ED213E47865", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelect.enum_acSelectionSetFence", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelect", 
		NodeName = "enum_acSelectionSetFence", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetFence : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelect.acSelectionSetFence);

		}
	}


	[NVP_Manifest(
		Id = "C3B5FAF2-C2AC-499A-A879-834B553BEF55", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelect.enum_acSelectionSetPrevious", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelect", 
		NodeName = "enum_acSelectionSetPrevious", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetPrevious : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelect.acSelectionSetPrevious);

		}
	}


	[NVP_Manifest(
		Id = "E4574337-C00E-4AFD-8037-9FBDC1CCC99F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelect.enum_acSelectionSetLast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelect", 
		NodeName = "enum_acSelectionSetLast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetLast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelect.acSelectionSetLast);

		}
	}


	[NVP_Manifest(
		Id = "58F881AF-DFCD-4F0B-B361-5E6FDE9AEDDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelect.enum_acSelectionSetAll", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelect", 
		NodeName = "enum_acSelectionSetAll", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelect.acSelectionSetAll);

		}
	}


	[NVP_Manifest(
		Id = "30F2A195-34FD-4497-A5AE-56B57F34EC14", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelect.enum_acSelectionSetWindowPolygon", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelect", 
		NodeName = "enum_acSelectionSetWindowPolygon", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetWindowPolygon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelect.acSelectionSetWindowPolygon);

		}
	}


	[NVP_Manifest(
		Id = "074AEF23-DD22-45B9-B392-656C222D9D32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelect.enum_acSelectionSetCrossingPolygon", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelect", 
		NodeName = "enum_acSelectionSetCrossingPolygon", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetCrossingPolygon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelect.acSelectionSetCrossingPolygon);

		}
	}
}
