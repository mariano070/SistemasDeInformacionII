/*
               File: TSEG004_U
        Description: ACT. USUARIO/SIST./PROG.
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:47.10
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class tseg004_u : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A6USU_COD = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A6USU_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A6USU_COD = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A6USU_COD, A116SIS_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         if ( ! entryPointCalled )
         {
            A116SIS_COD = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               AV7SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
               AV8USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "ACT. USUARIO/SIST./PROG.", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUSU_COD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tseg004_u( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg004_u( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_SIS_COD ,
                           ref short aP1_PRG_COD ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO ,
                           ref String aP4_Gx_mode )
      {
         this.A116SIS_COD = aP0_SIS_COD;
         this.A126PRG_COD = aP1_PRG_COD;
         this.AV7SISTEMA = aP2_SISTEMA;
         this.AV8USUARIO = aP3_USUARIO;
         this.Gx_mode = aP4_Gx_mode;
         executePrivate();
         aP0_SIS_COD=this.A116SIS_COD;
         aP1_PRG_COD=this.A126PRG_COD;
         aP2_SISTEMA=this.AV7SISTEMA;
         aP3_USUARIO=this.AV8USUARIO;
         aP4_Gx_mode=this.Gx_mode;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_0K21( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0K21e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0K21( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:30px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_10_0K21( true) ;
         }
         return  ;
      }

      protected void wb_table2_10_0K21e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_55_0K21( true) ;
         }
         return  ;
      }

      protected void wb_table3_55_0K21e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0K21e( true) ;
         }
         else
         {
            wb_table1_2_0K21e( false) ;
         }
      }

      protected void wb_table3_55_0K21( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"" ;
            ClassString = "BtnCheck" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_check_Internalname, "Verificar", "Verificar", "", StyleString, ClassString, bttBtn_check_Visible, bttBtn_check_Enabled, "rounded", 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"" ;
            ClassString = "BtnHelp" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_help_Internalname, "Ayuda", "Ayuda", "", StyleString, ClassString, bttBtn_help_Visible, 1, "rounded", 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_55_0K21e( true) ;
         }
         else
         {
            wb_table3_55_0K21e( false) ;
         }
      }

      protected void wb_table2_10_0K21( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Código", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, 1, edtUSU_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(15);\"", 0, edtUSU_COD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG004_U.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_6_Internalname, "", "prompt.gif", "Modern", imgprompt_6_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_6_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, edtUSU_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), "", 0, edtUSU_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Código", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtSIS_COD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"), "", 0, edtSIS_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_DES_Internalname, StringUtil.RTrim( A259SIS_DES), "", 15, "chr", 1, "row", 15, 1, edtSIS_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), "", 0, edtSIS_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "Código", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtPRG_COD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), "", 0, edtPRG_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG004_U.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"" ;
            ClassString = "BtnGet" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_get_Internalname, "=>", "=>", "", StyleString, ClassString, bttBtn_get_Visible, bttBtn_get_Enabled, "rounded", 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, edtPRG_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRG_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, 1, 1, 0, "Nombre Físico", "", "", "", 0, lblTextblock8_Jsonclick, "", StyleString, ClassString, "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_NFI_Internalname, StringUtil.RTrim( A289PRG_NFI), "", 8, "chr", 1, "row", 8, 1, edtPRG_NFI_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A289PRG_NFI, "@!")), "", 0, edtPRG_NFI_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG004_U.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_0K21e( true) ;
         }
         else
         {
            wb_table2_10_0K21e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110K2 */
         E110K2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A289PRG_NFI = StringUtil.Upper( cgiGet( edtPRG_NFI_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
               /* Read saved values. */
               Z6USU_COD = cgiGet( "Z6USU_COD") ;
               Z116SIS_COD = (short)(context.localUtil.CToN( cgiGet( "Z116SIS_COD"), ",", ".")) ;
               Z126PRG_COD = (short)(context.localUtil.CToN( cgiGet( "Z126PRG_COD"), ",", ".")) ;
               Z290USU_CNT = cgiGet( "Z290USU_CNT") ;
               A290USU_CNT = cgiGet( "Z290USU_CNT") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7SISTEMA = cgiGet( "vSISTEMA") ;
               AV8USUARIO = cgiGet( "vUSUARIO") ;
               A290USU_CNT = cgiGet( "USU_CNT") ;
               A155USU_CLA = cgiGet( "USU_CLA") ;
               Gx_mode = cgiGet( "vMODE") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A6USU_COD = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                  A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                  A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  standaloneModal( ) ;
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E110K2 */
                           E110K2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120K2 */
                           E120K2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GET") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_get( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "CHECK") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_Check( ) ;
                           /* No code required for Help button. It is implemented at the Browser level. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: E120K2 */
            E120K2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0K21( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
            edtUSU_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_DES_Enabled), 5, 0)));
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
            edtSIS_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_DES_Enabled), 5, 0)));
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
            edtPRG_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Enabled), 5, 0)));
            edtPRG_NFI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_NFI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_NFI_Enabled), 5, 0)));
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void CONFIRM_0K0( )
      {
         BeforeValidate0K21( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0K21( ) ;
            }
            else
            {
               CheckExtendedTable0K21( ) ;
               if ( AnyError == 0 )
               {
                  ZM0K21( 5) ;
                  ZM0K21( 6) ;
                  ZM0K21( 7) ;
                  ZM0K21( 8) ;
               }
               CloseExtendedTableCursors0K21( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
         if ( AnyError == 0 )
         {
            ConfirmValues0K0( ) ;
         }
      }

      protected void ResetCaption0K0( )
      {
      }

      protected void E110K2( )
      {
         /* Start Routine */
      }

      protected void E120K2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0K21( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z290USU_CNT = T000K3_A290USU_CNT[0] ;
            }
            else
            {
               Z290USU_CNT = A290USU_CNT ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z290USU_CNT = A290USU_CNT ;
            Z6USU_COD = A6USU_COD ;
            Z116SIS_COD = A116SIS_COD ;
            Z126PRG_COD = A126PRG_COD ;
            Z259SIS_DES = A259SIS_DES ;
            Z127PRG_DES = A127PRG_DES ;
            Z289PRG_NFI = A289PRG_NFI ;
            Z7USU_DES = A7USU_DES ;
            Z155USU_CLA = A155USU_CLA ;
         }
      }

      protected void standaloneNotModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
         }
         else
         {
            edtUSU_COD_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
         }
         imgprompt_6_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USU_COD"+"'), id:'"+"USU_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         /* Using cursor T000K5 */
         pr_default.execute(3, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000K5_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         }
         pr_default.close(3);
         /* Using cursor T000K7 */
         pr_default.execute(5, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T000K7_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T000K7_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
         }
         pr_default.close(5);
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            bttBtn_get_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_get_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_check_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_check_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
      }

      protected void Load0K21( )
      {
         /* Using cursor T000K8 */
         pr_default.execute(6, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound21 = 1 ;
            A7USU_DES = T000K8_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000K8_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            A259SIS_DES = T000K8_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            A127PRG_DES = T000K8_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T000K8_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
            A290USU_CNT = T000K8_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
            ZM0K21( -4) ;
         }
         pr_default.close(6);
         OnLoadActions0K21( ) ;
      }

      protected void OnLoadActions0K21( )
      {
      }

      protected void CheckExtendedTable0K21( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000K4 */
         pr_default.execute(2, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(2) == 101) )
         {
            context.wjLoc = formatLink("gx00f0.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) ;
            /* Using cursor T000K4 */
            pr_default.execute(2, new Object[] {A6USU_COD});
            if ( (pr_default.getStatus(2) == 101) )
            {
               GX_msglist.addItem("No existe 'SEG002'.", "ForeignKeyNotFound", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( AnyError == 0 )
         {
            A7USU_DES = T000K4_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000K4_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         }
         pr_default.close(2);
         /* Using cursor T000K6 */
         pr_default.execute(4, new Object[] {A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG003'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(4);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A6USU_COD)) )
         {
            GX_msglist.addItem("Usuario NO debe ser NULO", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0K21( )
      {
         pr_default.close(2);
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A6USU_COD )
      {
         /* Using cursor T000K9 */
         pr_default.execute(7, new Object[] {A6USU_COD});
         if ( AnyError == 0 )
         {
            A7USU_DES = T000K9_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000K9_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A7USU_DES))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A155USU_CLA))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(7);
      }

      protected void gxLoad_7( String A6USU_COD ,
                               short A116SIS_COD )
      {
         /* Using cursor T000K10 */
         pr_default.execute(8, new Object[] {A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG003'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void GetKey0K21( )
      {
         /* Using cursor T000K11 */
         pr_default.execute(9, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound21 = 1 ;
         }
         else
         {
            RcdFound21 = 0 ;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000K3 */
         pr_default.execute(1, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(1) != 101) && ( T000K3_A116SIS_COD[0] == A116SIS_COD ) && ( T000K3_A126PRG_COD[0] == A126PRG_COD ) )
         {
            ZM0K21( 4) ;
            RcdFound21 = 1 ;
            A290USU_CNT = T000K3_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
            A6USU_COD = T000K3_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            Z6USU_COD = A6USU_COD ;
            Z116SIS_COD = A116SIS_COD ;
            Z126PRG_COD = A126PRG_COD ;
            sMode21 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0K21( ) ;
            Gx_mode = sMode21 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound21 = 0 ;
            InitializeNonKey0K21( ) ;
            sMode21 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode21 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0K21( ) ;
         if ( RcdFound21 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound21 = 0 ;
         /* Using cursor T000K12 */
         pr_default.execute(10, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T000K12_A6USU_COD[0], A6USU_COD) < 0 ) ) && ( T000K12_A116SIS_COD[0] == A116SIS_COD ) && ( T000K12_A126PRG_COD[0] == A126PRG_COD ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T000K12_A6USU_COD[0], A6USU_COD) > 0 ) ) && ( T000K12_A116SIS_COD[0] == A116SIS_COD ) && ( T000K12_A126PRG_COD[0] == A126PRG_COD ) )
            {
               A6USU_COD = T000K12_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               RcdFound21 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound21 = 0 ;
         /* Using cursor T000K13 */
         pr_default.execute(11, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T000K13_A6USU_COD[0], A6USU_COD) > 0 ) ) && ( T000K13_A116SIS_COD[0] == A116SIS_COD ) && ( T000K13_A126PRG_COD[0] == A126PRG_COD ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T000K13_A6USU_COD[0], A6USU_COD) < 0 ) ) && ( T000K13_A116SIS_COD[0] == A116SIS_COD ) && ( T000K13_A126PRG_COD[0] == A126PRG_COD ) )
            {
               A6USU_COD = T000K13_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               RcdFound21 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0K21( ) ;
         if ( RcdFound21 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) )
            {
               A6USU_COD = Z6USU_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0K21( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) )
            {
               /* Insert record */
               Insert0K21( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "USU_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0K21( ) ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) )
         {
            A6USU_COD = Z6USU_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_Check( )
      {
         nKeyPressed = 3 ;
         IsConfirmed = 0 ;
         GetKey0K21( ) ;
         if ( RcdFound21 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) )
            {
               A6USU_COD = Z6USU_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               update_Check( ) ;
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) )
            {
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "USU_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(11);
         pr_default.close(10);
         context.RollbackDataStores("TSEG004_U");
      }

      protected void insert_Check( )
      {
         CONFIRM_0K0( ) ;
         IsConfirmed = 0 ;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound21 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
         }
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0K21( ) ;
         if ( RcdFound21 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
         }
         ScanEnd0K21( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound21 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
         }
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound21 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
         }
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0K21( ) ;
         if ( RcdFound21 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound21 != 0 )
            {
               ScanNext0K21( ) ;
            }
         }
         ScanEnd0K21( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0K21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000K14 */
            pr_default.execute(12, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
            if ( (pr_default.getStatus(12) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG004"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(12) == 101) || ( StringUtil.StrCmp(Z290USU_CNT, T000K14_A290USU_CNT[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG004"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0K21( )
      {
         BeforeValidate0K21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K21( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0K21( 0) ;
            CheckOptimisticConcurrency0K21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0K21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000K15 */
                     pr_default.execute(13, new Object[] {A290USU_CNT, A6USU_COD, A116SIS_COD, A126PRG_COD});
                     pr_default.close(13);
                     if ( (pr_default.getStatus(13) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption0K0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load0K21( ) ;
            }
            EndLevel0K21( ) ;
         }
         CloseExtendedTableCursors0K21( ) ;
      }

      protected void Update0K21( )
      {
         BeforeValidate0K21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K21( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0K21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000K16 */
                     pr_default.execute(14, new Object[] {A290USU_CNT, A6USU_COD, A116SIS_COD, A126PRG_COD});
                     pr_default.close(14);
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG004"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0K21( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption0K0( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel0K21( ) ;
         }
         CloseExtendedTableCursors0K21( ) ;
      }

      protected void DeferredUpdate0K21( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0K21( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K21( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0K21( ) ;
            AfterConfirm0K21( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0K21( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000K17 */
                  pr_default.execute(15, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
                  pr_default.close(15);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound21 == 0 )
                        {
                           InitAll0K21( ) ;
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted"), 0, "");
                        ResetCaption0K0( ) ;
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode21 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0K21( ) ;
         Gx_mode = sMode21 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0K21( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000K18 */
            pr_default.execute(16, new Object[] {A6USU_COD});
            A7USU_DES = T000K18_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000K18_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            pr_default.close(16);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000K19 */
            pr_default.execute(17, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SESIONES POR USUARIO"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(17);
         }
      }

      protected void EndLevel0K21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0K21( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(11);
            pr_default.close(10);
            pr_default.close(16);
            context.CommitDataStores("TSEG004_U");
            if ( AnyError == 0 )
            {
               ConfirmValues0K0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(11);
            pr_default.close(10);
            pr_default.close(16);
            context.RollbackDataStores("TSEG004_U");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0K21( )
      {
         /* Using cursor T000K20 */
         pr_default.execute(18, new Object[] {A116SIS_COD, A126PRG_COD});
         RcdFound21 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound21 = 1 ;
            A6USU_COD = T000K20_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0K21( )
      {
         pr_default.readNext(18);
         RcdFound21 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound21 = 1 ;
            A6USU_COD = T000K20_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         }
      }

      protected void ScanEnd0K21( )
      {
      }

      protected void AfterConfirm0K21( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0K21( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0K21( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0K21( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0K21( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0K21( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0K0( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;margin: 0px;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg004_u.aspx") + "?" + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z6USU_COD", StringUtil.RTrim( Z6USU_COD));
         GxWebStd.gx_hidden_field( context, "Z116SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z116SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z126PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z126PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z290USU_CNT", StringUtil.RTrim( Z290USU_CNT));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV8USUARIO));
         GxWebStd.gx_hidden_field( context, "USU_CNT", StringUtil.RTrim( A290USU_CNT));
         GxWebStd.gx_hidden_field( context, "USU_CLA", StringUtil.RTrim( A155USU_CLA));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "TSEG004_U" ;
      }

      public override String GetPgmdesc( )
      {
         return "ACT. USUARIO/SIST./PROG." ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tseg004_u.aspx") + "?" + UrlEncode("" +A116SIS_COD) + "," + UrlEncode("" +A126PRG_COD) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) ;
      }

      protected void InitializeNonKey0K21( )
      {
         A7USU_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
         A155USU_CLA = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         A290USU_CNT = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
      }

      protected void InitAll0K21( )
      {
         A6USU_COD = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         InitializeNonKey0K21( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11194834");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tseg004_u.js", "?11194835");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtUSU_COD_Internalname = "USU_COD" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtUSU_DES_Internalname = "USU_DES" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtSIS_COD_Internalname = "SIS_COD" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtSIS_DES_Internalname = "SIS_DES" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtPRG_COD_Internalname = "PRG_COD" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtPRG_DES_Internalname = "PRG_DES" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtPRG_NFI_Internalname = "PRG_NFI" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_6_Internalname = "PROMPT_6" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "ACT. USUARIO/SIST./PROG." ;
         edtPRG_NFI_Jsonclick = "" ;
         edtPRG_NFI_Enabled = 0 ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_DES_Enabled = 0 ;
         bttBtn_get_Enabled = 1 ;
         bttBtn_get_Visible = 1 ;
         edtPRG_COD_Jsonclick = "" ;
         edtPRG_COD_Enabled = 0 ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_DES_Enabled = 0 ;
         edtSIS_COD_Jsonclick = "" ;
         edtSIS_COD_Enabled = 0 ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_DES_Enabled = 0 ;
         imgprompt_6_Visible = 1 ;
         imgprompt_6_Link = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtUSU_COD_Enabled = 1 ;
         bttBtn_help_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_check_Enabled = 1 ;
         bttBtn_check_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Valid_Usu_cod( String GX_Parm1 ,
                                 short GX_Parm2 ,
                                 String GX_Parm3 ,
                                 String GX_Parm4 )
      {
         A6USU_COD = GX_Parm1 ;
         A116SIS_COD = GX_Parm2 ;
         A7USU_DES = GX_Parm3 ;
         A155USU_CLA = GX_Parm4 ;
         /* Using cursor T000K18 */
         pr_default.execute(16, new Object[] {A6USU_COD});
         if ( AnyError == 0 )
         {
            A7USU_DES = T000K18_A7USU_DES[0] ;
            A155USU_CLA = T000K18_A155USU_CLA[0] ;
         }
         pr_default.close(16);
         /* Using cursor T000K21 */
         pr_default.execute(19, new Object[] {A6USU_COD, A116SIS_COD});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG003'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(19);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A6USU_COD)) )
         {
            GX_msglist.addItem("Usuario NO debe ser NULO", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A7USU_DES = "" ;
            A155USU_CLA = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A7USU_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A155USU_CLA)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(18);
         pr_default.close(11);
         pr_default.close(10);
         pr_default.close(16);
         pr_default.close(19);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOAV7SISTEMA = "" ;
         wcpOAV8USUARIO = "" ;
         wcpOGx_mode = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A6USU_COD = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_check_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_help_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         A7USU_DES = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         A259SIS_DES = "" ;
         lblTextblock6_Jsonclick = "" ;
         bttBtn_get_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         A127PRG_DES = "" ;
         lblTextblock8_Jsonclick = "" ;
         A289PRG_NFI = "" ;
         Z6USU_COD = "" ;
         Z290USU_CNT = "" ;
         A290USU_CNT = "" ;
         A155USU_CLA = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z259SIS_DES = "" ;
         Z127PRG_DES = "" ;
         Z289PRG_NFI = "" ;
         Z7USU_DES = "" ;
         Z155USU_CLA = "" ;
         T000K5_A259SIS_DES = new String[] {""} ;
         T000K7_A127PRG_DES = new String[] {""} ;
         T000K7_A289PRG_NFI = new String[] {""} ;
         T000K8_A7USU_DES = new String[] {""} ;
         T000K8_A155USU_CLA = new String[] {""} ;
         T000K8_A259SIS_DES = new String[] {""} ;
         T000K8_A127PRG_DES = new String[] {""} ;
         T000K8_A289PRG_NFI = new String[] {""} ;
         T000K8_A290USU_CNT = new String[] {""} ;
         T000K8_A6USU_COD = new String[] {""} ;
         T000K8_A116SIS_COD = new short[1] ;
         T000K8_A126PRG_COD = new short[1] ;
         T000K4_A7USU_DES = new String[] {""} ;
         T000K4_A155USU_CLA = new String[] {""} ;
         T000K6_A6USU_COD = new String[] {""} ;
         T000K9_A7USU_DES = new String[] {""} ;
         T000K9_A155USU_CLA = new String[] {""} ;
         T000K10_A6USU_COD = new String[] {""} ;
         T000K11_A6USU_COD = new String[] {""} ;
         T000K11_A116SIS_COD = new short[1] ;
         T000K11_A126PRG_COD = new short[1] ;
         T000K3_A290USU_CNT = new String[] {""} ;
         T000K3_A6USU_COD = new String[] {""} ;
         T000K3_A116SIS_COD = new short[1] ;
         T000K3_A126PRG_COD = new short[1] ;
         sMode21 = "" ;
         T000K12_A6USU_COD = new String[] {""} ;
         T000K12_A116SIS_COD = new short[1] ;
         T000K12_A126PRG_COD = new short[1] ;
         T000K13_A6USU_COD = new String[] {""} ;
         T000K13_A116SIS_COD = new short[1] ;
         T000K13_A126PRG_COD = new short[1] ;
         T000K14_A290USU_CNT = new String[] {""} ;
         T000K14_A6USU_COD = new String[] {""} ;
         T000K14_A116SIS_COD = new short[1] ;
         T000K14_A126PRG_COD = new short[1] ;
         T000K18_A7USU_DES = new String[] {""} ;
         T000K18_A155USU_CLA = new String[] {""} ;
         T000K19_A6USU_COD = new String[] {""} ;
         T000K19_A116SIS_COD = new short[1] ;
         T000K19_A126PRG_COD = new short[1] ;
         T000K19_A118PRS_NRO = new int[1] ;
         T000K20_A6USU_COD = new String[] {""} ;
         T000K20_A116SIS_COD = new short[1] ;
         T000K20_A126PRG_COD = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
         T000K21_A6USU_COD = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg004_u__default(),
            new Object[][] {
                new Object[] {
               T000K2_A290USU_CNT, T000K2_A6USU_COD, T000K2_A116SIS_COD, T000K2_A126PRG_COD
               }
               , new Object[] {
               T000K3_A290USU_CNT, T000K3_A6USU_COD, T000K3_A116SIS_COD, T000K3_A126PRG_COD
               }
               , new Object[] {
               T000K4_A7USU_DES, T000K4_A155USU_CLA
               }
               , new Object[] {
               T000K5_A259SIS_DES
               }
               , new Object[] {
               T000K6_A6USU_COD
               }
               , new Object[] {
               T000K7_A127PRG_DES, T000K7_A289PRG_NFI
               }
               , new Object[] {
               T000K8_A7USU_DES, T000K8_A155USU_CLA, T000K8_A259SIS_DES, T000K8_A127PRG_DES, T000K8_A289PRG_NFI, T000K8_A290USU_CNT, T000K8_A6USU_COD, T000K8_A116SIS_COD, T000K8_A126PRG_COD
               }
               , new Object[] {
               T000K9_A7USU_DES, T000K9_A155USU_CLA
               }
               , new Object[] {
               T000K10_A6USU_COD
               }
               , new Object[] {
               T000K11_A6USU_COD, T000K11_A116SIS_COD, T000K11_A126PRG_COD
               }
               , new Object[] {
               T000K12_A6USU_COD, T000K12_A116SIS_COD, T000K12_A126PRG_COD
               }
               , new Object[] {
               T000K13_A6USU_COD, T000K13_A116SIS_COD, T000K13_A126PRG_COD
               }
               , new Object[] {
               T000K14_A290USU_CNT, T000K14_A6USU_COD, T000K14_A116SIS_COD, T000K14_A126PRG_COD
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000K18_A7USU_DES, T000K18_A155USU_CLA
               }
               , new Object[] {
               T000K19_A6USU_COD, T000K19_A116SIS_COD, T000K19_A126PRG_COD, T000K19_A118PRS_NRO
               }
               , new Object[] {
               T000K20_A6USU_COD, T000K20_A116SIS_COD, T000K20_A126PRG_COD
               }
               , new Object[] {
               T000K21_A6USU_COD
               }
            }
         );
         Z126PRG_COD = 0 ;
         Z116SIS_COD = 0 ;
      }

      private short wcpOA116SIS_COD ;
      private short wcpOA126PRG_COD ;
      private short GxWebError ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z116SIS_COD ;
      private short Z126PRG_COD ;
      private short GX_JID ;
      private short RcdFound21 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_check_Visible ;
      private int bttBtn_check_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_help_Visible ;
      private int edtUSU_COD_Enabled ;
      private int imgprompt_6_Visible ;
      private int edtUSU_DES_Enabled ;
      private int edtSIS_COD_Enabled ;
      private int edtSIS_DES_Enabled ;
      private int edtPRG_COD_Enabled ;
      private int bttBtn_get_Visible ;
      private int bttBtn_get_Enabled ;
      private int edtPRG_DES_Enabled ;
      private int edtPRG_NFI_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV8USUARIO ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A6USU_COD ;
      private String AV7SISTEMA ;
      private String AV8USUARIO ;
      private String Gx_mode ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUSU_COD_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String tblTable3_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_check_Internalname ;
      private String bttBtn_check_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_help_Internalname ;
      private String bttBtn_help_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtUSU_COD_Jsonclick ;
      private String imgprompt_6_Internalname ;
      private String imgprompt_6_Link ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtUSU_DES_Internalname ;
      private String A7USU_DES ;
      private String edtUSU_DES_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_COD_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtSIS_DES_Internalname ;
      private String A259SIS_DES ;
      private String edtSIS_DES_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_COD_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtPRG_DES_Internalname ;
      private String A127PRG_DES ;
      private String edtPRG_DES_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtPRG_NFI_Internalname ;
      private String A289PRG_NFI ;
      private String edtPRG_NFI_Jsonclick ;
      private String Z6USU_COD ;
      private String Z290USU_CNT ;
      private String A290USU_CNT ;
      private String A155USU_CLA ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z259SIS_DES ;
      private String Z127PRG_DES ;
      private String Z289PRG_NFI ;
      private String Z7USU_DES ;
      private String Z155USU_CLA ;
      private String sMode21 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private short aP0_SIS_COD ;
      private short aP1_PRG_COD ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private String aP4_Gx_mode ;
      private IDataStoreProvider pr_default ;
      private String[] T000K5_A259SIS_DES ;
      private String[] T000K7_A127PRG_DES ;
      private String[] T000K7_A289PRG_NFI ;
      private String[] T000K8_A7USU_DES ;
      private String[] T000K8_A155USU_CLA ;
      private String[] T000K8_A259SIS_DES ;
      private String[] T000K8_A127PRG_DES ;
      private String[] T000K8_A289PRG_NFI ;
      private String[] T000K8_A290USU_CNT ;
      private String[] T000K8_A6USU_COD ;
      private short[] T000K8_A116SIS_COD ;
      private short[] T000K8_A126PRG_COD ;
      private String[] T000K4_A7USU_DES ;
      private String[] T000K4_A155USU_CLA ;
      private String[] T000K6_A6USU_COD ;
      private String[] T000K9_A7USU_DES ;
      private String[] T000K9_A155USU_CLA ;
      private String[] T000K10_A6USU_COD ;
      private String[] T000K11_A6USU_COD ;
      private short[] T000K11_A116SIS_COD ;
      private short[] T000K11_A126PRG_COD ;
      private String[] T000K3_A290USU_CNT ;
      private String[] T000K3_A6USU_COD ;
      private short[] T000K3_A116SIS_COD ;
      private short[] T000K3_A126PRG_COD ;
      private String[] T000K12_A6USU_COD ;
      private short[] T000K12_A116SIS_COD ;
      private short[] T000K12_A126PRG_COD ;
      private String[] T000K13_A6USU_COD ;
      private short[] T000K13_A116SIS_COD ;
      private short[] T000K13_A126PRG_COD ;
      private String[] T000K14_A290USU_CNT ;
      private String[] T000K14_A6USU_COD ;
      private short[] T000K14_A116SIS_COD ;
      private short[] T000K14_A126PRG_COD ;
      private String[] T000K18_A7USU_DES ;
      private String[] T000K18_A155USU_CLA ;
      private String[] T000K19_A6USU_COD ;
      private short[] T000K19_A116SIS_COD ;
      private short[] T000K19_A126PRG_COD ;
      private int[] T000K19_A118PRS_NRO ;
      private String[] T000K20_A6USU_COD ;
      private short[] T000K20_A116SIS_COD ;
      private short[] T000K20_A126PRG_COD ;
      private String[] T000K21_A6USU_COD ;
      private String[] T000K2_A290USU_CNT ;
      private String[] T000K2_A6USU_COD ;
      private short[] T000K2_A116SIS_COD ;
      private short[] T000K2_A126PRG_COD ;
      private GXWebForm Form ;
   }

   public class tseg004_u__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000K2 ;
          prmT000K2 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K5 ;
          prmT000K5 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000K7 ;
          prmT000K7 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K8 ;
          prmT000K8 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K4 ;
          prmT000K4 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000K6 ;
          prmT000K6 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000K9 ;
          prmT000K9 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000K10 ;
          prmT000K10 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000K11 ;
          prmT000K11 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K3 ;
          prmT000K3 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K12 ;
          prmT000K12 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K13 ;
          prmT000K13 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K14 ;
          prmT000K14 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K15 ;
          prmT000K15 = new Object[] {
          new Object[] {"@USU_CNT",SqlDbType.Char,1,0} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K16 ;
          prmT000K16 = new Object[] {
          new Object[] {"@USU_CNT",SqlDbType.Char,1,0} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K17 ;
          prmT000K17 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K19 ;
          prmT000K19 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K20 ;
          prmT000K20 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000K18 ;
          prmT000K18 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000K21 ;
          prmT000K21 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000K2", "SELECT [USU_CNT], [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG004] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K2,1,1,true,false )
             ,new CursorDef("T000K3", "SELECT [USU_CNT], [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K3,1,1,true,false )
             ,new CursorDef("T000K4", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K4,1,0,true,false )
             ,new CursorDef("T000K5", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K5,1,1,true,false )
             ,new CursorDef("T000K6", "SELECT [USU_COD] FROM [SEG003] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K6,1,1,true,false )
             ,new CursorDef("T000K7", "SELECT [PRG_DES], [PRG_NFI] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K7,1,1,true,false )
             ,new CursorDef("T000K8", "SELECT T4.[USU_DES], T4.[USU_CLA], T2.[SIS_DES], T3.[PRG_DES], T3.[PRG_NFI], TM1.[USU_CNT], TM1.[USU_COD], TM1.[SIS_COD], TM1.[PRG_COD] FROM ((([SEG004] TM1 WITH (NOLOCK) INNER JOIN [SEG000] T2 WITH (NOLOCK) ON T2.[SIS_COD] = TM1.[SIS_COD]) INNER JOIN [SEG001] T3 WITH (NOLOCK) ON T3.[PRG_COD] = TM1.[PRG_COD]) INNER JOIN [SEG002] T4 WITH (NOLOCK) ON T4.[USU_COD] = TM1.[USU_COD]) WHERE TM1.[USU_COD] = @USU_COD and TM1.[SIS_COD] = @SIS_COD and TM1.[PRG_COD] = @PRG_COD ORDER BY TM1.[USU_COD], TM1.[SIS_COD], TM1.[PRG_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K8,100,0,true,false )
             ,new CursorDef("T000K9", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K9,1,0,true,false )
             ,new CursorDef("T000K10", "SELECT [USU_COD] FROM [SEG003] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K10,1,1,true,false )
             ,new CursorDef("T000K11", "SELECT [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K11,1,1,true,false )
             ,new CursorDef("T000K12", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG004] WITH (NOLOCK) WHERE ( [USU_COD] > @USU_COD) and [SIS_COD] = @SIS_COD and [PRG_COD] = @PRG_COD ORDER BY [USU_COD], [SIS_COD], [PRG_COD]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K12,1,1,true,true )
             ,new CursorDef("T000K13", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG004] WITH (NOLOCK) WHERE ( [USU_COD] < @USU_COD) and [SIS_COD] = @SIS_COD and [PRG_COD] = @PRG_COD ORDER BY [USU_COD] DESC, [SIS_COD] DESC, [PRG_COD] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K13,1,1,true,true )
             ,new CursorDef("T000K14", "SELECT [USU_CNT], [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG004] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K14,1,1,true,false )
             ,new CursorDef("T000K15", "INSERT INTO [SEG004] ([USU_CNT], [USU_COD], [SIS_COD], [PRG_COD]) VALUES (@USU_CNT, @USU_COD, @SIS_COD, @PRG_COD)", GxErrorMask.GX_NOMASK,prmT000K15)
             ,new CursorDef("T000K16", "UPDATE [SEG004] SET [USU_CNT]=@USU_CNT  WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD", GxErrorMask.GX_NOMASK,prmT000K16)
             ,new CursorDef("T000K17", "DELETE FROM [SEG004]  WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD", GxErrorMask.GX_NOMASK,prmT000K17)
             ,new CursorDef("T000K18", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K18,1,0,true,false )
             ,new CursorDef("T000K19", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] FROM [SEG006] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K19,1,1,true,true )
             ,new CursorDef("T000K20", "SELECT [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG004] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD and [PRG_COD] = @PRG_COD ORDER BY [USU_COD], [SIS_COD], [PRG_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000K20,100,1,true,false )
             ,new CursorDef("T000K21", "SELECT [USU_COD] FROM [SEG003] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000K21,1,1,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 8) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 1) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 16) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
