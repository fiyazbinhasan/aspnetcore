﻿using System;
using System.Linq.Expressions;

namespace Microsoft.AspNet.Mvc.Rendering
{
    public static class HtmlHelperLabelExtensions
    {
        public static HtmlString Label<TModel>([NotNull] this IHtmlHelper<TModel> html, string expression)
        {
            return html.Label(expression,
                             labelText: null,
                             htmlAttributes: null);
        }

        public static HtmlString Label<TModel>([NotNull] this IHtmlHelper<TModel> html,
                                               string expression,
                                               string labelText)
        {
            return html.Label(expression, labelText, htmlAttributes: null);
        }

        public static HtmlString LabelFor<TModel, TValue>([NotNull] this IHtmlHelper<TModel> html,
                                                          [NotNull] Expression<Func<TModel, TValue>> expression)
        {
            return html.LabelFor<TValue>(expression, labelText: null, htmlAttributes: null);
        }

        public static HtmlString LabelFor<TModel, TValue>([NotNull] this IHtmlHelper<TModel> html,
                                                          [NotNull] Expression<Func<TModel, TValue>> expression,
                                                          string labelText)
        {
            return html.LabelFor<TValue>(expression, labelText, htmlAttributes: null);
        }

        public static HtmlString LabelFor<TModel, TValue>([NotNull] this IHtmlHelper<TModel> html,
                                                          [NotNull] Expression<Func<TModel, TValue>> expression,
                                                          object htmlAttributes)
        {
            return html.LabelFor<TValue>(expression, labelText: null, htmlAttributes: htmlAttributes);
        }

        public static HtmlString LabelForModel<TModel>([NotNull] this IHtmlHelper<TModel> html)
        {
            return LabelForModel(html, labelText: null);
        }

        public static HtmlString LabelForModel<TModel>([NotNull] this IHtmlHelper<TModel> html, string labelText)
        {
            return html.Label(expression: string.Empty, labelText: labelText, htmlAttributes: null);
        }

        public static HtmlString LabelForModel<TModel>([NotNull] this IHtmlHelper<TModel> html,
                                                        object htmlAttributes)
        {
            return html.Label(expression: string.Empty, labelText: null, htmlAttributes: htmlAttributes);
        }

        public static HtmlString LabelForModel<TModel>([NotNull] this IHtmlHelper<TModel> html,
                                                        string labelText,
                                                        object htmlAttributes)
        {
            return html.Label(expression: string.Empty, labelText: labelText, htmlAttributes: htmlAttributes);
        }
    }
}