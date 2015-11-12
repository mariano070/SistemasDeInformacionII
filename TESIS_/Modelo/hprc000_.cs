/*
               File: HPRC000_
        Description: Procesos Sometidos por Usuario
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:22.37
       Program type: Main program
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
   public class hprc000_ : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public hprc000_( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hprc000_( IGxContext context )
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

      public void execute( ref String aP0_USUARIO )
      {
         this.AV13USUARIO = aP0_USUARIO;
         executePrivate();
         aP0_USUARIO=this.AV13USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavEliminar = new GXCheckbox();
         cmbPRC_EST = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid_activos") == 0 )
            {
               nRC_Grid_activos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_14_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_14_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid_activos_newrow( nRC_Grid_activos, nGXsfl_14_idx, sGXsfl_14_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid_usuario") == 0 )
            {
               nRC_Grid_usuario = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_47_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_47_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid_usuario_newrow( nRC_Grid_usuario, nGXsfl_47_idx, sGXsfl_47_idx) ;
               return  ;
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
               AV13USUARIO = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USUARIO", AV13USUARIO);
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
            PA202( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavAhora_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAhora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAhora_Enabled), 5, 0)));
               edtavTexto_procesos_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTexto_procesos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTexto_procesos_Enabled), 5, 0)));
               edtavUsuario_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsuario_Enabled), 5, 0)));
               edtavPrc_sal_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPrc_sal_Enabled), 5, 0)));
               WS202( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE202( ) ;
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      protected void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( "Procesos Sometidos por Usuario") ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
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
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         context.CloseHtmlHeader();
         FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"SubForm\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"\""+FormProcess+">") ;
         context.skipLines(1);
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hprc000_.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13USUARIO))+"\" class=\""+"SubForm"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm202( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid_activos", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid_activos), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_Grid_usuario", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid_usuario), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "PRC_SAL", StringUtil.RTrim( A159PRC_SAL));
         GxWebStd.gx_hidden_field( context, "GRID_USUARIO_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_USUARIO_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_USUARIO_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_USUARIO_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
         include_jscripts( ) ;
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
      }

      protected void WB200( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            context.WriteHtmlText( "<p>") ;
            wb_table1_3_202( true) ;
         }
         else
         {
            wb_table1_3_202( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_202e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true ;
      }

      protected void START202( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Procesos Sometidos por Usuario", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP200( ) ;
      }

      protected void WS202( )
      {
         START202( ) ;
         EVT202( ) ;
      }

      protected void EVT202( )
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
                  /* Check if conditions changed and reset current page numbers */
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
                        else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'FIRST'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11202 */
                           E11202 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12202 */
                           E12202 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E13202 */
                           E13202 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E14202 */
                           E14202 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'EJECUTAR AHORA'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E15202 */
                           E15202 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'BORRAR'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E16202 */
                           E16202 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'ESTABLECER HORA DE INICIO'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E17202 */
                           E17202 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'ALTA PRIORIDAD'") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E18202 */
                           E18202 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4) ;
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "GRID_ACTIVOS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'BORRAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "'EJECUTAR AHORA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "'ALTA PRIORIDAD'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 27), "'ESTABLECER HORA DE INICIO'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "'FIRST'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'PREVIOUS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'NEXT'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'LAST'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                        {
                           nGXsfl_14_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                           sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0") ;
                           edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
                           edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
                           edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
                           edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
                           edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
                           edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
                           edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
                           edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
                           edtPRC_EML_Internalname = "PRC_EML_"+sGXsfl_14_idx ;
                           A79PRC_NRO = (long)(context.localUtil.CToN( cgiGet( edtPRC_NRO_Internalname), ",", ".")) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
                           A94PRC_USR = StringUtil.Upper( cgiGet( edtPRC_USR_Internalname)) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
                           A92PRC_ING = context.localUtil.CToT( cgiGet( edtPRC_ING_Internalname)) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
                           A95PRC_DES = cgiGet( edtPRC_DES_Internalname) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
                           A158PRC_EST = (short)(context.localUtil.CToN( cgiGet( edtPRC_EST_Internalname), ",", ".")) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
                           A96PRC_INI = context.localUtil.CToT( cgiGet( edtPRC_INI_Internalname)) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
                           A157PRC_FIN = context.localUtil.CToT( cgiGet( edtPRC_FIN_Internalname)) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
                           A161PRC_MSG = cgiGet( edtPRC_MSG_Internalname) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
                           A97PRC_EML = context.localUtil.CToT( cgiGet( edtPRC_EML_Internalname)) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A97PRC_EML", context.localUtil.TToC( A97PRC_EML, 8, 5, 0, 3, "/", ":", " "));
                           sEvtType = StringUtil.Right( sEvt, 1) ;
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E19202 */
                                 E19202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID_ACTIVOS.LOAD") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E20202 */
                                 E20202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'BORRAR'") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E16202 */
                                 E16202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'EJECUTAR AHORA'") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E15202 */
                                 E15202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'ALTA PRIORIDAD'") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E18202 */
                                 E18202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'ESTABLECER HORA DE INICIO'") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E17202 */
                                 E17202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'FIRST'") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E11202 */
                                 E11202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E12202 */
                                 E12202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E13202 */
                                 E13202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E14202 */
                                 E14202 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false ;
                                    if ( ! Rfr0gs )
                                    {
                                    }
                                    dynload_actions( ) ;
                                 }
                              }
                              else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
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
                        else if ( StringUtil.StrCmp(StringUtil.Left( sEvt, 17), "GRID_USUARIO.LOAD") == 0 )
                        {
                           nGXsfl_47_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                           sGXsfl_47_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_idx), 4, 0)), 4, "0") ;
                           chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
                           edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
                           edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
                           edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
                           edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
                           edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
                           edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
                           edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
                           edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
                           edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
                           AV7ELIMINAR = ((StringUtil.StrCmp(cgiGet( chkavEliminar_Internalname), "*")==0) ? "*" : " ") ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ELIMINAR", AV7ELIMINAR);
                           A79PRC_NRO = (long)(context.localUtil.CToN( cgiGet( edtPRC_NRO_Internalname), ",", ".")) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
                           A92PRC_ING = context.localUtil.CToT( cgiGet( edtPRC_ING_Internalname)) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
                           A95PRC_DES = cgiGet( edtPRC_DES_Internalname) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
                           edtPRC_EST_Name = edtPRC_EST_Internalname ;
                           edtPRC_EST_Value = cgiGet( edtPRC_EST_Internalname) ;
                           A158PRC_EST = (short)(NumberUtil.Val( cgiGet( edtPRC_EST_Internalname), ".")) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
                           A96PRC_INI = context.localUtil.CToT( cgiGet( edtPRC_INI_Internalname)) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
                           AV9PRC_SAL = cgiGet( edtavPrc_sal_Internalname) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
                           A157PRC_FIN = context.localUtil.CToT( cgiGet( edtPRC_FIN_Internalname)) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
                           A161PRC_MSG = cgiGet( edtPRC_MSG_Internalname) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
                           A94PRC_USR = StringUtil.Upper( cgiGet( edtPRC_USR_Internalname)) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
                           sEvtType = StringUtil.Right( sEvt, 1) ;
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                              if ( StringUtil.StrCmp(sEvt, "GRID_USUARIO.LOAD") == 0 )
                              {
                                 context.wbHandled = 1 ;
                                 dynload_actions( ) ;
                                 /* Execute user event: E21203 */
                                 E21203 ();
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
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void WE202( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm202( ) ;
            }
         }
      }

      protected void PA202( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "vELIMINAR_" + sGXsfl_47_idx ;
            chkavEliminar.Name = GXCCtl ;
            chkavEliminar.WebTags = "" ;
            chkavEliminar.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavEliminar_Internalname, "Caption", chkavEliminar.Caption);
            chkavEliminar.CheckedValue = " " ;
            GXCCtl = "PRC_EST_" + sGXsfl_14_idx ;
            edtPRC_EST_Name = GXCCtl ;
            edtPRC_EST_Webtags = "" ;
            cmbPRC_EST.addItem("0", "En espera", 0);
            cmbPRC_EST.addItem("1", "Procesando", 0);
            cmbPRC_EST.addItem("2", "Finalizado", 0);
            cmbPRC_EST.addItem("4", "Procesando Int.", 0);
            cmbPRC_EST.addItem("5", "Interactivo", 0);
            cmbPRC_EST.addItem("6", "Prioritario", 0);
            cmbPRC_EST.addItem("7", "Proc. Alta Prioridad", 0);
            GX_FocusControl = edtavAhora_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_activos_newrow( short nRC_Grid_activos ,
                                              short nGXsfl_14_idx ,
                                              String sGXsfl_14_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
         edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
         edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
         edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
         edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
         edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
         edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
         edtPRC_EML_Internalname = "PRC_EML_"+sGXsfl_14_idx ;
         while ( nGXsfl_14_idx <= nRC_Grid_activos )
         {
            sendrow_142( ) ;
            nGXsfl_14_idx = (short)(((subGrid_activos_Islastpage==1)&&(nGXsfl_14_idx+1>subGrid_activos_Recordsperpage( )) ? 1 : nGXsfl_14_idx+1)) ;
            sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0") ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
            edtPRC_EML_Internalname = "PRC_EML_"+sGXsfl_14_idx ;
         }
         context.GX_webresponse.AddString(Grid_activosContainer.ToJavascriptSource());
         /* End function gxnrGrid_activos_newrow */
      }

      protected void gxnrGrid_usuario_newrow( short nRC_Grid_usuario ,
                                              short nGXsfl_47_idx ,
                                              String sGXsfl_47_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
         edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
         edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
         edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
         edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
         edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
         edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
         edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
         edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
         edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         while ( nGXsfl_47_idx <= nRC_Grid_usuario )
         {
            sendrow_473( ) ;
            nGXsfl_47_idx = (short)(((subGrid_usuario_Islastpage==1)&&(nGXsfl_47_idx+1>subGrid_usuario_Recordsperpage( )) ? 1 : nGXsfl_47_idx+1)) ;
            sGXsfl_47_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         }
         context.GX_webresponse.AddString(Grid_usuarioContainer.ToJavascriptSource());
         /* End function gxnrGrid_usuario_newrow */
      }

      protected void Refresh( )
      {
         RF202( ) ;
         RF203( ) ;
         /* End function Refresh */
      }

      protected void RF202( )
      {
         Grid_activosContainer.PageSize = subGrid_activos_Recordsperpage( ) ;
         wbStart = 14 ;
         nGXsfl_14_idx = 1 ;
         sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0") ;
         edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
         edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
         edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
         edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
         edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
         edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
         edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
         edtPRC_EML_Internalname = "PRC_EML_"+sGXsfl_14_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
            edtPRC_EML_Internalname = "PRC_EML_"+sGXsfl_14_idx ;
            /* Using cursor H00202 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A160PRC_INV = H00202_A160PRC_INV[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160PRC_INV", A160PRC_INV);
               A159PRC_SAL = H00202_A159PRC_SAL[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159PRC_SAL", A159PRC_SAL);
               A97PRC_EML = H00202_A97PRC_EML[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A97PRC_EML", context.localUtil.TToC( A97PRC_EML, 8, 5, 0, 3, "/", ":", " "));
               A161PRC_MSG = H00202_A161PRC_MSG[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
               A157PRC_FIN = H00202_A157PRC_FIN[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
               A96PRC_INI = H00202_A96PRC_INI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
               A158PRC_EST = H00202_A158PRC_EST[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
               A95PRC_DES = H00202_A95PRC_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
               A92PRC_ING = H00202_A92PRC_ING[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
               A94PRC_USR = H00202_A94PRC_USR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
               A79PRC_NRO = H00202_A79PRC_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
               A93PRC_NOM = H00202_A93PRC_NOM[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93PRC_NOM", A93PRC_NOM);
               /* Execute user event: E20202 */
               E20202 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 14 ;
            WB200( ) ;
         }
      }

      protected int subGrid_activos_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_activos_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_activos_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_activos_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void RF203( )
      {
         Grid_usuarioContainer.PageSize = subGrid_usuario_Recordsperpage( ) ;
         wbStart = 47 ;
         nGXsfl_47_idx = 1 ;
         sGXsfl_47_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_idx), 4, 0)), 4, "0") ;
         chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
         edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
         edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
         edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
         edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
         edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
         edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
         edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
         edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
         edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
            /* Using cursor H00203 */
            pr_default.execute(1, new Object[] {AV13USUARIO});
            nGXsfl_47_idx = 1 ;
            GRID_USUARIO_nEOF = 0 ;
            while ( ( (pr_default.getStatus(1) != 101) ) && ( ( ( 10 == 0 ) || ( GRID_USUARIO_nCurrentRecord < GRID_USUARIO_nFirstRecordOnPage + subGrid_usuario_Recordsperpage( ) ) ) ) )
            {
               A160PRC_INV = H00203_A160PRC_INV[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A160PRC_INV", A160PRC_INV);
               A97PRC_EML = H00203_A97PRC_EML[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A97PRC_EML", context.localUtil.TToC( A97PRC_EML, 8, 5, 0, 3, "/", ":", " "));
               A159PRC_SAL = H00203_A159PRC_SAL[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159PRC_SAL", A159PRC_SAL);
               A94PRC_USR = H00203_A94PRC_USR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
               A161PRC_MSG = H00203_A161PRC_MSG[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
               A157PRC_FIN = H00203_A157PRC_FIN[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
               A96PRC_INI = H00203_A96PRC_INI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
               A158PRC_EST = H00203_A158PRC_EST[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
               A95PRC_DES = H00203_A95PRC_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
               A92PRC_ING = H00203_A92PRC_ING[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
               A79PRC_NRO = H00203_A79PRC_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
               /* Execute user event: E21203 */
               E21203 ();
               pr_default.readNext(1);
            }
            GRID_USUARIO_nEOF = (short)(((pr_default.getStatus(1) == 101) ? 1 : 0)) ;
            pr_default.close(1);
            wbEnd = 47 ;
            WB200( ) ;
         }
      }

      protected int subGrid_usuario_Pagecount( )
      {
         GRID_USUARIO_nRecordCount = subGrid_usuario_Recordcount( ) ;
         if ( ((int)(GRID_USUARIO_nRecordCount) % (subGrid_usuario_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_USUARIO_nRecordCount/ (decimal)(subGrid_usuario_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_USUARIO_nRecordCount/ (decimal)(subGrid_usuario_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_usuario_Recordcount( )
      {
         /* Using cursor H00204 */
         pr_default.execute(2, new Object[] {AV13USUARIO});
         GRID_USUARIO_nRecordCount = H00204_AGRID_USUARIO_nRecordCount[0] ;
         pr_default.close(2);
         return GRID_USUARIO_nRecordCount ;
      }

      protected int subGrid_usuario_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid_usuario_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_USUARIO_nFirstRecordOnPage/ (decimal)(subGrid_usuario_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_usuario_firstpage( )
      {
         GRID_USUARIO_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid_usuario_nextpage( )
      {
         GRID_USUARIO_nRecordCount = subGrid_usuario_Recordcount( ) ;
         if ( ( GRID_USUARIO_nRecordCount >= subGrid_usuario_Recordsperpage( ) ) && ( GRID_USUARIO_nEOF == 0 ) )
         {
            GRID_USUARIO_nFirstRecordOnPage = (int)(GRID_USUARIO_nFirstRecordOnPage+subGrid_usuario_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid_usuario_previouspage( )
      {
         if ( GRID_USUARIO_nFirstRecordOnPage >= subGrid_usuario_Recordsperpage( ) )
         {
            GRID_USUARIO_nFirstRecordOnPage = (int)(GRID_USUARIO_nFirstRecordOnPage-subGrid_usuario_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid_usuario_lastpage( )
      {
         GRID_USUARIO_nRecordCount = subGrid_usuario_Recordcount( ) ;
         if ( GRID_USUARIO_nRecordCount > subGrid_usuario_Recordsperpage( ) )
         {
            if ( ((int)(GRID_USUARIO_nRecordCount) % (subGrid_usuario_Recordsperpage( ))) == 0 )
            {
               GRID_USUARIO_nFirstRecordOnPage = (int)(GRID_USUARIO_nRecordCount-subGrid_usuario_Recordsperpage( )) ;
            }
            else
            {
               GRID_USUARIO_nFirstRecordOnPage = (int)(GRID_USUARIO_nRecordCount-((int)(GRID_USUARIO_nRecordCount) % (subGrid_usuario_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID_USUARIO_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid_usuario_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid_usuario_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID_USUARIO_nFirstRecordOnPage = (int)(subGrid_usuario_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID_USUARIO_nFirstRecordOnPage = (int)(subGrid_usuario_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID_USUARIO_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP200( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavAhora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAhora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAhora_Enabled), 5, 0)));
         edtavTexto_procesos_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTexto_procesos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTexto_procesos_Enabled), 5, 0)));
         edtavUsuario_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsuario_Enabled), 5, 0)));
         edtavPrc_sal_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPrc_sal_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E19202 */
         E19202 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( context.localUtil.VCDateTime( cgiGet( edtavAhora_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"AHORA"}), 1, "vAHORA");
               GX_FocusControl = edtavAhora_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV5AHORA = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5AHORA", context.localUtil.TToC( AV5AHORA, 8, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV5AHORA = context.localUtil.CToT( cgiGet( edtavAhora_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5AHORA", context.localUtil.TToC( AV5AHORA, 8, 5, 0, 3, "/", ":", " "));
            }
            AV12TEXTO_PROCESOS = cgiGet( edtavTexto_procesos_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12TEXTO_PROCESOS", AV12TEXTO_PROCESOS);
            AV13USUARIO = StringUtil.Upper( cgiGet( edtavUsuario_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USUARIO", AV13USUARIO);
            /* Read saved values. */
            nRC_Grid_activos = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid_activos"), ",", ".")) ;
            nRC_Grid_usuario = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid_usuario"), ",", ".")) ;
            GRID_USUARIO_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID_USUARIO_nFirstRecordOnPage"), ",", ".")) ;
            GRID_USUARIO_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_USUARIO_nEOF"), ",", ".")) ;
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
         /* Execute user event: E19202 */
         E19202 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19202( )
      {
         /* Start Routine */
         AV12TEXTO_PROCESOS = " " ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12TEXTO_PROCESOS", AV12TEXTO_PROCESOS);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV13USUARIO)) )
         {
            new loadcontext(context ).execute( out  AV14context) ;
            AV13USUARIO = AV14context.gxTpr_User ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USUARIO", AV13USUARIO);
         }
      }

      private void E20202( )
      {
         /* Grid_activos_Load Routine */
         AV5AHORA = DateTimeUtil.Now( ) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5AHORA", context.localUtil.TToC( AV5AHORA, 8, 5, 0, 3, "/", ":", " "));
         if ( ( A158PRC_EST == 1 ) || ( A158PRC_EST == 4 ) || ( A158PRC_EST == 5 ) || ( A158PRC_EST == 6 ) || ( A158PRC_EST == 7 ) )
         {
            if ( DateTimeUtil.TDiff( AV5AHORA, A157PRC_FIN) > 600 )
            {
               edtPRC_FIN_Backcolor = GXUtil.RGB( 255, 0, 0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
               edtPRC_MSG_Backcolor = GXUtil.RGB( 255, 0, 0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
               edtavTexto_procesos_Forecolor = GXUtil.RGB( 255, 0, 0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTexto_procesos_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTexto_procesos_Forecolor), 9, 0)));
               AV12TEXTO_PROCESOS = "Existen Procesos Demorados." ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12TEXTO_PROCESOS", AV12TEXTO_PROCESOS);
               if ( ( DateTimeUtil.TDiff( AV5AHORA, A97PRC_EML) > 300 ) || (DateTime.MinValue==A97PRC_EML) )
               {
               }
            }
            else
            {
               if ( ( A158PRC_EST == 7 ) || ( A158PRC_EST == 6 ) )
               {
                  edtPRC_FIN_Backcolor = GXUtil.RGB( 255, 217, 100) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
                  edtPRC_MSG_Backcolor = GXUtil.RGB( 255, 217, 100) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
               }
               else
               {
                  edtPRC_FIN_Backcolor = GXUtil.RGB( 255, 255, 200) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
                  edtPRC_MSG_Backcolor = GXUtil.RGB( 255, 255, 200) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
               }
            }
            if ( StringUtil.StrCmp(A159PRC_SAL, "    ") == 0 )
            {
               AV9PRC_SAL = "En Proceso..." ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            }
            edtavPrc_sal_Link = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
         }
         else if ( A158PRC_EST == 3 )
         {
            edtPRC_FIN_Backcolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
            edtPRC_MSG_Backcolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
            edtavTexto_procesos_Forecolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTexto_procesos_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTexto_procesos_Forecolor), 9, 0)));
            AV12TEXTO_PROCESOS = "Existen Procesos Demorados." ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12TEXTO_PROCESOS", AV12TEXTO_PROCESOS);
            if ( StringUtil.StrCmp(A159PRC_SAL, "    ") == 0 )
            {
               AV9PRC_SAL = "Proceso Demorado/Suspendido." ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            }
            edtavPrc_sal_Link = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
         }
         else if ( A158PRC_EST == 0 )
         {
            if ( DateTimeUtil.TDiff( AV5AHORA, A157PRC_FIN) > 1200 )
            {
               if ( ( DateTimeUtil.TDiff( AV5AHORA, A97PRC_EML) > 300 ) || (DateTime.MinValue==A97PRC_EML) )
               {
               }
            }
            else
            {
               edtPRC_FIN_Backcolor = GXUtil.RGB( 243, 243, 243) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
               edtPRC_MSG_Backcolor = GXUtil.RGB( 243, 243, 243) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
            }
            AV9PRC_SAL = "" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            edtavPrc_sal_Link = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
         }
         else if ( ( A158PRC_EST == 2 ) || ( A158PRC_EST == 9 ) )
         {
            edtPRC_FIN_Backcolor = GXUtil.RGB( 200, 255, 200) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
            edtPRC_MSG_Backcolor = GXUtil.RGB( 200, 255, 200) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(StringUtil.Substring( A159PRC_SAL, 1, 23), "c:\\inetpub\\wwwroot\\RPT\\") == 0 )
            {
               AV9PRC_SAL = StringUtil.Substring( A159PRC_SAL, 19, 80) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
               edtavPrc_sal_Link = AV9PRC_SAL ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
            }
            else if ( StringUtil.StrCmp(StringUtil.Substring( A159PRC_SAL, 1, 16), "E:\\INTRANET\\RPT\\") == 0 )
            {
               AV9PRC_SAL = StringUtil.Substring( A159PRC_SAL, 12, 80) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
               AV9PRC_SAL = "\\RPT03" + StringUtil.Substring( AV9PRC_SAL, 5, 80) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
               edtavPrc_sal_Link = AV9PRC_SAL ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
            }
            else
            {
               AV9PRC_SAL = "" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
               edtavPrc_sal_Link = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
            }
            if ( StringUtil.StrCmp(A159PRC_SAL, "    ") == 0 )
            {
               AV9PRC_SAL = A159PRC_SAL ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            }
            edtavPrc_sal_Linktarget = "_BLANK" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Linktarget", edtavPrc_sal_Linktarget);
            edtavPrc_sal_Link = AV9PRC_SAL ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 14 ;
         }
         sendrow_142( ) ;
      }

      protected void E16202( )
      {
         /* 'Borrar' Routine */
         /* Start For Each Line in Grid_usuario */
         nRC_Grid_usuario = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid_usuario"), ",", ".")) ;
         nGXsfl_47_fel_idx = 0 ;
         while ( nGXsfl_47_fel_idx < nRC_Grid_usuario )
         {
            nGXsfl_47_fel_idx = (short)(((subGrid_usuario_Islastpage==1)&&(nGXsfl_47_fel_idx+1>subGrid_usuario_Recordsperpage( )) ? 1 : nGXsfl_47_fel_idx+1)) ;
            sGXsfl_47_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_fel_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_fel_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_fel_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_fel_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_fel_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_fel_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_fel_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_fel_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_fel_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_fel_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_fel_idx ;
            AV7ELIMINAR = ((StringUtil.StrCmp(cgiGet( chkavEliminar_Internalname), "*")==0) ? "*" : " ") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ELIMINAR", AV7ELIMINAR);
            A79PRC_NRO = (long)(context.localUtil.CToN( cgiGet( edtPRC_NRO_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
            A92PRC_ING = context.localUtil.CToT( cgiGet( edtPRC_ING_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
            A95PRC_DES = cgiGet( edtPRC_DES_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
            edtPRC_EST_Name = edtPRC_EST_Internalname ;
            edtPRC_EST_Value = cgiGet( edtPRC_EST_Internalname) ;
            A158PRC_EST = (short)(NumberUtil.Val( cgiGet( edtPRC_EST_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
            A96PRC_INI = context.localUtil.CToT( cgiGet( edtPRC_INI_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
            AV9PRC_SAL = cgiGet( edtavPrc_sal_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            A157PRC_FIN = context.localUtil.CToT( cgiGet( edtPRC_FIN_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
            A161PRC_MSG = cgiGet( edtPRC_MSG_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
            A94PRC_USR = StringUtil.Upper( cgiGet( edtPRC_USR_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
            if ( StringUtil.StrCmp(AV7ELIMINAR, "*") == 0 )
            {
               if ( ( StringUtil.StrCmp(A94PRC_USR, AV13USUARIO) != 0 ) && ( StringUtil.StrCmp(AV13USUARIO, "SUPERVISOR") != 0 ) )
               {
                  GX_msglist.addItem("Eliminación Inválida proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": El proceso pertenece a Otro USUARIO.");
               }
               else
               {
                  if ( ( A158PRC_EST != 0 ) && ( A158PRC_EST != 9 ) && ( A158PRC_EST != 2 ) )
                  {
                     GX_msglist.addItem("Eliminación Inválida proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": Los procesos a eliminar deben estar en espera o finalizados.");
                  }
                  else
                  {
                     GXt_char2 = "X" ;
                     new pweb001(context ).execute( ref  A79PRC_NRO, ref  GXt_char2) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
                  }
               }
            }
            /* End For Each Line */
         }
         if ( nGXsfl_47_fel_idx == 0 )
         {
            nGXsfl_47_idx = 1 ;
            sGXsfl_47_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         }
         nGXsfl_47_fel_idx = 1 ;
      }

      protected void E15202( )
      {
         /* 'Ejecutar Ahora' Routine */
         /* Start For Each Line in Grid_usuario */
         nRC_Grid_usuario = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid_usuario"), ",", ".")) ;
         nGXsfl_47_fel_idx = 0 ;
         while ( nGXsfl_47_fel_idx < nRC_Grid_usuario )
         {
            nGXsfl_47_fel_idx = (short)(((subGrid_usuario_Islastpage==1)&&(nGXsfl_47_fel_idx+1>subGrid_usuario_Recordsperpage( )) ? 1 : nGXsfl_47_fel_idx+1)) ;
            sGXsfl_47_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_fel_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_fel_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_fel_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_fel_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_fel_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_fel_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_fel_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_fel_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_fel_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_fel_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_fel_idx ;
            AV7ELIMINAR = ((StringUtil.StrCmp(cgiGet( chkavEliminar_Internalname), "*")==0) ? "*" : " ") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ELIMINAR", AV7ELIMINAR);
            A79PRC_NRO = (long)(context.localUtil.CToN( cgiGet( edtPRC_NRO_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
            A92PRC_ING = context.localUtil.CToT( cgiGet( edtPRC_ING_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
            A95PRC_DES = cgiGet( edtPRC_DES_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
            edtPRC_EST_Name = edtPRC_EST_Internalname ;
            edtPRC_EST_Value = cgiGet( edtPRC_EST_Internalname) ;
            A158PRC_EST = (short)(NumberUtil.Val( cgiGet( edtPRC_EST_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
            A96PRC_INI = context.localUtil.CToT( cgiGet( edtPRC_INI_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
            AV9PRC_SAL = cgiGet( edtavPrc_sal_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            A157PRC_FIN = context.localUtil.CToT( cgiGet( edtPRC_FIN_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
            A161PRC_MSG = cgiGet( edtPRC_MSG_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
            A94PRC_USR = StringUtil.Upper( cgiGet( edtPRC_USR_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
            if ( StringUtil.StrCmp(AV7ELIMINAR, "*") == 0 )
            {
               if ( ( StringUtil.StrCmp(A94PRC_USR, AV13USUARIO) != 0 ) && ( StringUtil.StrCmp(AV13USUARIO, "SUPERVISOR") != 0 ) )
               {
                  GX_msglist.addItem("Proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": El proceso pertenece a Otro USUARIO.");
               }
               else
               {
                  if ( A158PRC_EST != 0 )
                  {
                     GX_msglist.addItem("Proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": El proceso debe estar en espera de ejecución.");
                  }
                  else
                  {
                     AV10SENIAL = 0 ;
                     new rprc002(context ).execute( ref  A93PRC_NOM, ref  AV13USUARIO, ref  AV10SENIAL, ref  AV8MENSAJE) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93PRC_NOM", A93PRC_NOM);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USUARIO", AV13USUARIO);
                     if ( AV10SENIAL == 1 )
                     {
                        new pprc001(context ).execute( ref  A79PRC_NRO) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
                        GX_msglist.addItem("Proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": El proceso comenzará inmediatamente.");
                     }
                     else
                     {
                        GX_msglist.addItem("Proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": "+AV8MENSAJE);
                     }
                  }
               }
            }
            /* End For Each Line */
         }
         if ( nGXsfl_47_fel_idx == 0 )
         {
            nGXsfl_47_idx = 1 ;
            sGXsfl_47_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         }
         nGXsfl_47_fel_idx = 1 ;
      }

      protected void E18202( )
      {
         /* 'Alta Prioridad' Routine */
         /* Start For Each Line in Grid_usuario */
         nRC_Grid_usuario = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid_usuario"), ",", ".")) ;
         nGXsfl_47_fel_idx = 0 ;
         while ( nGXsfl_47_fel_idx < nRC_Grid_usuario )
         {
            nGXsfl_47_fel_idx = (short)(((subGrid_usuario_Islastpage==1)&&(nGXsfl_47_fel_idx+1>subGrid_usuario_Recordsperpage( )) ? 1 : nGXsfl_47_fel_idx+1)) ;
            sGXsfl_47_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_fel_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_fel_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_fel_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_fel_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_fel_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_fel_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_fel_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_fel_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_fel_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_fel_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_fel_idx ;
            AV7ELIMINAR = ((StringUtil.StrCmp(cgiGet( chkavEliminar_Internalname), "*")==0) ? "*" : " ") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ELIMINAR", AV7ELIMINAR);
            A79PRC_NRO = (long)(context.localUtil.CToN( cgiGet( edtPRC_NRO_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
            A92PRC_ING = context.localUtil.CToT( cgiGet( edtPRC_ING_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
            A95PRC_DES = cgiGet( edtPRC_DES_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
            edtPRC_EST_Name = edtPRC_EST_Internalname ;
            edtPRC_EST_Value = cgiGet( edtPRC_EST_Internalname) ;
            A158PRC_EST = (short)(NumberUtil.Val( cgiGet( edtPRC_EST_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
            A96PRC_INI = context.localUtil.CToT( cgiGet( edtPRC_INI_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
            AV9PRC_SAL = cgiGet( edtavPrc_sal_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            A157PRC_FIN = context.localUtil.CToT( cgiGet( edtPRC_FIN_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
            A161PRC_MSG = cgiGet( edtPRC_MSG_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
            A94PRC_USR = StringUtil.Upper( cgiGet( edtPRC_USR_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
            if ( StringUtil.StrCmp(AV7ELIMINAR, "*") == 0 )
            {
               if ( ( StringUtil.StrCmp(A94PRC_USR, AV13USUARIO) != 0 ) && ( StringUtil.StrCmp(AV13USUARIO, "SUPERVISOR") != 0 ) )
               {
                  GX_msglist.addItem("Proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": El proceso pertenece a Otro USUARIO.");
               }
               else
               {
                  if ( A158PRC_EST != 0 )
                  {
                     GX_msglist.addItem("Proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": El proceso debe estar en espera de ejecución.");
                  }
                  else
                  {
                     new pprc001p(context ).execute( ref  A79PRC_NRO) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
                     GX_msglist.addItem("Proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": El proceso comenzará inmediatamente.");
                  }
               }
            }
            /* End For Each Line */
         }
         if ( nGXsfl_47_fel_idx == 0 )
         {
            nGXsfl_47_idx = 1 ;
            sGXsfl_47_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         }
         nGXsfl_47_fel_idx = 1 ;
      }

      protected void E17202( )
      {
         /* 'Establecer Hora de Inicio' Routine */
         AV6CUENTA = 0 ;
         /* Start For Each Line in Grid_usuario */
         nRC_Grid_usuario = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid_usuario"), ",", ".")) ;
         nGXsfl_47_fel_idx = 0 ;
         while ( nGXsfl_47_fel_idx < nRC_Grid_usuario )
         {
            nGXsfl_47_fel_idx = (short)(((subGrid_usuario_Islastpage==1)&&(nGXsfl_47_fel_idx+1>subGrid_usuario_Recordsperpage( )) ? 1 : nGXsfl_47_fel_idx+1)) ;
            sGXsfl_47_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_fel_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_fel_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_fel_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_fel_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_fel_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_fel_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_fel_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_fel_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_fel_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_fel_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_fel_idx ;
            AV7ELIMINAR = ((StringUtil.StrCmp(cgiGet( chkavEliminar_Internalname), "*")==0) ? "*" : " ") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ELIMINAR", AV7ELIMINAR);
            A79PRC_NRO = (long)(context.localUtil.CToN( cgiGet( edtPRC_NRO_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
            A92PRC_ING = context.localUtil.CToT( cgiGet( edtPRC_ING_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
            A95PRC_DES = cgiGet( edtPRC_DES_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
            edtPRC_EST_Name = edtPRC_EST_Internalname ;
            edtPRC_EST_Value = cgiGet( edtPRC_EST_Internalname) ;
            A158PRC_EST = (short)(NumberUtil.Val( cgiGet( edtPRC_EST_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
            A96PRC_INI = context.localUtil.CToT( cgiGet( edtPRC_INI_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
            AV9PRC_SAL = cgiGet( edtavPrc_sal_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            A157PRC_FIN = context.localUtil.CToT( cgiGet( edtPRC_FIN_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
            A161PRC_MSG = cgiGet( edtPRC_MSG_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
            A94PRC_USR = StringUtil.Upper( cgiGet( edtPRC_USR_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
            if ( StringUtil.StrCmp(AV7ELIMINAR, "*") == 0 )
            {
               AV6CUENTA = (short)(AV6CUENTA+1) ;
            }
            /* End For Each Line */
         }
         if ( nGXsfl_47_fel_idx == 0 )
         {
            nGXsfl_47_idx = 1 ;
            sGXsfl_47_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         }
         nGXsfl_47_fel_idx = 1 ;
         if ( AV6CUENTA > 1 )
         {
            GX_msglist.addItem("Debe Seleccionar solamente un Proceso ");
         }
         else
         {
            /* Start For Each Line in Grid_usuario */
            nRC_Grid_usuario = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid_usuario"), ",", ".")) ;
            nGXsfl_47_fel_idx = 0 ;
            while ( nGXsfl_47_fel_idx < nRC_Grid_usuario )
            {
               nGXsfl_47_fel_idx = (short)(((subGrid_usuario_Islastpage==1)&&(nGXsfl_47_fel_idx+1>subGrid_usuario_Recordsperpage( )) ? 1 : nGXsfl_47_fel_idx+1)) ;
               sGXsfl_47_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_fel_idx), 4, 0)), 4, "0") ;
               chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_fel_idx ;
               edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_fel_idx ;
               edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_fel_idx ;
               edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_fel_idx ;
               edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_fel_idx ;
               edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_fel_idx ;
               edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_fel_idx ;
               edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_fel_idx ;
               edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_fel_idx ;
               edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_fel_idx ;
               AV7ELIMINAR = ((StringUtil.StrCmp(cgiGet( chkavEliminar_Internalname), "*")==0) ? "*" : " ") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ELIMINAR", AV7ELIMINAR);
               A79PRC_NRO = (long)(context.localUtil.CToN( cgiGet( edtPRC_NRO_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A79PRC_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0)));
               A92PRC_ING = context.localUtil.CToT( cgiGet( edtPRC_ING_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92PRC_ING", context.localUtil.TToC( A92PRC_ING, 8, 5, 0, 3, "/", ":", " "));
               A95PRC_DES = cgiGet( edtPRC_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A95PRC_DES", A95PRC_DES);
               edtPRC_EST_Name = edtPRC_EST_Internalname ;
               edtPRC_EST_Value = cgiGet( edtPRC_EST_Internalname) ;
               A158PRC_EST = (short)(NumberUtil.Val( cgiGet( edtPRC_EST_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158PRC_EST", StringUtil.Str( (decimal)(A158PRC_EST), 1, 0));
               A96PRC_INI = context.localUtil.CToT( cgiGet( edtPRC_INI_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A96PRC_INI", context.localUtil.TToC( A96PRC_INI, 8, 5, 0, 3, "/", ":", " "));
               AV9PRC_SAL = cgiGet( edtavPrc_sal_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
               A157PRC_FIN = context.localUtil.CToT( cgiGet( edtPRC_FIN_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157PRC_FIN", context.localUtil.TToC( A157PRC_FIN, 8, 5, 0, 3, "/", ":", " "));
               A161PRC_MSG = cgiGet( edtPRC_MSG_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161PRC_MSG", A161PRC_MSG);
               A94PRC_USR = StringUtil.Upper( cgiGet( edtPRC_USR_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94PRC_USR", A94PRC_USR);
               if ( StringUtil.StrCmp(AV7ELIMINAR, "*") == 0 )
               {
                  if ( ( StringUtil.StrCmp(A94PRC_USR, AV13USUARIO) != 0 ) && ( StringUtil.StrCmp(AV13USUARIO, "SUPERVISOR") != 0 ) )
                  {
                     GX_msglist.addItem("Proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": El proceso pertenece a Otro USUARIO.");
                  }
                  else
                  {
                     if ( A158PRC_EST != 0 )
                     {
                        GX_msglist.addItem("Proceso "+StringUtil.Str( (decimal)(A79PRC_NRO), 6, 0)+": El proceso debe estar en espera de ejecución.");
                     }
                     else
                     {
                        context.wjLoc = formatLink("tcol000.aspx") + "?" + UrlEncode("" +A79PRC_NRO) ;
                     }
                  }
               }
               /* End For Each Line */
            }
            if ( nGXsfl_47_fel_idx == 0 )
            {
               nGXsfl_47_idx = 1 ;
               sGXsfl_47_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_idx), 4, 0)), 4, "0") ;
               chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
               edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
               edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
               edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
               edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
               edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
               edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
               edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
               edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
               edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
            }
            nGXsfl_47_fel_idx = 1 ;
         }
      }

      protected void E11202( )
      {
         /* 'First' Routine */
         subgrid_usuario_firstpage( ) ;
      }

      protected void E12202( )
      {
         /* 'Previous' Routine */
         subgrid_usuario_previouspage( ) ;
      }

      protected void E13202( )
      {
         /* 'Next' Routine */
         subgrid_usuario_nextpage( ) ;
      }

      protected void E14202( )
      {
         /* 'Last' Routine */
         subgrid_usuario_lastpage( ) ;
      }

      private void E21203( )
      {
         /* Grid_usuario_Load Routine */
         AV5AHORA = DateTimeUtil.Now( ) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5AHORA", context.localUtil.TToC( AV5AHORA, 8, 5, 0, 3, "/", ":", " "));
         if ( ( A158PRC_EST == 1 ) || ( A158PRC_EST == 4 ) || ( A158PRC_EST == 5 ) || ( A158PRC_EST == 6 ) || ( A158PRC_EST == 7 ) )
         {
            edtavPrc_sal_Link = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
            if ( DateTimeUtil.TDiff( AV5AHORA, A157PRC_FIN) > 600 )
            {
               edtPRC_FIN_Backcolor = GXUtil.RGB( 255, 0, 0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
               edtPRC_MSG_Backcolor = GXUtil.RGB( 255, 0, 0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
               edtavTexto_procesos_Forecolor = GXUtil.RGB( 255, 0, 0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTexto_procesos_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTexto_procesos_Forecolor), 9, 0)));
               AV12TEXTO_PROCESOS = "Existen Procesos Demorados." ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12TEXTO_PROCESOS", AV12TEXTO_PROCESOS);
               if ( ( DateTimeUtil.TDiff( AV5AHORA, A97PRC_EML) > 300 ) || (DateTime.MinValue==A97PRC_EML) )
               {
               }
            }
            else
            {
               if ( ( A158PRC_EST == 7 ) || ( A158PRC_EST == 6 ) )
               {
                  edtPRC_FIN_Backcolor = GXUtil.RGB( 255, 217, 100) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
                  edtPRC_MSG_Backcolor = GXUtil.RGB( 255, 217, 100) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
               }
               else
               {
                  edtPRC_FIN_Backcolor = GXUtil.RGB( 255, 255, 200) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
                  edtPRC_MSG_Backcolor = GXUtil.RGB( 255, 255, 200) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
               }
            }
            if ( StringUtil.StrCmp(A159PRC_SAL, "    ") == 0 )
            {
               AV9PRC_SAL = "En Proceso..." ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            }
         }
         else if ( A158PRC_EST == 3 )
         {
            edtPRC_FIN_Backcolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
            edtPRC_MSG_Backcolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
            edtavTexto_procesos_Forecolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTexto_procesos_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTexto_procesos_Forecolor), 9, 0)));
            AV12TEXTO_PROCESOS = "Existen Procesos Demorados." ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12TEXTO_PROCESOS", AV12TEXTO_PROCESOS);
            if ( StringUtil.StrCmp(A159PRC_SAL, "    ") == 0 )
            {
               AV9PRC_SAL = "Proceso Demorado/Suspendido." ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            }
            edtavPrc_sal_Link = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
         }
         else if ( A158PRC_EST == 0 )
         {
            if ( DateTimeUtil.TDiff( AV5AHORA, A157PRC_FIN) > 1200 )
            {
               if ( ( DateTimeUtil.TDiff( AV5AHORA, A97PRC_EML) > 300 ) || (DateTime.MinValue==A97PRC_EML) )
               {
               }
            }
            else
            {
               edtPRC_FIN_Backcolor = GXUtil.RGB( 243, 243, 243) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
               edtPRC_MSG_Backcolor = GXUtil.RGB( 243, 243, 243) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
            }
            AV9PRC_SAL = "" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            edtavPrc_sal_Link = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
         }
         else if ( ( A158PRC_EST == 2 ) || ( A158PRC_EST == 9 ) )
         {
            edtPRC_FIN_Backcolor = GXUtil.RGB( 200, 255, 200) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_FIN_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_FIN_Backcolor), 9, 0)));
            edtPRC_MSG_Backcolor = GXUtil.RGB( 200, 255, 200) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_MSG_Internalname, "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRC_MSG_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(StringUtil.Substring( A159PRC_SAL, 1, 23), "c:\\inetpub\\wwwroot\\RPT\\") == 0 )
            {
               AV9PRC_SAL = StringUtil.Substring( A159PRC_SAL, 19, 80) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
               edtavPrc_sal_Link = AV9PRC_SAL ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
            }
            else if ( StringUtil.StrCmp(StringUtil.Substring( A159PRC_SAL, 1, 16), "E:\\INTRANET\\RPT\\") == 0 )
            {
               AV9PRC_SAL = StringUtil.Substring( A159PRC_SAL, 12, 80) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
               AV9PRC_SAL = "\\RPT03" + StringUtil.Substring( AV9PRC_SAL, 5, 80) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
               edtavPrc_sal_Link = AV9PRC_SAL ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
            }
            else
            {
               AV9PRC_SAL = "" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
               edtavPrc_sal_Link = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
            }
            if ( StringUtil.StrCmp(A159PRC_SAL, "    ") == 0 )
            {
               AV9PRC_SAL = A159PRC_SAL ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PRC_SAL", AV9PRC_SAL);
            }
            edtavPrc_sal_Linktarget = "_BLANK" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Linktarget", edtavPrc_sal_Linktarget);
            edtavPrc_sal_Link = AV9PRC_SAL ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPrc_sal_Internalname, "Link", edtavPrc_sal_Link);
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 47 ;
         }
         if ( ( subGrid_usuario_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID_USUARIO_nCurrentRecord >= GRID_USUARIO_nFirstRecordOnPage ) && ( GRID_USUARIO_nCurrentRecord < GRID_USUARIO_nFirstRecordOnPage + subGrid_usuario_Recordsperpage( ) ) ) )
         {
            sendrow_473( ) ;
         }
         GRID_USUARIO_nCurrentRecord = (int)(GRID_USUARIO_nCurrentRecord+1) ;
      }

      protected void wb_table1_3_202( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Procesos Activos", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HPRC000_.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Renovar", "Renovar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "EREFRESH.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'" + sGXsfl_14_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "background:transparent" ;
            context.WriteHtmlText( "<div id=\""+edtavAhora_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavAhora_Internalname, context.localUtil.Format(AV5AHORA, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, edtavAhora_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV5AHORA, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(8);\"", 0, edtavAhora_Jsonclick, "", 0, 1, 1, true, "right", "HLP_HPRC000_.htm");
            GxWebStd.gx_bitmap( context, edtavAhora_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtavAhora_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_HPRC000_.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'" + sGXsfl_14_idx + "',0)\"" ;
            ClassString = "desc_programa" ;
            StyleString = "color:" + context.BuildHTMLColor( edtavTexto_procesos_Forecolor) + ";" + "background:transparent" ;
            GxWebStd.gx_single_line_edit( context, edtavTexto_procesos_Internalname, StringUtil.RTrim( AV12TEXTO_PROCESOS), "", 30, "chr", 1, "row", 30, 1, edtavTexto_procesos_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV12TEXTO_PROCESOS, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(9);\"", 0, edtavTexto_procesos_Jsonclick, "", 0, 1, 1, true, "left", "HLP_HPRC000_.htm");
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /*  Grid Control  */
            Grid_activosContainer.SetWrapped(nGXWrapped);
            if ( Grid_activosContainer.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid_activos_Internalname, subGrid_activos_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_activos_Backcolorstyle == 0 )
               {
                  subGrid_activos_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid_activos_Class) > 0 )
                  {
                     subGrid_activos_Linesclass = subGrid_activos_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid_activos_Titlebackstyle = 1 ;
                  if ( subGrid_activos_Backcolorstyle == 1 )
                  {
                     subGrid_activos_Titlebackcolor = subGrid_activos_Allbackcolor ;
                     if ( StringUtil.Len( subGrid_activos_Class) > 0 )
                     {
                        subGrid_activos_Linesclass = subGrid_activos_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_activos_Class) > 0 )
                     {
                        subGrid_activos_Linesclass = subGrid_activos_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_activos_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Proceso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_activos_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_activos_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Ingreso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_activos_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_activos_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_activos_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Inicio Proc.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_activos_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Ult. Novedad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_activos_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Mensaje") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_activos_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "HORA ENVIO MAIL SOPORTE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid_activosContainer.Clear();
               Grid_activosContainer.SetWrapped(nGXWrapped);
               Grid_activosContainer.AddObjectProperty("GridName", "Grid_activos");
               Grid_activosContainer.AddObjectProperty("Class", "Grid");
               Grid_activosContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid_activosContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid_activosContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_activos_Backcolorstyle), 1, 0, ".", "")));
               Grid_activosContainer.AddObjectProperty("CmpContext", "");
               Grid_activosContainer.AddObjectProperty("InMasterPage", "false");
               Grid_activosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_activosColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A79PRC_NRO), 10, 0, ".", "")));
               Grid_activosContainer.AddColumnProperties(Grid_activosColumn);
               Grid_activosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_activosColumn.AddObjectProperty("Value", StringUtil.RTrim( A94PRC_USR));
               Grid_activosContainer.AddColumnProperties(Grid_activosColumn);
               Grid_activosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_activosColumn.AddObjectProperty("Value", context.localUtil.Format(A92PRC_ING, "99/99/99 99:99"));
               Grid_activosContainer.AddColumnProperties(Grid_activosColumn);
               Grid_activosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_activosColumn.AddObjectProperty("Value", StringUtil.RTrim( A95PRC_DES));
               Grid_activosContainer.AddColumnProperties(Grid_activosColumn);
               Grid_activosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_activosColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A158PRC_EST), 1, 0, ".", "")));
               Grid_activosContainer.AddColumnProperties(Grid_activosColumn);
               Grid_activosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_activosColumn.AddObjectProperty("Value", context.localUtil.Format(A96PRC_INI, "99/99/99 99:99"));
               Grid_activosContainer.AddColumnProperties(Grid_activosColumn);
               Grid_activosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_activosColumn.AddObjectProperty("Value", context.localUtil.Format(A157PRC_FIN, "99/99/99 99:99"));
               Grid_activosColumn.AddObjectProperty("Backcolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRC_FIN_Backcolor), 9, 0, ".", "")));
               Grid_activosContainer.AddColumnProperties(Grid_activosColumn);
               Grid_activosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_activosColumn.AddObjectProperty("Value", StringUtil.RTrim( A161PRC_MSG));
               Grid_activosColumn.AddObjectProperty("Backcolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRC_MSG_Backcolor), 9, 0, ".", "")));
               Grid_activosContainer.AddColumnProperties(Grid_activosColumn);
               Grid_activosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_activosColumn.AddObjectProperty("Value", context.localUtil.Format(A97PRC_EML, "99/99/99 99:99"));
               Grid_activosContainer.AddColumnProperties(Grid_activosColumn);
               Grid_activosContainer.AddObjectProperty("Allowselection", "false");
               Grid_activosContainer.AddObjectProperty("Allowcollapsing", "false");
               Grid_activosContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_activos_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 14 )
         {
            wbEnd = 0 ;
            nRC_Grid_activos = (short)(nGXsfl_14_idx-1) ;
            if ( Grid_activosContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid_activosContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid_activos", (Object)(Grid_activosContainer));
               GxWebStd.gx_hidden_field( context, "Grid_activosContainerData", Grid_activosContainer.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid_activosContainerData"+"V", Grid_activosContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid_activosContainerData"+"V"+"\" value='"+Grid_activosContainer.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Procesos del Usuario", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_HPRC000_.htm");
            /* Single line edit */
            ClassString = "desc_programa" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:10.0pt; font-weight:bold; font-style:normal; color:#6AACC2; background:transparent" ;
            GxWebStd.gx_single_line_edit( context, edtavUsuario_Internalname, StringUtil.RTrim( AV13USUARIO), "", 16, "chr", 1, "row", 16, 1, edtavUsuario_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV13USUARIO, "@!")), "", 0, edtavUsuario_Jsonclick, "", 0, 1, 1, true, "left", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"height:41px\">") ;
            wb_table2_30_202( true) ;
         }
         else
         {
            wb_table2_30_202( false) ;
         }
         return  ;
      }

      protected void wb_table2_30_202e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"height:213px\">") ;
            /*  Grid Control  */
            Grid_usuarioContainer.SetWrapped(nGXWrapped);
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid_usuario_Internalname, subGrid_usuario_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_usuario_Backcolorstyle == 0 )
               {
                  subGrid_usuario_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid_usuario_Class) > 0 )
                  {
                     subGrid_usuario_Linesclass = subGrid_usuario_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid_usuario_Titlebackstyle = 1 ;
                  if ( subGrid_usuario_Backcolorstyle == 1 )
                  {
                     subGrid_usuario_Titlebackcolor = subGrid_usuario_Allbackcolor ;
                     if ( StringUtil.Len( subGrid_usuario_Class) > 0 )
                     {
                        subGrid_usuario_Linesclass = subGrid_usuario_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_usuario_Class) > 0 )
                     {
                        subGrid_usuario_Linesclass = subGrid_usuario_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Elim.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Número") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Ingreso Proceso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Inicio Proceso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Resultado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Ultima Novedad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Mensaje") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_usuario_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid_usuarioContainer.Clear();
               Grid_usuarioContainer.SetWrapped(nGXWrapped);
               Grid_usuarioContainer.AddObjectProperty("GridName", "Grid_usuario");
               Grid_usuarioContainer.AddObjectProperty("Class", "Grid");
               Grid_usuarioContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid_usuarioContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid_usuarioContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_usuario_Backcolorstyle), 1, 0, ".", "")));
               Grid_usuarioContainer.AddObjectProperty("CmpContext", "");
               Grid_usuarioContainer.AddObjectProperty("InMasterPage", "false");
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", StringUtil.RTrim( AV7ELIMINAR));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A79PRC_NRO), 10, 0, ".", "")));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", context.localUtil.Format(A92PRC_ING, "99/99/99 99:99"));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", StringUtil.RTrim( A95PRC_DES));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A158PRC_EST), 1, 0, ".", "")));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", context.localUtil.Format(A96PRC_INI, "99/99/99 99:99"));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", StringUtil.RTrim( AV9PRC_SAL));
               Grid_usuarioColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavPrc_sal_Enabled), 5, 0, ".", "")));
               Grid_usuarioColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavPrc_sal_Link));
               Grid_usuarioColumn.AddObjectProperty("Linktarget", StringUtil.RTrim( edtavPrc_sal_Linktarget));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", context.localUtil.Format(A157PRC_FIN, "99/99/99 99:99"));
               Grid_usuarioColumn.AddObjectProperty("Backcolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRC_FIN_Backcolor), 9, 0, ".", "")));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", StringUtil.RTrim( A161PRC_MSG));
               Grid_usuarioColumn.AddObjectProperty("Backcolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRC_MSG_Backcolor), 9, 0, ".", "")));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid_usuarioColumn.AddObjectProperty("Value", StringUtil.RTrim( A94PRC_USR));
               Grid_usuarioContainer.AddColumnProperties(Grid_usuarioColumn);
               Grid_usuarioContainer.AddObjectProperty("Allowselection", "false");
               Grid_usuarioContainer.AddObjectProperty("Allowcollapsing", "false");
               Grid_usuarioContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_usuario_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 47 )
         {
            wbEnd = 0 ;
            nRC_Grid_usuario = (short)(nGXsfl_47_idx-1) ;
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid_usuarioContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid_usuario", (Object)(Grid_usuarioContainer));
               GxWebStd.gx_hidden_field( context, "Grid_usuarioContainerData", Grid_usuarioContainer.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid_usuarioContainerData"+"V", Grid_usuarioContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid_usuarioContainerData"+"V"+"\" value='"+Grid_usuarioContainer.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            wb_table3_60_202( true) ;
         }
         else
         {
            wb_table3_60_202( false) ;
         }
         return  ;
      }

      protected void wb_table3_60_202e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_202e( true) ;
         }
         else
         {
            wb_table1_3_202e( false) ;
         }
      }

      protected void wb_table3_60_202( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "BtnFirst" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_first1_Internalname, "|<", "|<", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_first1_Jsonclick, "E\\'FIRST\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"" ;
            ClassString = "BtnPrevious" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_previous1_Internalname, "<", "<", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_previous1_Jsonclick, "E\\'PREVIOUS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "BtnNext" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_next1_Internalname, ">", ">", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_next1_Jsonclick, "E\\'NEXT\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"" ;
            ClassString = "BtnLast" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_last1_Internalname, ">|", ">|", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_last1_Jsonclick, "E\\'LAST\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_60_202e( true) ;
         }
         else
         {
            wb_table3_60_202e( false) ;
         }
      }

      protected void wb_table2_30_202( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"" ;
            ClassString = "BtnFirst" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_first_Internalname, "|<", "|<", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_first_Jsonclick, "E\\'FIRST\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "BtnPrevious" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_previous_Internalname, "<", "<", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_previous_Jsonclick, "E\\'PREVIOUS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"" ;
            ClassString = "BtnNext" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_next_Internalname, ">", ">", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_next_Jsonclick, "E\\'NEXT\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"" ;
            ClassString = "BtnLast" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_last_Internalname, ">|", ">|", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_last_Jsonclick, "E\\'LAST\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton5_Internalname, "Ejecutar Ahora", "Ejecutar Ahora", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton5_Jsonclick, "E\\'EJECUTAR AHORA\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton4_Internalname, "Eliminar Seleccionados", "Eliminar Seleccionados", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton4_Jsonclick, "E\\'BORRAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton6_Internalname, "Programar Hora de Inicio", "Programar Hora de Inicio", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton6_Jsonclick, "E\\'ESTABLECER HORA DE INICIO\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton7_Internalname, "Ejecutar con Alta Prioridad", "Ejecutar con Alta Prioridad", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton7_Jsonclick, "E\\'ALTA PRIORIDAD\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_HPRC000_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_30_202e( true) ;
         }
         else
         {
            wb_table2_30_202e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13USUARIO = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13USUARIO", AV13USUARIO);
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
         PA202( ) ;
         WS202( ) ;
         WE202( ) ;
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
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1118247");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("hprc000_.js", "?1118248");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_142( )
      {
         WB200( ) ;
         Grid_activosRow = GXWebRow.GetNew(context,Grid_activosContainer) ;
         if ( subGrid_activos_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid_activos_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGrid_activos_Class, "") != 0 )
            {
               subGrid_activos_Linesclass = subGrid_activos_Class+"Odd" ;
            }
         }
         else if ( subGrid_activos_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid_activos_Backstyle = 0 ;
            subGrid_activos_Backcolor = subGrid_activos_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid_activosContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_activos_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGrid_activos_Class, "") != 0 )
            {
               subGrid_activos_Linesclass = subGrid_activos_Class+"Uniform" ;
            }
         }
         else if ( subGrid_activos_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid_activos_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGrid_activos_Class, "") != 0 )
            {
               subGrid_activos_Linesclass = subGrid_activos_Class+"Odd" ;
            }
            subGrid_activos_Backcolor = (int)(0xF0F0F0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid_activosContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_activos_Backcolor), 9, 0)));
         }
         else if ( subGrid_activos_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid_activos_Backstyle = 1 ;
            if ( ((int)(nGXsfl_14_idx) % (2)) == 0 )
            {
               subGrid_activos_Backcolor = (int)(0xE5E5E5) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid_activosContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_activos_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid_activos_Class, "") != 0 )
               {
                  subGrid_activos_Linesclass = subGrid_activos_Class+"Even" ;
               }
            }
            else
            {
               subGrid_activos_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid_activosContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_activos_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid_activos_Class, "") != 0 )
               {
                  subGrid_activos_Linesclass = subGrid_activos_Class+"Odd" ;
               }
            }
         }
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subGrid_activos_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( ">") ;
         }
         /* Subfile cell */
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid_activosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_NRO_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A79PRC_NRO), 10, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A79PRC_NRO), "ZZZZZZZZZ9"),(String)"",(short)0,(String)edtPRC_NRO_Jsonclick,(String)"",(short)14,(short)0,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid_activosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_USR_Internalname,StringUtil.RTrim( A94PRC_USR),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A94PRC_USR, "@!")),(String)"",(short)0,(String)edtPRC_USR_Jsonclick,(String)"",(short)14,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid_activosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_ING_Internalname,context.localUtil.Format(A92PRC_ING, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A92PRC_ING, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRC_ING_Jsonclick,(String)"",(short)14,(short)0,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid_activosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_DES_Internalname,StringUtil.RTrim( A95PRC_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A95PRC_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRC_DES_Jsonclick,(String)"",(short)14,(short)0,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid_activosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_EST_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A158PRC_EST), 1, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A158PRC_EST), "9"),(String)"",(short)0,(String)edtPRC_EST_Jsonclick,(String)"",(short)14,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid_activosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_INI_Internalname,context.localUtil.Format(A96PRC_INI, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A96PRC_INI, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRC_INI_Jsonclick,(String)"",(short)14,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\""+" bgcolor="+context.BuildHTMLColor( edtPRC_FIN_Backcolor)+">") ;
         }
         /* Single line edit */
         ClassString = "" ;
         StyleString = "background:" + context.BuildHTMLColor( edtPRC_FIN_Backcolor) + ";" ;
         ROClassString = ClassString ;
         Grid_activosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_FIN_Internalname,context.localUtil.Format(A157PRC_FIN, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A157PRC_FIN, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRC_FIN_Jsonclick,(String)"",(short)14,(short)0,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\""+" bgcolor="+context.BuildHTMLColor( edtPRC_MSG_Backcolor)+">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "background:" + context.BuildHTMLColor( edtPRC_MSG_Backcolor) + ";" ;
         ROClassString = ClassString ;
         Grid_activosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_MSG_Internalname,StringUtil.RTrim( A161PRC_MSG),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)75,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A161PRC_MSG, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRC_MSG_Jsonclick,(String)"",(short)14,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid_activosContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid_activosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_EML_Internalname,context.localUtil.Format(A97PRC_EML, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A97PRC_EML, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRC_EML_Jsonclick,(String)"",(short)14,(short)1,(short)1,(bool)true,(String)"right"});
         Grid_activosContainer.AddRow(Grid_activosRow);
         nGXsfl_14_idx = (short)(((subGrid_activos_Islastpage==1)&&(nGXsfl_14_idx+1>subGrid_activos_Recordsperpage( )) ? 1 : nGXsfl_14_idx+1)) ;
         sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0") ;
         edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
         edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
         edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
         edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
         edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
         edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
         edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
         edtPRC_EML_Internalname = "PRC_EML_"+sGXsfl_14_idx ;
         /* End function sendrow_142 */
      }

      protected void sendrow_473( )
      {
         WB200( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_47_idx <= subGrid_usuario_Recordsperpage( ) * 1 ) )
         {
            Grid_usuarioRow = GXWebRow.GetNew(context,Grid_usuarioContainer) ;
            if ( subGrid_usuario_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_usuario_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid_usuario_Class, "") != 0 )
               {
                  subGrid_usuario_Linesclass = subGrid_usuario_Class+"Odd" ;
               }
            }
            else if ( subGrid_usuario_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_usuario_Backstyle = 0 ;
               subGrid_usuario_Backcolor = subGrid_usuario_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid_usuarioContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_usuario_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid_usuario_Class, "") != 0 )
               {
                  subGrid_usuario_Linesclass = subGrid_usuario_Class+"Uniform" ;
               }
            }
            else if ( subGrid_usuario_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_usuario_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid_usuario_Class, "") != 0 )
               {
                  subGrid_usuario_Linesclass = subGrid_usuario_Class+"Odd" ;
               }
               subGrid_usuario_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid_usuarioContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_usuario_Backcolor), 9, 0)));
            }
            else if ( subGrid_usuario_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_usuario_Backstyle = 1 ;
               if ( ((int)(nGXsfl_47_idx) % (2)) == 0 )
               {
                  subGrid_usuario_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid_usuarioContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_usuario_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid_usuario_Class, "") != 0 )
                  {
                     subGrid_usuario_Linesclass = subGrid_usuario_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid_usuario_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid_usuarioContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_usuario_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid_usuario_Class, "") != 0 )
                  {
                     subGrid_usuario_Linesclass = subGrid_usuario_Class+"Odd" ;
                  }
               }
            }
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid_usuario_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavEliminar.Enabled!=0)&&(chkavEliminar.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 48,'',false,'"+sGXsfl_47_idx+"',47)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            Grid_usuarioRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavEliminar_Internalname,(String)AV7ELIMINAR,(String)"",(short)-1,(short)1,(String)"*",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavEliminar.Enabled!=0)&&(chkavEliminar.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(48, this, '*', ' ');gx.evt.onchange(this);\" " : " ")+((chkavEliminar.Enabled!=0)&&(chkavEliminar.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(48);\"" : " ")});
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid_usuarioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_NRO_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A79PRC_NRO), 10, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A79PRC_NRO), "ZZZZZZZZZ9"),(String)"",(short)0,(String)edtPRC_NRO_Jsonclick,(String)"",(short)47,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid_usuarioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_ING_Internalname,context.localUtil.Format(A92PRC_ING, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A92PRC_ING, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRC_ING_Jsonclick,(String)"",(short)47,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid_usuarioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_DES_Internalname,StringUtil.RTrim( A95PRC_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A95PRC_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRC_DES_Jsonclick,(String)"",(short)47,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_47_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PRC_EST_" + sGXsfl_14_idx ;
               edtPRC_EST_Name = GXCCtl ;
               edtPRC_EST_Webtags = "" ;
               cmbPRC_EST.addItem("0", "En espera", 0);
               cmbPRC_EST.addItem("1", "Procesando", 0);
               cmbPRC_EST.addItem("2", "Finalizado", 0);
               cmbPRC_EST.addItem("4", "Procesando Int.", 0);
               cmbPRC_EST.addItem("5", "Interactivo", 0);
               cmbPRC_EST.addItem("6", "Prioritario", 0);
               cmbPRC_EST.addItem("7", "Proc. Alta Prioridad", 0);
            }
            /* ComboBox */
            Grid_usuarioRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPRC_EST,(String)edtPRC_EST_Internalname,StringUtil.Str( (decimal)(A158PRC_EST), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)edtPRC_EST_Jsonclick,(String)"",(String)"",(bool)true});
            edtPRC_EST_Value = StringUtil.Str( (decimal)(A158PRC_EST), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRC_EST_Internalname, "Values", (String)(cmbPRC_EST.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid_usuarioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_INI_Internalname,context.localUtil.Format(A96PRC_INI, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A96PRC_INI, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRC_INI_Jsonclick,(String)"",(short)47,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavPrc_sal_Enabled!=0)&&(edtavPrc_sal_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 54,'',false,'"+sGXsfl_47_idx+"',47)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid_usuarioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavPrc_sal_Internalname,StringUtil.RTrim( AV9PRC_SAL),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)100,(short)-1,(int)edtavPrc_sal_Enabled,(short)0,(short)0,(short)0,(String)edtavPrc_sal_Link,(String)edtavPrc_sal_Linktarget,(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV9PRC_SAL, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavPrc_sal_Enabled!=0)&&(edtavPrc_sal_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavPrc_sal_Enabled!=0)&&(edtavPrc_sal_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(54);\"" : " "),(short)0,(String)edtavPrc_sal_Jsonclick,(String)"",(short)47,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\""+" bgcolor="+context.BuildHTMLColor( edtPRC_FIN_Backcolor)+">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "background:" + context.BuildHTMLColor( edtPRC_FIN_Backcolor) + ";" ;
            ROClassString = ClassString ;
            Grid_usuarioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_FIN_Internalname,context.localUtil.Format(A157PRC_FIN, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A157PRC_FIN, "99/99/99 99:99"),(String)"",(short)0,(String)edtPRC_FIN_Jsonclick,(String)"",(short)47,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\""+" bgcolor="+context.BuildHTMLColor( edtPRC_MSG_Backcolor)+">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "background:" + context.BuildHTMLColor( edtPRC_MSG_Backcolor) + ";" ;
            ROClassString = ClassString ;
            Grid_usuarioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_MSG_Internalname,StringUtil.RTrim( A161PRC_MSG),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)75,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A161PRC_MSG, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRC_MSG_Jsonclick,(String)"",(short)47,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid_usuarioContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid_usuarioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRC_USR_Internalname,StringUtil.RTrim( A94PRC_USR),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A94PRC_USR, "@!")),(String)"",(short)0,(String)edtPRC_USR_Jsonclick,(String)"",(short)47,(short)1,(short)1,(bool)true,(String)"left"});
            Grid_usuarioContainer.AddRow(Grid_usuarioRow);
            nGXsfl_47_idx = (short)(((subGrid_usuario_Islastpage==1)&&(nGXsfl_47_idx+1>subGrid_usuario_Recordsperpage( )) ? 1 : nGXsfl_47_idx+1)) ;
            sGXsfl_47_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_47_idx), 4, 0)), 4, "0") ;
            chkavEliminar_Internalname = "vELIMINAR_"+sGXsfl_47_idx ;
            edtPRC_NRO_Internalname = "PRC_NRO_"+sGXsfl_14_idx ;
            edtPRC_ING_Internalname = "PRC_ING_"+sGXsfl_14_idx ;
            edtPRC_DES_Internalname = "PRC_DES_"+sGXsfl_14_idx ;
            edtPRC_EST_Internalname = "PRC_EST_"+sGXsfl_14_idx ;
            edtPRC_INI_Internalname = "PRC_INI_"+sGXsfl_14_idx ;
            edtavPrc_sal_Internalname = "vPRC_SAL_"+sGXsfl_47_idx ;
            edtPRC_FIN_Internalname = "PRC_FIN_"+sGXsfl_14_idx ;
            edtPRC_MSG_Internalname = "PRC_MSG_"+sGXsfl_14_idx ;
            edtPRC_USR_Internalname = "PRC_USR_"+sGXsfl_14_idx ;
         }
         /* End function sendrow_473 */
      }

      protected void init_default_properties( )
      {
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         bttButton1_Internalname = "BUTTON1" ;
         edtavAhora_Internalname = "vAHORA" ;
         edtavTexto_procesos_Internalname = "vTEXTO_PROCESOS" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavUsuario_Internalname = "vUSUARIO" ;
         bttBtn_first_Internalname = "BTN_FIRST" ;
         bttBtn_previous_Internalname = "BTN_PREVIOUS" ;
         bttBtn_next_Internalname = "BTN_NEXT" ;
         bttBtn_last_Internalname = "BTN_LAST" ;
         bttButton5_Internalname = "BUTTON5" ;
         bttButton4_Internalname = "BUTTON4" ;
         bttButton6_Internalname = "BUTTON6" ;
         bttButton7_Internalname = "BUTTON7" ;
         tblTable3_Internalname = "TABLE3" ;
         bttBtn_first1_Internalname = "BTN_FIRST1" ;
         bttBtn_previous1_Internalname = "BTN_PREVIOUS1" ;
         bttBtn_next1_Internalname = "BTN_NEXT1" ;
         bttBtn_last1_Internalname = "BTN_LAST1" ;
         tblTable2_Internalname = "TABLE2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid_activos_Internalname = "GRID_ACTIVOS" ;
         subGrid_usuario_Internalname = "GRID_USUARIO" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavPrc_sal_Jsonclick = "" ;
         edtavPrc_sal_Visible = -1 ;
         chkavEliminar.Visible = -1 ;
         chkavEliminar.Enabled = 1 ;
         edtPRC_EML_Jsonclick = "" ;
         edtPRC_MSG_Jsonclick = "" ;
         edtPRC_FIN_Jsonclick = "" ;
         edtPRC_INI_Jsonclick = "" ;
         edtPRC_EST_Jsonclick = "" ;
         edtPRC_DES_Jsonclick = "" ;
         edtPRC_ING_Jsonclick = "" ;
         edtPRC_USR_Jsonclick = "" ;
         edtPRC_NRO_Jsonclick = "" ;
         edtavPrc_sal_Enabled = 1 ;
         subGrid_usuario_Class = "Grid" ;
         subGrid_usuario_Backcolorstyle = 3 ;
         edtavUsuario_Jsonclick = "" ;
         edtavUsuario_Enabled = 0 ;
         subGrid_activos_Class = "Grid" ;
         subGrid_activos_Backcolorstyle = 3 ;
         edtavTexto_procesos_Jsonclick = "" ;
         edtavTexto_procesos_Enabled = 1 ;
         edtavAhora_Jsonclick = "" ;
         edtavAhora_Enabled = 1 ;
         edtavPrc_sal_Linktarget = "" ;
         edtavPrc_sal_Link = "" ;
         edtavTexto_procesos_Forecolor = (int)(0x000000) ;
         edtPRC_MSG_Backcolor = (int)(0x0) ;
         edtPRC_FIN_Backcolor = (int)(0x0) ;
         chkavEliminar.Caption = "" ;
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
         wcpOAV13USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         edtavPrc_sal_Internalname = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         A159PRC_SAL = "" ;
         GX_FocusControl = "" ;
         sPrefix = "" ;
         Form = new GXWebForm();
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtPRC_NRO_Internalname = "" ;
         edtPRC_USR_Internalname = "" ;
         edtPRC_ING_Internalname = "" ;
         edtPRC_DES_Internalname = "" ;
         edtPRC_EST_Internalname = "" ;
         edtPRC_INI_Internalname = "" ;
         edtPRC_FIN_Internalname = "" ;
         edtPRC_MSG_Internalname = "" ;
         edtPRC_EML_Internalname = "" ;
         A94PRC_USR = "" ;
         A92PRC_ING = (DateTime)(DateTime.MinValue) ;
         A95PRC_DES = "" ;
         A96PRC_INI = (DateTime)(DateTime.MinValue) ;
         A157PRC_FIN = (DateTime)(DateTime.MinValue) ;
         A161PRC_MSG = "" ;
         A97PRC_EML = (DateTime)(DateTime.MinValue) ;
         chkavEliminar_Internalname = "" ;
         AV7ELIMINAR = "" ;
         edtPRC_EST_Name = "" ;
         edtPRC_EST_Value = "" ;
         AV9PRC_SAL = "" ;
         GXCCtl = "" ;
         edtPRC_EST_Webtags = "" ;
         Grid_activosContainer = new GXWebGrid( context);
         Grid_usuarioContainer = new GXWebGrid( context);
         scmdbuf = "" ;
         H00202_A160PRC_INV = new String[] {""} ;
         H00202_A159PRC_SAL = new String[] {""} ;
         H00202_A97PRC_EML = new DateTime[] {DateTime.MinValue} ;
         H00202_A161PRC_MSG = new String[] {""} ;
         H00202_A157PRC_FIN = new DateTime[] {DateTime.MinValue} ;
         H00202_A96PRC_INI = new DateTime[] {DateTime.MinValue} ;
         H00202_A158PRC_EST = new short[1] ;
         H00202_A95PRC_DES = new String[] {""} ;
         H00202_A92PRC_ING = new DateTime[] {DateTime.MinValue} ;
         H00202_A94PRC_USR = new String[] {""} ;
         H00202_A79PRC_NRO = new long[1] ;
         H00202_A93PRC_NOM = new String[] {""} ;
         A160PRC_INV = "" ;
         A93PRC_NOM = "" ;
         H00203_A160PRC_INV = new String[] {""} ;
         H00203_A97PRC_EML = new DateTime[] {DateTime.MinValue} ;
         H00203_A159PRC_SAL = new String[] {""} ;
         H00203_A94PRC_USR = new String[] {""} ;
         H00203_A161PRC_MSG = new String[] {""} ;
         H00203_A157PRC_FIN = new DateTime[] {DateTime.MinValue} ;
         H00203_A96PRC_INI = new DateTime[] {DateTime.MinValue} ;
         H00203_A158PRC_EST = new short[1] ;
         H00203_A95PRC_DES = new String[] {""} ;
         H00203_A92PRC_ING = new DateTime[] {DateTime.MinValue} ;
         H00203_A79PRC_NRO = new long[1] ;
         H00204_AGRID_USUARIO_nRecordCount = new int[1] ;
         AV5AHORA = (DateTime)(DateTime.MinValue) ;
         AV12TEXTO_PROCESOS = "" ;
         AV14context = new SdtContext(context);
         AV8MENSAJE = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock2_Jsonclick = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         subGrid_activos_Linesclass = "" ;
         Grid_activosColumn = new GXWebColumn();
         lblTextblock3_Jsonclick = "" ;
         subGrid_usuario_Linesclass = "" ;
         GXt_char9 = "" ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid_usuarioColumn = new GXWebColumn();
         bttBtn_first1_Jsonclick = "" ;
         bttBtn_previous1_Jsonclick = "" ;
         bttBtn_next1_Jsonclick = "" ;
         bttBtn_last1_Jsonclick = "" ;
         bttBtn_first_Jsonclick = "" ;
         bttBtn_previous_Jsonclick = "" ;
         bttBtn_next_Jsonclick = "" ;
         bttBtn_last_Jsonclick = "" ;
         bttButton5_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         bttButton6_Jsonclick = "" ;
         bttButton7_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid_activosRow = new GXWebRow();
         ROClassString = "" ;
         Grid_usuarioRow = new GXWebRow();
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hprc000___default(),
            new Object[][] {
                new Object[] {
               H00202_A160PRC_INV, H00202_A159PRC_SAL, H00202_A97PRC_EML, H00202_A161PRC_MSG, H00202_A157PRC_FIN, H00202_A96PRC_INI, H00202_A158PRC_EST, H00202_A95PRC_DES, H00202_A92PRC_ING, H00202_A94PRC_USR,
               H00202_A79PRC_NRO, H00202_A93PRC_NOM
               }
               , new Object[] {
               H00203_A160PRC_INV, H00203_A97PRC_EML, H00203_A159PRC_SAL, H00203_A94PRC_USR, H00203_A161PRC_MSG, H00203_A157PRC_FIN, H00203_A96PRC_INI, H00203_A158PRC_EST, H00203_A95PRC_DES, H00203_A92PRC_ING,
               H00203_A79PRC_NRO
               }
               , new Object[] {
               H00204_AGRID_USUARIO_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavAhora_Enabled = 0 ;
         edtavTexto_procesos_Enabled = 0 ;
         edtavUsuario_Enabled = 0 ;
         edtavPrc_sal_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid_activos ;
      private short nGXsfl_14_idx=1 ;
      private short nRC_Grid_usuario ;
      private short nGXsfl_47_idx=1 ;
      private short initialized ;
      private short nGXWrapped ;
      private short GRID_USUARIO_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A158PRC_EST ;
      private short nDonePA ;
      private short nGXsfl_47_fel_idx=1 ;
      private short AV10SENIAL ;
      private short AV6CUENTA ;
      private short subGrid_activos_Backcolorstyle ;
      private short subGrid_activos_Titlebackstyle ;
      private short subGrid_activos_Collapsed ;
      private short subGrid_usuario_Backcolorstyle ;
      private short subGrid_usuario_Titlebackstyle ;
      private short subGrid_usuario_Collapsed ;
      private short subGrid_activos_Backstyle ;
      private short subGrid_usuario_Backstyle ;
      private int edtavAhora_Enabled ;
      private int edtavTexto_procesos_Enabled ;
      private int edtavUsuario_Enabled ;
      private int edtavPrc_sal_Enabled ;
      private int GRID_USUARIO_nFirstRecordOnPage ;
      private int subGrid_activos_Islastpage ;
      private int subGrid_usuario_Islastpage ;
      private int GRID_ACTIVOS_nFirstRecordOnPage ;
      private int GRID_ACTIVOS_nCurrentRecord ;
      private int GRID_USUARIO_nCurrentRecord ;
      private int GRID_USUARIO_nRecordCount ;
      private int edtPRC_FIN_Backcolor ;
      private int edtPRC_MSG_Backcolor ;
      private int edtavTexto_procesos_Forecolor ;
      private int subGrid_activos_Titlebackcolor ;
      private int subGrid_activos_Allbackcolor ;
      private int subGrid_usuario_Titlebackcolor ;
      private int subGrid_usuario_Allbackcolor ;
      private int idxLst ;
      private int subGrid_activos_Backcolor ;
      private int subGrid_usuario_Backcolor ;
      private int edtavPrc_sal_Visible ;
      private long A79PRC_NRO ;
      private String AV13USUARIO ;
      private String wcpOAV13USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_14_idx="0001" ;
      private String sGXsfl_47_idx="0001" ;
      private String edtavAhora_Internalname ;
      private String edtavTexto_procesos_Internalname ;
      private String edtavUsuario_Internalname ;
      private String edtavPrc_sal_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String A159PRC_SAL ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtPRC_NRO_Internalname ;
      private String edtPRC_USR_Internalname ;
      private String edtPRC_ING_Internalname ;
      private String edtPRC_DES_Internalname ;
      private String edtPRC_EST_Internalname ;
      private String edtPRC_INI_Internalname ;
      private String edtPRC_FIN_Internalname ;
      private String edtPRC_MSG_Internalname ;
      private String edtPRC_EML_Internalname ;
      private String A94PRC_USR ;
      private String A95PRC_DES ;
      private String A161PRC_MSG ;
      private String chkavEliminar_Internalname ;
      private String AV7ELIMINAR ;
      private String edtPRC_EST_Name ;
      private String edtPRC_EST_Value ;
      private String AV9PRC_SAL ;
      private String GXCCtl ;
      private String edtPRC_EST_Webtags ;
      private String scmdbuf ;
      private String A160PRC_INV ;
      private String A93PRC_NOM ;
      private String AV12TEXTO_PROCESOS ;
      private String edtavPrc_sal_Link ;
      private String edtavPrc_sal_Linktarget ;
      private String sGXsfl_47_fel_idx="0001" ;
      private String sGXsfl_14_fel_idx="0001" ;
      private String AV8MENSAJE ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String edtavAhora_Jsonclick ;
      private String edtavTexto_procesos_Jsonclick ;
      private String subGrid_activos_Internalname ;
      private String subGrid_activos_Class ;
      private String subGrid_activos_Linesclass ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavUsuario_Jsonclick ;
      private String subGrid_usuario_Internalname ;
      private String subGrid_usuario_Class ;
      private String subGrid_usuario_Linesclass ;
      private String GXt_char9 ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String tblTable2_Internalname ;
      private String bttBtn_first1_Internalname ;
      private String bttBtn_first1_Jsonclick ;
      private String bttBtn_previous1_Internalname ;
      private String bttBtn_previous1_Jsonclick ;
      private String bttBtn_next1_Internalname ;
      private String bttBtn_next1_Jsonclick ;
      private String bttBtn_last1_Internalname ;
      private String bttBtn_last1_Jsonclick ;
      private String tblTable3_Internalname ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttButton5_Internalname ;
      private String bttButton5_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String bttButton6_Internalname ;
      private String bttButton6_Jsonclick ;
      private String bttButton7_Internalname ;
      private String bttButton7_Jsonclick ;
      private String ROClassString ;
      private String edtPRC_NRO_Jsonclick ;
      private String edtPRC_USR_Jsonclick ;
      private String edtPRC_ING_Jsonclick ;
      private String edtPRC_DES_Jsonclick ;
      private String edtPRC_EST_Jsonclick ;
      private String edtPRC_INI_Jsonclick ;
      private String edtPRC_FIN_Jsonclick ;
      private String edtPRC_MSG_Jsonclick ;
      private String edtPRC_EML_Jsonclick ;
      private String edtavPrc_sal_Jsonclick ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private DateTime A92PRC_ING ;
      private DateTime A96PRC_INI ;
      private DateTime A157PRC_FIN ;
      private DateTime A97PRC_EML ;
      private DateTime AV5AHORA ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXWebGrid Grid_activosContainer ;
      private GXWebGrid Grid_usuarioContainer ;
      private GXWebRow Grid_activosRow ;
      private GXWebRow Grid_usuarioRow ;
      private GXWebColumn Grid_activosColumn ;
      private GXWebColumn Grid_usuarioColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private GXCheckbox chkavEliminar ;
      private GXCombobox cmbPRC_EST ;
      private IDataStoreProvider pr_default ;
      private String[] H00202_A160PRC_INV ;
      private String[] H00202_A159PRC_SAL ;
      private DateTime[] H00202_A97PRC_EML ;
      private String[] H00202_A161PRC_MSG ;
      private DateTime[] H00202_A157PRC_FIN ;
      private DateTime[] H00202_A96PRC_INI ;
      private short[] H00202_A158PRC_EST ;
      private String[] H00202_A95PRC_DES ;
      private DateTime[] H00202_A92PRC_ING ;
      private String[] H00202_A94PRC_USR ;
      private long[] H00202_A79PRC_NRO ;
      private String[] H00202_A93PRC_NOM ;
      private String[] H00203_A160PRC_INV ;
      private DateTime[] H00203_A97PRC_EML ;
      private String[] H00203_A159PRC_SAL ;
      private String[] H00203_A94PRC_USR ;
      private String[] H00203_A161PRC_MSG ;
      private DateTime[] H00203_A157PRC_FIN ;
      private DateTime[] H00203_A96PRC_INI ;
      private short[] H00203_A158PRC_EST ;
      private String[] H00203_A95PRC_DES ;
      private DateTime[] H00203_A92PRC_ING ;
      private long[] H00203_A79PRC_NRO ;
      private int[] H00204_AGRID_USUARIO_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private SdtContext AV14context ;
   }

   public class hprc000___default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00202 ;
          prmH00202 = new Object[] {
          } ;
          Object[] prmH00203 ;
          prmH00203 = new Object[] {
          new Object[] {"@AV13USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH00204 ;
          prmH00204 = new Object[] {
          new Object[] {"@AV13USUARIO",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00202", "SELECT [PRC_INV], [PRC_SAL], [PRC_EML], [PRC_MSG], [PRC_FIN], [PRC_INI], [PRC_EST], [PRC_DES], [PRC_ING], [PRC_USR], [PRC_NRO], [PRC_NOM] FROM [COL000] WITH (NOLOCK) WHERE ([PRC_EST] = 1 or [PRC_EST] = 4 or [PRC_EST] = 5 or [PRC_EST] = 6 or [PRC_EST] = 7) AND ([PRC_INV] = ' ') ORDER BY [PRC_NRO] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00202,11,0,true,false )
             ,new CursorDef("H00203", "SELECT [PRC_INV], [PRC_EML], [PRC_SAL], [PRC_USR], [PRC_MSG], [PRC_FIN], [PRC_INI], [PRC_EST], [PRC_DES], [PRC_ING], [PRC_NRO] FROM [COL000] WITH (NOLOCK) WHERE ([PRC_USR] = @AV13USUARIO or @AV13USUARIO = 'SUPERVISOR' or (@AV13USUARIO = '')) AND ([PRC_INV] = ' ') ORDER BY [PRC_NRO] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00203,11,0,false,false )
             ,new CursorDef("H00204", "SELECT COUNT(*) FROM [COL000] WITH (NOLOCK) WHERE ([PRC_USR] = @AV13USUARIO or @AV13USUARIO = 'SUPERVISOR' or (@AV13USUARIO = '')) AND ([PRC_INV] = ' ') ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00204,1,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 75) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 50) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 16) ;
                ((long[]) buf[10])[0] = rslt.getLong(11) ;
                ((String[]) buf[11])[0] = rslt.getString(12, 30) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 75) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getString(9, 50) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(10) ;
                ((long[]) buf[10])[0] = rslt.getLong(11) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
