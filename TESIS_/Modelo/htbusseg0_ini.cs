/*
               File: HTBUSSEG0_INI
        Description: Alta Primer Usuario
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:44.14
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
   public class htbusseg0_ini : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbusseg0_ini( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbusseg0_ini( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavAdministrador = new GXCheckbox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
         }
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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

      public override short ExecuteStartEvent( )
      {
         PA5C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START5C2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbusseg0_ini.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE5C2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT5C2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "HTBUSSEG0_INI" ;
      }

      public override String GetPgmdesc( )
      {
         return "Alta Primer Usuario" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbusseg0_ini.aspx")  ;
      }

      protected void WB5C0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_5C2( true) ;
         }
         else
         {
            wb_table1_2_5C2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_5C2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START5C2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Alta Primer Usuario", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP5C0( ) ;
      }

      protected void WS5C2( )
      {
         START5C2( ) ;
         EVT5C2( ) ;
      }

      protected void EVT5C2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E115C2 */
                              E115C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: E125C2 */
                                    E125C2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E135C2 */
                              E135C2 ();
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
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
      }

      protected void WE5C2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA5C2( )
      {
         if ( nDonePA == 0 )
         {
            chkavAdministrador.Name = "vADMINISTRADOR" ;
            chkavAdministrador.WebTags = "" ;
            chkavAdministrador.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAdministrador_Internalname, "Caption", chkavAdministrador.Caption);
            chkavAdministrador.CheckedValue = "0" ;
            GX_FocusControl = edtavUsu_cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF5C2( ) ;
         /* End function Refresh */
      }

      protected void RF5C2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E135C2 */
            E135C2 ();
            WB5C0( ) ;
         }
      }

      protected void STRUP5C0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E115C2 */
         E115C2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV8USU_COD = StringUtil.Upper( cgiGet( edtavUsu_cod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USU_COD", AV8USU_COD);
            AV9USU_DES = StringUtil.Upper( cgiGet( edtavUsu_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USU_DES", AV9USU_DES);
            AV7USU_CLA = cgiGet( edtavUsu_cla_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USU_CLA", AV7USU_CLA);
            AV17USU_INT = cgiGet( edtavUsu_int_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17USU_INT", AV17USU_INT);
            AV16USU_MAIW = cgiGet( edtavUsu_maiw_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USU_MAIW", AV16USU_MAIW);
            if ( ! context.localUtil.VCNumber( cgiGet( chkavAdministrador_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavAdministrador_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavAdministrador_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vADMINISTRADOR");
               GX_FocusControl = chkavAdministrador_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV5Administrador = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5Administrador", StringUtil.Str( (decimal)(AV5Administrador), 1, 0));
            }
            else
            {
               AV5Administrador = (short)(((StringUtil.StrCmp(cgiGet( chkavAdministrador_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5Administrador", StringUtil.Str( (decimal)(AV5Administrador), 1, 0));
            }
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E115C2 */
         E115C2 ();
         if (returnInSub) return;
      }

      protected void E115C2( )
      {
         /* Start Routine */
         AV5Administrador = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5Administrador", StringUtil.Str( (decimal)(AV5Administrador), 1, 0));
         chkavAdministrador.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAdministrador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavAdministrador.Enabled), 5, 0)));
      }

      public void GXEnter( )
      {
         /* Execute user event: E125C2 */
         E125C2 ();
         if (returnInSub) return;
      }

      protected void E125C2( )
      {
         /* Enter Routine */
         /* Execute user subroutine: S112 */
         S112 ();
         if (returnInSub) return;
         if ( AV14ok == 0 )
         {
            GX_msglist.addItem(StringUtil.Trim( AV15error));
         }
         else
         {
            GXt_char3 = "INS" ;
            new ptbusseg1(context ).execute( ref  AV8USU_COD, ref  AV9USU_DES, ref  AV7USU_CLA, ref  AV17USU_INT, ref  AV16USU_MAIW, ref  GXt_char3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USU_COD", AV8USU_COD);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USU_DES", AV9USU_DES);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USU_CLA", AV7USU_CLA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17USU_INT", AV17USU_INT);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USU_MAIW", AV16USU_MAIW);
            GXt_char2 = "INS" ;
            new ptbusseg2(context ).execute( ref  AV8USU_COD, ref  AV5Administrador, ref  GXt_char2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USU_COD", AV8USU_COD);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5Administrador", StringUtil.Str( (decimal)(AV5Administrador), 1, 0));
            GXt_char1 = "INS" ;
            new ptbusseg5(context ).execute( ref  AV8USU_COD, ref  GXt_char1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USU_COD", AV8USU_COD);
            context.setWebReturnParms(new Object[] {});
            context.nUserReturn = 1 ;
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S112( )
      {
         /* 'VALIDACIONES' Routine */
         AV14ok = 1 ;
         AV15error = "" ;
         if ( StringUtil.StrCmp(StringUtil.Trim( AV8USU_COD), "") == 0 )
         {
            AV15error = "DEBE INGRESAR UN USUARIO." ;
            AV14ok = 0 ;
         }
         if ( AV14ok == 1 )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( AV9USU_DES), "") == 0 )
            {
               AV15error = "DEBE INGRESAR UNA DESCRIPCIÓN DE USUARIO." ;
               AV14ok = 0 ;
            }
         }
         if ( AV14ok == 1 )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( AV7USU_CLA), "") == 0 )
            {
               AV15error = "DEBE INGRESAR UNA CONTRASEÑA." ;
               AV14ok = 0 ;
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E135C2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_5C2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            wb_table2_5_5C2( true) ;
         }
         else
         {
            wb_table2_5_5C2( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_5C2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;width:82px;height:37px;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Datos Generales"+"</legend>") ;
            wb_table3_14_5C2( true) ;
         }
         else
         {
            wb_table3_14_5C2( false) ;
         }
         return  ;
      }

      protected void wb_table3_14_5C2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "EENTER.", TempTags, "", "", "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_5C2e( true) ;
         }
         else
         {
            wb_table1_2_5C2e( false) ;
         }
      }

      protected void wb_table3_14_5C2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Usuario:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_cod_Internalname, StringUtil.RTrim( AV8USU_COD), "", 16, "chr", 1, "row", 16, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8USU_COD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(19);\"", 0, edtavUsu_cod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Descripción:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_des_Internalname, StringUtil.RTrim( AV9USU_DES), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9USU_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(24);\"", 0, edtavUsu_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Contraseña:", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_cla_Internalname, StringUtil.RTrim( AV7USU_CLA), "", 20, "chr", 1, "row", 20, 1, 1, 0, -1, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", 0, edtavUsu_cla_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "Teléfono Interno:", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_int_Internalname, StringUtil.RTrim( AV17USU_INT), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV17USU_INT, "XXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", 0, edtavUsu_int_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, 1, 1, 0, "Correo electrónico:", "", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtavUsu_maiw_Internalname, StringUtil.RTrim( AV16USU_MAIW), 1, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", -1, 0, "", "", true, "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Administrador:", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0_INI.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkavAdministrador_Internalname, StringUtil.Str( (decimal)(AV5Administrador), 1, 0), "", 1, chkavAdministrador.Enabled, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(44, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_14_5C2e( true) ;
         }
         else
         {
            wb_table3_14_5C2e( false) ;
         }
      }

      protected void wb_table2_5_5C2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\" id=\"Section1\"/>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_5C2e( true) ;
         }
         else
         {
            wb_table2_5_5C2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA5C2( ) ;
         WS5C2( ) ;
         WE5C2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13224431");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbusseg0_ini.js", "?13224431");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavUsu_cod_Internalname = "vUSU_COD" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavUsu_des_Internalname = "vUSU_DES" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavUsu_cla_Internalname = "vUSU_CLA" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavUsu_int_Internalname = "vUSU_INT" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtavUsu_maiw_Internalname = "vUSU_MAIW" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         chkavAdministrador_Internalname = "vADMINISTRADOR" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavUsu_int_Jsonclick = "" ;
         edtavUsu_cla_Jsonclick = "" ;
         edtavUsu_des_Jsonclick = "" ;
         edtavUsu_cod_Jsonclick = "" ;
         chkavAdministrador.Enabled = 1 ;
         chkavAdministrador.Caption = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Alta Primer Usuario" ;
         context.GX_msglist.DisplayMode = 1 ;
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV8USU_COD = "" ;
         AV9USU_DES = "" ;
         AV7USU_CLA = "" ;
         AV17USU_INT = "" ;
         AV16USU_MAIW = "" ;
         AV15error = "" ;
         GXt_char1 = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         GXt_char2 = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         GXt_char3 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short AV5Administrador ;
      private short AV14ok ;
      private short nGXWrapped ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavAdministrador_Internalname ;
      private String edtavUsu_cod_Internalname ;
      private String AV8USU_COD ;
      private String AV9USU_DES ;
      private String edtavUsu_des_Internalname ;
      private String AV7USU_CLA ;
      private String edtavUsu_cla_Internalname ;
      private String AV17USU_INT ;
      private String edtavUsu_int_Internalname ;
      private String edtavUsu_maiw_Internalname ;
      private String AV15error ;
      private String GXt_char1 ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String GXt_char2 ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavUsu_cod_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavUsu_des_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavUsu_cla_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavUsu_int_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String GXt_char3 ;
      private String tblTabletoolbar_Internalname ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV16USU_MAIW ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavAdministrador ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
