using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_DuctFormType 
{


	[NVP_Manifest(
		Id = "0416A29D-B26B-45E5-8DC3-629EA4E2F383", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_DuctFormType.enum_DuctFormType_Circle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_DuctFormType", 
		NodeName = "enum_DuctFormType_Circle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_DuctFormType_Circle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.DuctFormType.DuctFormType_Circle);

		}
	}


	[NVP_Manifest(
		Id = "8E764913-1F48-44D7-9F05-BCFDB7808622", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_DuctFormType.enum_DuctFormType_Rect", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_DuctFormType", 
		NodeName = "enum_DuctFormType_Rect", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_DuctFormType_Rect : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.DuctFormType.DuctFormType_Rect);

		}
	}
}
