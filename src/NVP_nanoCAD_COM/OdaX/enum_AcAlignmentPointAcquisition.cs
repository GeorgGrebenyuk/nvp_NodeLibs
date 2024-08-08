using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcAlignmentPointAcquisition 
{


	[NVP_Manifest(
		Id = "CEB0ED18-490A-471F-8DEF-3F159825D7EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignmentPointAcquisition.enum_acAlignPntAcquisitionAutomatic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignmentPointAcquisition", 
		NodeName = "enum_acAlignPntAcquisitionAutomatic", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignPntAcquisitionAutomatic : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignmentPointAcquisition.acAlignPntAcquisitionAutomatic);

		}
	}


	[NVP_Manifest(
		Id = "597A5E6F-A5E7-4CAD-BAF0-C86139B3160F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignmentPointAcquisition.enum_acAlignPntAcquisitionShiftToAcquire", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignmentPointAcquisition", 
		NodeName = "enum_acAlignPntAcquisitionShiftToAcquire", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignPntAcquisitionShiftToAcquire : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignmentPointAcquisition.acAlignPntAcquisitionShiftToAcquire);

		}
	}
}
