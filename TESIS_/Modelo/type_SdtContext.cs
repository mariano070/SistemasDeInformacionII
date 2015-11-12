using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtContext : GxUserType
   {
      public SdtContext( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtContext( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name ;
         if ( oReader.IsSimple == 0 )
         {
            GXSoapError = oReader.Read() ;
            nOutParmCount = 0 ;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0 ;
               if ( StringUtil.StrCmp(oReader.LocalName, "User") == 0 )
               {
                  gxTv_SdtContext_User = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "CompanyCode") == 0 )
               {
                  gxTv_SdtContext_Companycode = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Profile") == 0 )
               {
                  gxTv_SdtContext_Profile = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Sistema") == 0 )
               {
                  gxTv_SdtContext_Sistema = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Programa") == 0 )
               {
                  gxTv_SdtContext_Programa = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Icono") == 0 )
               {
                  gxTv_SdtContext_Icono = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Sesion") == 0 )
               {
                  gxTv_SdtContext_Sesion = (int)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Denominacion") == 0 )
               {
                  gxTv_SdtContext_Denominacion = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Tipo") == 0 )
               {
                  gxTv_SdtContext_Tipo = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Codigo") == 0 )
               {
                  gxTv_SdtContext_Codigo = (int)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Zona") == 0 )
               {
                  gxTv_SdtContext_Zona = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Plan") == 0 )
               {
                  gxTv_SdtContext_Plan = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Mail") == 0 )
               {
                  gxTv_SdtContext_Mail = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "tipo_usuario") == 0 )
               {
                  gxTv_SdtContext_Tipo_usuario = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               nOutParmCount = (short)(nOutParmCount+1) ;
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( ) ;
                  GXSoapError = (short)(nOutParmCount*-1) ;
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "Context" ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "MarianoTesis" ;
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10)) ;
         }
         oWriter.WriteElement("User", StringUtil.RTrim( gxTv_SdtContext_User));
         oWriter.WriteElement("CompanyCode", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtContext_Companycode), 4, 0)));
         oWriter.WriteElement("Profile", StringUtil.RTrim( gxTv_SdtContext_Profile));
         oWriter.WriteElement("Sistema", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtContext_Sistema), 4, 0)));
         oWriter.WriteElement("Programa", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtContext_Programa), 4, 0)));
         oWriter.WriteElement("Icono", StringUtil.RTrim( gxTv_SdtContext_Icono));
         oWriter.WriteElement("Sesion", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtContext_Sesion), 8, 0)));
         oWriter.WriteElement("Denominacion", StringUtil.RTrim( gxTv_SdtContext_Denominacion));
         oWriter.WriteElement("Tipo", StringUtil.RTrim( gxTv_SdtContext_Tipo));
         oWriter.WriteElement("Codigo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtContext_Codigo), 8, 0)));
         oWriter.WriteElement("Zona", StringUtil.RTrim( gxTv_SdtContext_Zona));
         oWriter.WriteElement("Plan", StringUtil.RTrim( gxTv_SdtContext_Plan));
         oWriter.WriteElement("Mail", StringUtil.RTrim( gxTv_SdtContext_Mail));
         oWriter.WriteElement("tipo_usuario", StringUtil.RTrim( gxTv_SdtContext_Tipo_usuario));
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("User", (Object)(gxTv_SdtContext_User));
         AddObjectProperty("CompanyCode", (Object)(gxTv_SdtContext_Companycode));
         AddObjectProperty("Profile", (Object)(gxTv_SdtContext_Profile));
         AddObjectProperty("Sistema", (Object)(gxTv_SdtContext_Sistema));
         AddObjectProperty("Programa", (Object)(gxTv_SdtContext_Programa));
         AddObjectProperty("Icono", (Object)(gxTv_SdtContext_Icono));
         AddObjectProperty("Sesion", (Object)(gxTv_SdtContext_Sesion));
         AddObjectProperty("Denominacion", (Object)(gxTv_SdtContext_Denominacion));
         AddObjectProperty("Tipo", (Object)(gxTv_SdtContext_Tipo));
         AddObjectProperty("Codigo", (Object)(gxTv_SdtContext_Codigo));
         AddObjectProperty("Zona", (Object)(gxTv_SdtContext_Zona));
         AddObjectProperty("Plan", (Object)(gxTv_SdtContext_Plan));
         AddObjectProperty("Mail", (Object)(gxTv_SdtContext_Mail));
         AddObjectProperty("tipo_usuario", (Object)(gxTv_SdtContext_Tipo_usuario));
         return  ;
      }

      public String gxTpr_User
      {
         get {
            return gxTv_SdtContext_User ;
         }

         set {
            gxTv_SdtContext_User = (String)(value) ;
         }

      }

      public void gxTv_SdtContext_User_SetNull( )
      {
         gxTv_SdtContext_User = "" ;
         return  ;
      }

      public bool gxTv_SdtContext_User_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Companycode
      {
         get {
            return gxTv_SdtContext_Companycode ;
         }

         set {
            gxTv_SdtContext_Companycode = (short)(value) ;
         }

      }

      public void gxTv_SdtContext_Companycode_SetNull( )
      {
         gxTv_SdtContext_Companycode = 0 ;
         return  ;
      }

      public bool gxTv_SdtContext_Companycode_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Profile
      {
         get {
            return gxTv_SdtContext_Profile ;
         }

         set {
            gxTv_SdtContext_Profile = (String)(value) ;
         }

      }

      public void gxTv_SdtContext_Profile_SetNull( )
      {
         gxTv_SdtContext_Profile = "" ;
         return  ;
      }

      public bool gxTv_SdtContext_Profile_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Sistema
      {
         get {
            return gxTv_SdtContext_Sistema ;
         }

         set {
            gxTv_SdtContext_Sistema = (short)(value) ;
         }

      }

      public void gxTv_SdtContext_Sistema_SetNull( )
      {
         gxTv_SdtContext_Sistema = 0 ;
         return  ;
      }

      public bool gxTv_SdtContext_Sistema_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Programa
      {
         get {
            return gxTv_SdtContext_Programa ;
         }

         set {
            gxTv_SdtContext_Programa = (short)(value) ;
         }

      }

      public void gxTv_SdtContext_Programa_SetNull( )
      {
         gxTv_SdtContext_Programa = 0 ;
         return  ;
      }

      public bool gxTv_SdtContext_Programa_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Icono
      {
         get {
            return gxTv_SdtContext_Icono ;
         }

         set {
            gxTv_SdtContext_Icono = (String)(value) ;
         }

      }

      public void gxTv_SdtContext_Icono_SetNull( )
      {
         gxTv_SdtContext_Icono = "" ;
         return  ;
      }

      public bool gxTv_SdtContext_Icono_IsNull( )
      {
         return false ;
      }

      public int gxTpr_Sesion
      {
         get {
            return gxTv_SdtContext_Sesion ;
         }

         set {
            gxTv_SdtContext_Sesion = (int)(value) ;
         }

      }

      public void gxTv_SdtContext_Sesion_SetNull( )
      {
         gxTv_SdtContext_Sesion = 0 ;
         return  ;
      }

      public bool gxTv_SdtContext_Sesion_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Denominacion
      {
         get {
            return gxTv_SdtContext_Denominacion ;
         }

         set {
            gxTv_SdtContext_Denominacion = (String)(value) ;
         }

      }

      public void gxTv_SdtContext_Denominacion_SetNull( )
      {
         gxTv_SdtContext_Denominacion = "" ;
         return  ;
      }

      public bool gxTv_SdtContext_Denominacion_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Tipo
      {
         get {
            return gxTv_SdtContext_Tipo ;
         }

         set {
            gxTv_SdtContext_Tipo = (String)(value) ;
         }

      }

      public void gxTv_SdtContext_Tipo_SetNull( )
      {
         gxTv_SdtContext_Tipo = "" ;
         return  ;
      }

      public bool gxTv_SdtContext_Tipo_IsNull( )
      {
         return false ;
      }

      public int gxTpr_Codigo
      {
         get {
            return gxTv_SdtContext_Codigo ;
         }

         set {
            gxTv_SdtContext_Codigo = (int)(value) ;
         }

      }

      public void gxTv_SdtContext_Codigo_SetNull( )
      {
         gxTv_SdtContext_Codigo = 0 ;
         return  ;
      }

      public bool gxTv_SdtContext_Codigo_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Zona
      {
         get {
            return gxTv_SdtContext_Zona ;
         }

         set {
            gxTv_SdtContext_Zona = (String)(value) ;
         }

      }

      public void gxTv_SdtContext_Zona_SetNull( )
      {
         gxTv_SdtContext_Zona = "" ;
         return  ;
      }

      public bool gxTv_SdtContext_Zona_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Plan
      {
         get {
            return gxTv_SdtContext_Plan ;
         }

         set {
            gxTv_SdtContext_Plan = (String)(value) ;
         }

      }

      public void gxTv_SdtContext_Plan_SetNull( )
      {
         gxTv_SdtContext_Plan = "" ;
         return  ;
      }

      public bool gxTv_SdtContext_Plan_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Mail
      {
         get {
            return gxTv_SdtContext_Mail ;
         }

         set {
            gxTv_SdtContext_Mail = (String)(value) ;
         }

      }

      public void gxTv_SdtContext_Mail_SetNull( )
      {
         gxTv_SdtContext_Mail = "" ;
         return  ;
      }

      public bool gxTv_SdtContext_Mail_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Tipo_usuario
      {
         get {
            return gxTv_SdtContext_Tipo_usuario ;
         }

         set {
            gxTv_SdtContext_Tipo_usuario = (String)(value) ;
         }

      }

      public void gxTv_SdtContext_Tipo_usuario_SetNull( )
      {
         gxTv_SdtContext_Tipo_usuario = "" ;
         return  ;
      }

      public bool gxTv_SdtContext_Tipo_usuario_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtContext_User = "" ;
         gxTv_SdtContext_Profile = "" ;
         gxTv_SdtContext_Icono = "" ;
         gxTv_SdtContext_Denominacion = "" ;
         gxTv_SdtContext_Tipo = "" ;
         gxTv_SdtContext_Zona = "" ;
         gxTv_SdtContext_Plan = "" ;
         gxTv_SdtContext_Mail = "" ;
         gxTv_SdtContext_Tipo_usuario = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short gxTv_SdtContext_Companycode ;
      protected short gxTv_SdtContext_Sistema ;
      protected short gxTv_SdtContext_Programa ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected int gxTv_SdtContext_Sesion ;
      protected int gxTv_SdtContext_Codigo ;
      protected String gxTv_SdtContext_User ;
      protected String gxTv_SdtContext_Profile ;
      protected String gxTv_SdtContext_Icono ;
      protected String gxTv_SdtContext_Denominacion ;
      protected String gxTv_SdtContext_Tipo ;
      protected String gxTv_SdtContext_Zona ;
      protected String gxTv_SdtContext_Plan ;
      protected String gxTv_SdtContext_Tipo_usuario ;
      protected String sTagName ;
      protected String gxTv_SdtContext_Mail ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
