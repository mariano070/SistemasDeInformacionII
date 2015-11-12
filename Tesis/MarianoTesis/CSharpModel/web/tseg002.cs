/*
               File: TSEG002
        Description: ACT. USUARIOS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:30:1.32
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
   public class tseg002 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            AV7USUCOD = gxfirstwebparm ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USUCOD", AV7USUCOD);
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV9SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISTEMA", AV9SISTEMA);
               AV8USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            GxWebError = 1 ;
            context.HttpContext.Response.StatusDescription = 403.ToString();
            context.WriteHtmlText( "<title>403 Forbidden</title>") ;
            context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
            context.WriteHtmlText( "<p /><hr />") ;
         }
         if ( ( GxWebError == 0 ) && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXDecQS = Crypto.Decrypt64( context.GetRequestQueryString( ), GXKey) ;
            if ( StringUtil.StrCmp(StringUtil.Right( GXDecQS, 6), Crypto.CheckSum( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), 6)) == 0 )
            {
               SetQueryString( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6))) ;
            }
            else
            {
               GxWebError = 1 ;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
            }
         }
         if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            if ( ! entryPointCalled )
            {
               AV7USUCOD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USUCOD", AV7USUCOD);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  Gx_mode = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  AV9SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISTEMA", AV9SISTEMA);
                  AV8USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
               }
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "ACT. USUARIOS", 0) ;
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

      public tseg002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg002( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUCOD ,
                           ref String aP1_Gx_mode ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV7USUCOD = aP0_USUCOD;
         this.Gx_mode = aP1_Gx_mode;
         this.AV9SISTEMA = aP2_SISTEMA;
         this.AV8USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_USUCOD=this.AV7USUCOD;
         aP1_Gx_mode=this.Gx_mode;
         aP2_SISTEMA=this.AV9SISTEMA;
         aP3_USUARIO=this.AV8USUARIO;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            wb_table1_2_0F15( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0F15e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0F15( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0F15( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0F15e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+""+"</legend>") ;
            wb_table3_9_0F15( true) ;
         }
         return  ;
      }

      protected void wb_table3_9_0F15e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0F15e( true) ;
         }
         else
         {
            wb_table1_2_0F15e( false) ;
         }
      }

      protected void wb_table3_9_0F15( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_15_0F15( true) ;
         }
         return  ;
      }

      protected void wb_table4_15_0F15e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TSEG002.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TSEG002.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_9_0F15e( true) ;
         }
         else
         {
            wb_table3_9_0F15e( false) ;
         }
      }

      protected void wb_table4_15_0F15( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockusu_cod_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, 1, edtUSU_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(20);\"", 0, edtUSU_COD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockusu_des_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, edtUSU_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(25);\"", 0, edtUSU_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:21px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_cla_Internalname, 1, 1, 0, "CONTRASEÑA", "", "", "", 0, lblTextblockusu_cla_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CLA_Internalname, StringUtil.RTrim( A155USU_CLA), "", 20, "chr", 1, "row", 20, 1, edtUSU_CLA_Enabled, 0, edtUSU_CLA_Ispassword, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A155USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(30);\"", 0, edtUSU_CLA_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:21px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_int_Internalname, 1, 1, 0, "NRO. TELEFONO INTERNO", "", "", "", 0, lblTextblockusu_int_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_INT_Internalname, StringUtil.RTrim( A180USU_INT), "", 10, "chr", 1, "row", 10, 1, edtUSU_INT_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A180USU_INT, "XXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(35);\"", 0, edtUSU_INT_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusu_maiw_Internalname, 1, 1, 0, "MAIL:", "", "", "", 0, lblTextblockusu_maiw_Jsonclick, "", StyleString, ClassString, "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtUSU_MAIW_Internalname, StringUtil.RTrim( A249USU_MAIW), 1, edtUSU_MAIW_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(40);\"", -1, 0, "", "", true, "HLP_TSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_15_0F15e( true) ;
         }
         else
         {
            wb_table4_15_0F15e( false) ;
         }
      }

      protected void wb_table2_5_0F15( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\"/>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_0F15e( true) ;
         }
         else
         {
            wb_table2_5_0F15e( false) ;
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
         /* Execute user event: E110F2 */
         E110F2 ();
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
               A155USU_CLA = cgiGet( edtUSU_CLA_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
               A180USU_INT = cgiGet( edtUSU_INT_Internalname) ;
               n180USU_INT = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180USU_INT", A180USU_INT);
               n180USU_INT = (String.IsNullOrEmpty(StringUtil.RTrim( A180USU_INT)) ? true : false) ;
               A249USU_MAIW = cgiGet( edtUSU_MAIW_Internalname) ;
               n249USU_MAIW = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249USU_MAIW", A249USU_MAIW);
               n249USU_MAIW = (String.IsNullOrEmpty(StringUtil.RTrim( A249USU_MAIW)) ? true : false) ;
               /* Read saved values. */
               Z6USU_COD = cgiGet( "Z6USU_COD") ;
               Z7USU_DES = cgiGet( "Z7USU_DES") ;
               Z155USU_CLA = cgiGet( "Z155USU_CLA") ;
               Z180USU_INT = cgiGet( "Z180USU_INT") ;
               Z249USU_MAIW = cgiGet( "Z249USU_MAIW") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV9SISTEMA = cgiGet( "vSISTEMA") ;
               AV8USUARIO = cgiGet( "vUSUARIO") ;
               AV7USUCOD = cgiGet( "vUSUCOD") ;
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
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode15 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode15 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound15 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0F0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "USU_COD");
                        AnyError = 1 ;
                     }
                  }
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
                           /* Execute user event: E110F2 */
                           E110F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120F2 */
                           E120F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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
            /* Execute user event: E120F2 */
            E120F2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0F15( ) ;
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
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
            edtUSU_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_DES_Enabled), 5, 0)));
            edtUSU_CLA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_CLA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_CLA_Enabled), 5, 0)));
            edtUSU_INT_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_INT_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_INT_Enabled), 5, 0)));
            edtUSU_MAIW_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_MAIW_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_MAIW_Enabled), 5, 0)));
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

      protected void CONFIRM_0F0( )
      {
         BeforeValidate0F15( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0F15( ) ;
            }
            else
            {
               CheckExtendedTable0F15( ) ;
               CloseExtendedTableCursors0F15( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0F0( )
      {
      }

      protected void E110F2( )
      {
         /* Start Routine */
         edtUSU_CLA_Ispassword = 1 ;
      }

      protected void E120F2( )
      {
         /* After Trn Routine */
         new ptbusseg5(context ).execute( ref  A6USU_COD, ref  Gx_mode) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void ZM0F15( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z7USU_DES = T000F3_A7USU_DES[0] ;
               Z155USU_CLA = T000F3_A155USU_CLA[0] ;
               Z180USU_INT = T000F3_A180USU_INT[0] ;
               Z249USU_MAIW = T000F3_A249USU_MAIW[0] ;
            }
            else
            {
               Z7USU_DES = A7USU_DES ;
               Z155USU_CLA = A155USU_CLA ;
               Z180USU_INT = A180USU_INT ;
               Z249USU_MAIW = A249USU_MAIW ;
            }
         }
         if ( GX_JID == -7 )
         {
            Z6USU_COD = A6USU_COD ;
            Z7USU_DES = A7USU_DES ;
            Z155USU_CLA = A155USU_CLA ;
            Z180USU_INT = A180USU_INT ;
            Z249USU_MAIW = A249USU_MAIW ;
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
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A6USU_COD = AV7USUCOD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         }
      }

      protected void standaloneModal( )
      {
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load0F15( )
      {
         /* Using cursor T000F4 */
         pr_default.execute(2, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound15 = 1 ;
            A7USU_DES = T000F4_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000F4_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            A180USU_INT = T000F4_A180USU_INT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180USU_INT", A180USU_INT);
            n180USU_INT = T000F4_n180USU_INT[0] ;
            A249USU_MAIW = T000F4_A249USU_MAIW[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249USU_MAIW", A249USU_MAIW);
            n249USU_MAIW = T000F4_n249USU_MAIW[0] ;
            ZM0F15( -7) ;
         }
         pr_default.close(2);
         OnLoadActions0F15( ) ;
      }

      protected void OnLoadActions0F15( )
      {
      }

      protected void CheckExtendedTable0F15( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( StringUtil.StrCmp(StringUtil.Trim( A6USU_COD), "") == 0 )
         {
            GX_msglist.addItem("DEBE CARGAR UN CÓDIGO DE USUARIO.", 1, "");
            AnyError = 1 ;
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( A7USU_DES), "") == 0 )
         {
            GX_msglist.addItem("DEBE CARGAR UNA DESCRIPCIÓN DE USUARIO.", 1, "");
            AnyError = 1 ;
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( A155USU_CLA), "") == 0 )
         {
            GX_msglist.addItem("DEBE INGRESAR UNA CONTRASEÑA.", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0F15( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0F15( )
      {
         /* Using cursor T000F5 */
         pr_default.execute(3, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound15 = 1 ;
         }
         else
         {
            RcdFound15 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000F3 */
         pr_default.execute(1, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0F15( 7) ;
            RcdFound15 = 1 ;
            A6USU_COD = T000F3_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = T000F3_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T000F3_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            A180USU_INT = T000F3_A180USU_INT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180USU_INT", A180USU_INT);
            n180USU_INT = T000F3_n180USU_INT[0] ;
            A249USU_MAIW = T000F3_A249USU_MAIW[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249USU_MAIW", A249USU_MAIW);
            n249USU_MAIW = T000F3_n249USU_MAIW[0] ;
            Z6USU_COD = A6USU_COD ;
            sMode15 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0F15( ) ;
            Gx_mode = sMode15 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound15 = 0 ;
            InitializeNonKey0F15( ) ;
            sMode15 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode15 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0F15( ) ;
         if ( RcdFound15 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound15 = 0 ;
         /* Using cursor T000F6 */
         pr_default.execute(4, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000F6_A6USU_COD[0], A6USU_COD) < 0 ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000F6_A6USU_COD[0], A6USU_COD) > 0 ) ) )
            {
               A6USU_COD = T000F6_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               RcdFound15 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound15 = 0 ;
         /* Using cursor T000F7 */
         pr_default.execute(5, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000F7_A6USU_COD[0], A6USU_COD) > 0 ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000F7_A6USU_COD[0], A6USU_COD) < 0 ) ) )
            {
               A6USU_COD = T000F7_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               RcdFound15 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0F15( ) ;
         if ( RcdFound15 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 )
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
               Update0F15( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 )
            {
               /* Insert record */
               Insert0F15( ) ;
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
                  Insert0F15( ) ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 )
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
      }

      protected void CheckOptimisticConcurrency0F15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000F8 */
            pr_default.execute(6, new Object[] {A6USU_COD});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG002"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z7USU_DES, T000F8_A7USU_DES[0]) != 0 ) || ( StringUtil.StrCmp(Z155USU_CLA, T000F8_A155USU_CLA[0]) != 0 ) || ( StringUtil.StrCmp(Z180USU_INT, T000F8_A180USU_INT[0]) != 0 ) || ( StringUtil.StrCmp(Z249USU_MAIW, T000F8_A249USU_MAIW[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG002"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0F15( )
      {
         BeforeValidate0F15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F15( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0F15( 0) ;
            CheckOptimisticConcurrency0F15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0F15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F9 */
                     pr_default.execute(7, new Object[] {A6USU_COD, A7USU_DES, A155USU_CLA, n180USU_INT, A180USU_INT, n249USU_MAIW, A249USU_MAIW});
                     pr_default.close(7);
                     if ( (pr_default.getStatus(7) == 1) )
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
                           ResetCaption0F0( ) ;
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
               Load0F15( ) ;
            }
            EndLevel0F15( ) ;
         }
         CloseExtendedTableCursors0F15( ) ;
      }

      protected void Update0F15( )
      {
         BeforeValidate0F15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F15( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0F15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F10 */
                     pr_default.execute(8, new Object[] {A7USU_DES, A155USU_CLA, n180USU_INT, A180USU_INT, n249USU_MAIW, A249USU_MAIW, A6USU_COD});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG002"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0F15( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
                              }
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
            }
            EndLevel0F15( ) ;
         }
         CloseExtendedTableCursors0F15( ) ;
      }

      protected void DeferredUpdate0F15( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0F15( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F15( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0F15( ) ;
            AfterConfirm0F15( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0F15( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000F11 */
                  pr_default.execute(9, new Object[] {A6USU_COD});
                  pr_default.close(9);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1 ;
                           }
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
         }
         sMode15 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0F15( ) ;
         Gx_mode = sMode15 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0F15( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000F12 */
            pr_default.execute(10, new Object[] {A6USU_COD});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Maestro de Administradores del Sistema"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(10);
            /* Using cursor T000F13 */
            pr_default.execute(11, new Object[] {A6USU_COD});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Maestro de Permisos a Posiciones"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(11);
            /* Using cursor T000F14 */
            pr_default.execute(12, new Object[] {A6USU_COD});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Maestro de Responsables de Posiciones"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel0F15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0F15( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TSEG002");
            if ( AnyError == 0 )
            {
               ConfirmValues0F0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TSEG002");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0F15( )
      {
         /* Using cursor T000F15 */
         pr_default.execute(13);
         RcdFound15 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound15 = 1 ;
            A6USU_COD = T000F15_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0F15( )
      {
         pr_default.readNext(13);
         RcdFound15 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound15 = 1 ;
            A6USU_COD = T000F15_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         }
      }

      protected void ScanEnd0F15( )
      {
      }

      protected void AfterConfirm0F15( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0F15( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0F15( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0F15( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0F15( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0F15( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0F0( )
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
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV7USUCOD)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV9SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg002.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z6USU_COD", StringUtil.RTrim( Z6USU_COD));
         GxWebStd.gx_hidden_field( context, "Z7USU_DES", StringUtil.RTrim( Z7USU_DES));
         GxWebStd.gx_hidden_field( context, "Z155USU_CLA", StringUtil.RTrim( Z155USU_CLA));
         GxWebStd.gx_hidden_field( context, "Z180USU_INT", StringUtil.RTrim( Z180USU_INT));
         GxWebStd.gx_hidden_field( context, "Z249USU_MAIW", StringUtil.RTrim( Z249USU_MAIW));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV9SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV8USUARIO));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV7USUCOD));
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
         return "TSEG002" ;
      }

      public override String GetPgmdesc( )
      {
         return "ACT. USUARIOS" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV7USUCOD)) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV9SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
         return formatLink("tseg002.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void InitializeNonKey0F15( )
      {
         A7USU_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
         A155USU_CLA = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         A180USU_INT = "" ;
         n180USU_INT = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180USU_INT", A180USU_INT);
         n180USU_INT = (String.IsNullOrEmpty(StringUtil.RTrim( A180USU_INT)) ? true : false) ;
         A249USU_MAIW = "" ;
         n249USU_MAIW = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249USU_MAIW", A249USU_MAIW);
         n249USU_MAIW = (String.IsNullOrEmpty(StringUtil.RTrim( A249USU_MAIW)) ? true : false) ;
      }

      protected void InitAll0F15( )
      {
         A6USU_COD = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         InitializeNonKey0F15( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1930188");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tseg002.js", "?1930188");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockusu_cod_Internalname = "TEXTBLOCKUSU_COD" ;
         edtUSU_COD_Internalname = "USU_COD" ;
         lblTextblockusu_des_Internalname = "TEXTBLOCKUSU_DES" ;
         edtUSU_DES_Internalname = "USU_DES" ;
         lblTextblockusu_cla_Internalname = "TEXTBLOCKUSU_CLA" ;
         edtUSU_CLA_Internalname = "USU_CLA" ;
         lblTextblockusu_int_Internalname = "TEXTBLOCKUSU_INT" ;
         edtUSU_INT_Internalname = "USU_INT" ;
         lblTextblockusu_maiw_Internalname = "TEXTBLOCKUSU_MAIW" ;
         edtUSU_MAIW_Internalname = "USU_MAIW" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "ACT. USUARIOS" ;
         edtUSU_MAIW_Enabled = 1 ;
         edtUSU_INT_Jsonclick = "" ;
         edtUSU_INT_Enabled = 1 ;
         edtUSU_CLA_Jsonclick = "" ;
         edtUSU_CLA_Ispassword = -1 ;
         edtUSU_CLA_Enabled = 1 ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_DES_Enabled = 1 ;
         edtUSU_COD_Jsonclick = "" ;
         edtUSU_COD_Enabled = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
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
         pr_default.close(13);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOAV7USUCOD = "" ;
         wcpOGx_mode = "" ;
         wcpOAV9SISTEMA = "" ;
         wcpOAV8USUARIO = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXKey = "" ;
         GXDecQS = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockusu_cod_Jsonclick = "" ;
         A6USU_COD = "" ;
         lblTextblockusu_des_Jsonclick = "" ;
         A7USU_DES = "" ;
         lblTextblockusu_cla_Jsonclick = "" ;
         A155USU_CLA = "" ;
         lblTextblockusu_int_Jsonclick = "" ;
         A180USU_INT = "" ;
         lblTextblockusu_maiw_Jsonclick = "" ;
         A249USU_MAIW = "" ;
         Z6USU_COD = "" ;
         Z7USU_DES = "" ;
         Z155USU_CLA = "" ;
         Z180USU_INT = "" ;
         Z249USU_MAIW = "" ;
         sMode15 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T000F4_A6USU_COD = new String[] {""} ;
         T000F4_A7USU_DES = new String[] {""} ;
         T000F4_A155USU_CLA = new String[] {""} ;
         T000F4_A180USU_INT = new String[] {""} ;
         T000F4_n180USU_INT = new bool[] {false} ;
         T000F4_A249USU_MAIW = new String[] {""} ;
         T000F4_n249USU_MAIW = new bool[] {false} ;
         T000F5_A6USU_COD = new String[] {""} ;
         T000F3_A6USU_COD = new String[] {""} ;
         T000F3_A7USU_DES = new String[] {""} ;
         T000F3_A155USU_CLA = new String[] {""} ;
         T000F3_A180USU_INT = new String[] {""} ;
         T000F3_n180USU_INT = new bool[] {false} ;
         T000F3_A249USU_MAIW = new String[] {""} ;
         T000F3_n249USU_MAIW = new bool[] {false} ;
         T000F6_A6USU_COD = new String[] {""} ;
         T000F7_A6USU_COD = new String[] {""} ;
         T000F8_A6USU_COD = new String[] {""} ;
         T000F8_A7USU_DES = new String[] {""} ;
         T000F8_A155USU_CLA = new String[] {""} ;
         T000F8_A180USU_INT = new String[] {""} ;
         T000F8_n180USU_INT = new bool[] {false} ;
         T000F8_A249USU_MAIW = new String[] {""} ;
         T000F8_n249USU_MAIW = new bool[] {false} ;
         T000F12_A40TTBUS8_CodUsuario = new String[] {""} ;
         T000F13_A33TTBUS7_Pos = new short[1] ;
         T000F13_A39TTBUS7_CodUsuario = new String[] {""} ;
         T000F14_A33TTBUS7_Pos = new short[1] ;
         T000F15_A6USU_COD = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXEncryptionTmp = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg002__default(),
            new Object[][] {
                new Object[] {
               T000F2_A6USU_COD, T000F2_A7USU_DES, T000F2_A155USU_CLA, T000F2_A180USU_INT, T000F2_n180USU_INT, T000F2_A249USU_MAIW, T000F2_n249USU_MAIW
               }
               , new Object[] {
               T000F3_A6USU_COD, T000F3_A7USU_DES, T000F3_A155USU_CLA, T000F3_A180USU_INT, T000F3_n180USU_INT, T000F3_A249USU_MAIW, T000F3_n249USU_MAIW
               }
               , new Object[] {
               T000F4_A6USU_COD, T000F4_A7USU_DES, T000F4_A155USU_CLA, T000F4_A180USU_INT, T000F4_n180USU_INT, T000F4_A249USU_MAIW, T000F4_n249USU_MAIW
               }
               , new Object[] {
               T000F5_A6USU_COD
               }
               , new Object[] {
               T000F6_A6USU_COD
               }
               , new Object[] {
               T000F7_A6USU_COD
               }
               , new Object[] {
               T000F8_A6USU_COD, T000F8_A7USU_DES, T000F8_A155USU_CLA, T000F8_A180USU_INT, T000F8_n180USU_INT, T000F8_A249USU_MAIW, T000F8_n249USU_MAIW
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000F12_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               T000F13_A33TTBUS7_Pos, T000F13_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T000F14_A33TTBUS7_Pos
               }
               , new Object[] {
               T000F15_A6USU_COD
               }
            }
         );
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short edtUSU_CLA_Ispassword ;
      private short RcdFound15 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtUSU_COD_Enabled ;
      private int edtUSU_DES_Enabled ;
      private int edtUSU_CLA_Enabled ;
      private int edtUSU_INT_Enabled ;
      private int edtUSU_MAIW_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOAV7USUCOD ;
      private String wcpOGx_mode ;
      private String wcpOAV9SISTEMA ;
      private String wcpOAV8USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String AV7USUCOD ;
      private String Gx_mode ;
      private String AV9SISTEMA ;
      private String AV8USUARIO ;
      private String GXKey ;
      private String GXDecQS ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUSU_COD_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockusu_cod_Internalname ;
      private String lblTextblockusu_cod_Jsonclick ;
      private String A6USU_COD ;
      private String edtUSU_COD_Jsonclick ;
      private String lblTextblockusu_des_Internalname ;
      private String lblTextblockusu_des_Jsonclick ;
      private String edtUSU_DES_Internalname ;
      private String A7USU_DES ;
      private String edtUSU_DES_Jsonclick ;
      private String lblTextblockusu_cla_Internalname ;
      private String lblTextblockusu_cla_Jsonclick ;
      private String edtUSU_CLA_Internalname ;
      private String A155USU_CLA ;
      private String edtUSU_CLA_Jsonclick ;
      private String lblTextblockusu_int_Internalname ;
      private String lblTextblockusu_int_Jsonclick ;
      private String edtUSU_INT_Internalname ;
      private String A180USU_INT ;
      private String edtUSU_INT_Jsonclick ;
      private String lblTextblockusu_maiw_Internalname ;
      private String lblTextblockusu_maiw_Jsonclick ;
      private String edtUSU_MAIW_Internalname ;
      private String tblTabletoolbar_Internalname ;
      private String Z6USU_COD ;
      private String Z7USU_DES ;
      private String Z155USU_CLA ;
      private String Z180USU_INT ;
      private String sMode15 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXEncryptionTmp ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n180USU_INT ;
      private bool n249USU_MAIW ;
      private String A249USU_MAIW ;
      private String Z249USU_MAIW ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private String aP1_Gx_mode ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private IDataStoreProvider pr_default ;
      private String[] T000F4_A6USU_COD ;
      private String[] T000F4_A7USU_DES ;
      private String[] T000F4_A155USU_CLA ;
      private String[] T000F4_A180USU_INT ;
      private bool[] T000F4_n180USU_INT ;
      private String[] T000F4_A249USU_MAIW ;
      private bool[] T000F4_n249USU_MAIW ;
      private String[] T000F5_A6USU_COD ;
      private String[] T000F3_A6USU_COD ;
      private String[] T000F3_A7USU_DES ;
      private String[] T000F3_A155USU_CLA ;
      private String[] T000F3_A180USU_INT ;
      private bool[] T000F3_n180USU_INT ;
      private String[] T000F3_A249USU_MAIW ;
      private bool[] T000F3_n249USU_MAIW ;
      private String[] T000F6_A6USU_COD ;
      private String[] T000F7_A6USU_COD ;
      private String[] T000F8_A6USU_COD ;
      private String[] T000F8_A7USU_DES ;
      private String[] T000F8_A155USU_CLA ;
      private String[] T000F8_A180USU_INT ;
      private bool[] T000F8_n180USU_INT ;
      private String[] T000F8_A249USU_MAIW ;
      private bool[] T000F8_n249USU_MAIW ;
      private String[] T000F12_A40TTBUS8_CodUsuario ;
      private short[] T000F13_A33TTBUS7_Pos ;
      private String[] T000F13_A39TTBUS7_CodUsuario ;
      private short[] T000F14_A33TTBUS7_Pos ;
      private String[] T000F15_A6USU_COD ;
      private String[] T000F2_A6USU_COD ;
      private String[] T000F2_A7USU_DES ;
      private String[] T000F2_A155USU_CLA ;
      private String[] T000F2_A180USU_INT ;
      private String[] T000F2_A249USU_MAIW ;
      private bool[] T000F2_n180USU_INT ;
      private bool[] T000F2_n249USU_MAIW ;
      private GXWebForm Form ;
   }

   public class tseg002__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000F2 ;
          prmT000F2 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F4 ;
          prmT000F4 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F5 ;
          prmT000F5 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F3 ;
          prmT000F3 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F6 ;
          prmT000F6 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F7 ;
          prmT000F7 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F8 ;
          prmT000F8 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F9 ;
          prmT000F9 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@USU_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@USU_INT",SqlDbType.Char,10,0} ,
          new Object[] {"@USU_MAIW",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000F10 ;
          prmT000F10 = new Object[] {
          new Object[] {"@USU_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@USU_INT",SqlDbType.Char,10,0} ,
          new Object[] {"@USU_MAIW",SqlDbType.VarChar,256,0} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F11 ;
          prmT000F11 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F12 ;
          prmT000F12 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F13 ;
          prmT000F13 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F14 ;
          prmT000F14 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000F15 ;
          prmT000F15 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000F2", "SELECT [USU_COD], [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW] FROM [SEG002] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F2,1,0,true,false )
             ,new CursorDef("T000F3", "SELECT [USU_COD], [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F3,1,0,true,false )
             ,new CursorDef("T000F4", "SELECT TM1.[USU_COD], TM1.[USU_DES], TM1.[USU_CLA], TM1.[USU_INT], TM1.[USU_MAIW] FROM [SEG002] TM1 WITH (NOLOCK) WHERE TM1.[USU_COD] = @USU_COD ORDER BY TM1.[USU_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F4,100,0,true,false )
             ,new CursorDef("T000F5", "SELECT [USU_COD] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F5,1,0,true,false )
             ,new CursorDef("T000F6", "SELECT TOP 1 [USU_COD] FROM [SEG002] WITH (NOLOCK) WHERE ( [USU_COD] > @USU_COD) ORDER BY [USU_COD]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F6,1,0,true,true )
             ,new CursorDef("T000F7", "SELECT TOP 1 [USU_COD] FROM [SEG002] WITH (NOLOCK) WHERE ( [USU_COD] < @USU_COD) ORDER BY [USU_COD] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F7,1,0,true,true )
             ,new CursorDef("T000F8", "SELECT [USU_COD], [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW] FROM [SEG002] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F8,1,0,true,false )
             ,new CursorDef("T000F9", "INSERT INTO [SEG002] ([USU_COD], [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW]) VALUES (@USU_COD, @USU_DES, @USU_CLA, @USU_INT, @USU_MAIW)", GxErrorMask.GX_NOMASK,prmT000F9)
             ,new CursorDef("T000F10", "UPDATE [SEG002] SET [USU_DES]=@USU_DES, [USU_CLA]=@USU_CLA, [USU_INT]=@USU_INT, [USU_MAIW]=@USU_MAIW  WHERE [USU_COD] = @USU_COD", GxErrorMask.GX_NOMASK,prmT000F10)
             ,new CursorDef("T000F11", "DELETE FROM [SEG002]  WHERE [USU_COD] = @USU_COD", GxErrorMask.GX_NOMASK,prmT000F11)
             ,new CursorDef("T000F12", "SELECT TOP 1 [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F12,1,0,true,true )
             ,new CursorDef("T000F13", "SELECT TOP 1 [TTBUS7_Pos], [TTBUS7_CodUsuario] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_CodUsuario] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F13,1,0,true,true )
             ,new CursorDef("T000F14", "SELECT TOP 1 [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_CodResp] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F14,1,0,true,true )
             ,new CursorDef("T000F15", "SELECT [USU_COD] FROM [SEG002] WITH (NOLOCK) ORDER BY [USU_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F15,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 10) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 10) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 10) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 10) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 13 :
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (String)parms[6]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
