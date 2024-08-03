using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPlotRotation 
{


	[NVP_Manifest(
		Id = "9381F704-C02E-45FF-986C-5A3CED20C4B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotRotation.enum_ac0degrees", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotRotation", 
		NodeName = "enum_ac0degrees", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ac0degrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotRotation.ac0degrees);

		}
	}


	[NVP_Manifest(
		Id = "32237FFE-469D-4ADA-BBFF-87BEEEA4100E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotRotation.enum_ac90degrees", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotRotation", 
		NodeName = "enum_ac90degrees", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ac90degrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotRotation.ac90degrees);

		}
	}


	[NVP_Manifest(
		Id = "89B7C5E7-BA1B-4E36-845A-73F3CBE06309", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotRotation.enum_ac180degrees", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotRotation", 
		NodeName = "enum_ac180degrees", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ac180degrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotRotation.ac180degrees);

		}
	}


	[NVP_Manifest(
		Id = "08B0BEC3-8462-489B-BB8F-DF6B85600A0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotRotation.enum_ac270degrees", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotRotation", 
		NodeName = "enum_ac270degrees", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ac270degrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotRotation.ac270degrees);

		}
	}
}
