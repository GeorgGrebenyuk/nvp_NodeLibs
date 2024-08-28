using NVP.API.Nodes;
using System;
using System.Linq;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Teigha.DatabaseServices;
using ncCommon;
using BIMStructureMgd.ObjectProperties;
using System.Collections;


namespace Parameters.ElementData
{
    internal class ElementDataContainer
    {
        public List<ParameterInfo> _orderedParameters;
        public List<ParameterCategory> _categories;

        public ElementDataContainer(BIMStructureMgd.ObjectProperties.ElementData elementData)
        {
            var parameters = elementData.Parameters.Select(p => (Parameter: p, Def: ParameterDefCollection.Global.GetParameterDef(p))).ToList();
            _categories = parameters.SelectMany(p => p.Def?.Categories ?? Array.Empty<ParameterCategory>())
                                       .GroupBy(c => c.Name)
                                       .Select(gr => gr.First())
                                       .OrderBy(c => c.CategoryOrder)
                                       .ToList();


            foreach (var (categoryName, index) in _categories.Select((c, index) => (c.Name, index)))
            {
                this._orderedParameters.AddRange(parameters.Where(p => p.Def?.HasCategory(categoryName) ?? false)
                                                           .OrderBy(p => p.Def.GetCategory(categoryName).ParameterOrder)
                                                           .Select(p => new ParameterInfo(p.Parameter, string.Format("{0,2:d}. {1}", index + 1, categoryName))));
            }

            var noCategoryParameters = parameters.Where(p => !(p.Def?.Categories.Any() ?? false)).ToList();
            this._orderedParameters.AddRange(noCategoryParameters.Select(p => new ParameterInfo(p.Parameter, null)));
        }


        public class ParameterInfo
        {
            public readonly Parameter _parameter;

            public ParameterInfo(Parameter parameter, string? category)
            {
                _parameter = parameter;
                Category = category ?? "Общие";
            }

            public string Name => _parameter.Name;

            public string? Category { get; init; }

            public string? Description => string.Format("Value: {0}; Expression: {1}", _parameter.Value, _parameter.ValueExpression);

            public string? DisplayName => string.IsNullOrEmpty(_parameter.Comment) ? null : _parameter.Comment;
        }
    }

    [NVP_Manifest(
        Text = "Получает ElementData из объекта nBIM",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("nBIM Teigha.Entity", typeof(object))]
    public class ElementData_Constructor : INode
    {
        public BIMStructureMgd.ObjectProperties.ElementData _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            var nBIM_Object = _input0._o as IParametricObject;

            _o = nBIM_Object.GetElementData();

            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
    Text = "Создает пустое определение ElementData",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class ElementData_CreateEmpty_Constructor : INode
    {
        public BIMStructureMgd.ObjectProperties.ElementData _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            _o = new BIMStructureMgd.ObjectProperties.ElementData();

            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
       Text = "Копирует ElementData из другого ElementData",
       CADType = "Nanocad",
       ViewType = "Data")]
    [NodeInput("ElementData", typeof(object))]
    public class ElementData_CopyFrom_Constructor : INode
    {
        public BIMStructureMgd.ObjectProperties.ElementData _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            var nBIMElementData = _input0._o as BIMStructureMgd.ObjectProperties.ElementData;

            _o = new BIMStructureMgd.ObjectProperties.ElementData();
            _o.CopyFrom(nBIMElementData);
            return new NodeResult(this);
        }
    }


    [NVP_Manifest(
       Text = "Возвращает все параметры в виде словаря",
       CADType = "Nanocad",
       ViewType = "Data")]
    [NodeInput("ElementData", typeof(object))]
    public class GetParameters : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            var nBIMElementData = _input0._o as BIMStructureMgd.ObjectProperties.ElementData;

            List<string> param_names = new List<string>();
            List<string> param_values = new List<string>();
            List<string> param_comments = new List<string>();
            List<string> param_values_expr = new List<string>();

            foreach (var parameter in nBIMElementData.Parameters)
            {
                param_names.Add(parameter.Name);
                param_values.Add(parameter.Value);
                param_comments.Add(parameter.Comment);
                param_values_expr.Add(parameter.ValueExpression);

            }
            return new NodeResult(new object[] { param_names, param_values, param_comments, param_values_expr });
        }
    }

    [NVP_Manifest(
       Text = "Возвращает все параметры в виде словаря для заданной категории",
       CADType = "Nanocad",
       ViewType = "Data")]
    [NodeInput("ElementData", typeof(object))]
    public class GetParametersForCategory : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            var nBIMElementData = _input0._o as BIMStructureMgd.ObjectProperties.ElementData;
            string _input1_CategoryName = (string)inputs[1].Value;
            var nBIMElementData_Helper = new ElementDataContainer(nBIMElementData);

            List<string> param_names = new List<string>();
            List<string> param_values = new List<string>();
            List<string> param_comments = new List<string>();
            List<string> param_values_expr = new List<string>();

            foreach (var parameter in nBIMElementData_Helper._orderedParameters.Where(p => p.Category == _input1_CategoryName))
            {
                param_names.Add(parameter._parameter.Name);
                param_values.Add(parameter._parameter.Value);
                param_comments.Add(parameter._parameter.Comment);
                param_values_expr.Add(parameter._parameter.ValueExpression);

            }

            return new NodeResult(new object[] { param_names, param_values, param_comments, param_values_expr });
        }
    }

    [NVP_Manifest(
       Text = "Возвращает список категорий параметров",
       CADType = "Nanocad",
       ViewType = "Data")]
    [NodeInput("ElementData", typeof(object))]
    public class GetCategories : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            var nBIMElementData = _input0._o as BIMStructureMgd.ObjectProperties.ElementData;
            var nBIMElementData_Helper = new ElementDataContainer(nBIMElementData);

            
            var categories_Names = nBIMElementData_Helper._categories.Select(c => c.Name).ToList();

            return new NodeResult(categories_Names);
        }
    }


    [NVP_Manifest(
       Text = "Задает значения параметрам",
       CADType = "Nanocad",
       ViewType = "Modifier")]
    [NodeInput("ElementData", typeof(object))]
    [NodeInput("Список названий параметров", typeof(IList))]
    [NodeInput("Список значений параметров", typeof(IList))]
    public class SetParameters : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            var nBIMElementData = _input0._o as BIMStructureMgd.ObjectProperties.ElementData;
            var nBIMElementData_Helper = new ElementDataContainer(nBIMElementData);

            IList params_names = (IList)inputs[1].Value;
            IList params_values = (IList)inputs[2].Value;

            for (int param_index = 0; param_index < params_names.Count; param_index++)
            {
                string param_name = (string)params_names[param_index];
                string param_value = params_values[param_index].ToString();

                nBIMElementData.SetParameter(param_name, param_value);
            }

            return new NodeResult(null);
        }
    }




}
