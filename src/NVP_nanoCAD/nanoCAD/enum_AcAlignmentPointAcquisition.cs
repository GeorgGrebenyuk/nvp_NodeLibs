using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcAlignmentPointAcquisition 
{


	[NVP_Manifest(
		Id = "A1783D98-C4EF-47BB-B71D-383EAF5C733F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcAlignmentPointAcquisition.enum_acAlignPntAcquisitionAutomatic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcAlignmentPointAcquisition", 
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
			return new NodeResult(nanoCAD.AcAlignmentPointAcquisition.acAlignPntAcquisitionAutomatic);

		}
	}


	[NVP_Manifest(
		Id = "7228DC6E-F64C-4294-B684-01B5AF56C90E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcAlignmentPointAcquisition.enum_acAlignPntAcquisitionShiftToAcquire", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcAlignmentPointAcquisition", 
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
			return new NodeResult(nanoCAD.AcAlignmentPointAcquisition.acAlignPntAcquisitionShiftToAcquire);

		}
	}
}
