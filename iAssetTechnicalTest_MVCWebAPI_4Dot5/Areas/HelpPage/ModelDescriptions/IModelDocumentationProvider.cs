using System;
using System.Reflection;

namespace iAssetTechnicalTest_MVCWebAPI_4Dot5.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}