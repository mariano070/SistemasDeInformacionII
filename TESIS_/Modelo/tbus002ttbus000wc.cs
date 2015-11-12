/*
               File: TBUS002TTBUS000WC
        Description: TBUS002 TTBUS000 WC
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:3.22
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class tbus002ttbus000wc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tbus002ttbus000wc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tbus002ttbus000wc( IGxContext context )
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

      public void execute( short aP0_TTBUS_RubroBien )
      {
         this.AV7TTBUS_RubroBien = aP0_TTBUS_RubroBien;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
         cmbTTBUS_Estado = new GXCombobox();
         chkTTBUS_Alquilado = new GXCheckbox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  nDynComponent = 1 ;
                  sCompPrefix = GetNextPar( ) ;
                  sSFPrefix = GetNextPar( ) ;
                  AV7TTBUS_RubroBien = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV7TTBUS_RubroBien});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"TTBUS_DESCRIPCION") == 0 )
               {
                  A12TTBUS_Descripcion = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  GXSGATTBUS_DESCRIPCION490( A12TTBUS_Descripcion) ;
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
               {
                  nRC_Grid = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  sGXsfl_12_idx = GetNextPar( ) ;
                  edtavDelete_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
                  AV13Delete = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV13Delete));
                  edtavUpdate_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
                  AV12Update = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV12Update));
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxnrGrid_newrow( nRC_Grid, nGXsfl_12_idx, sGXsfl_12_idx, AV13Delete, AV12Update, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
               {
                  /* GeneXus formulas. */
                  AV16Pgmname = "TBUS002TTBUS000WC" ;
                  context.Gx_err = 0 ;
                  GXCCtl = "TTBUS_ESTADO_" + sGXsfl_12_idx ;
                  cmbTTBUS_Estado.Name = GXCCtl ;
                  cmbTTBUS_Estado.WebTags = "" ;
                  cmbTTBUS_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
                  cmbTTBUS_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
                  cmbTTBUS_Estado.addItem("3", "BAJA A CONFIRMAR", 0);
                  cmbTTBUS_Estado.addItem("4", "BAJA", 0);
                  if ( ( cmbTTBUS_Estado.ItemCount > 0 ) && (0==A23TTBUS_Estado) )
                  {
                     A23TTBUS_Estado = (short)(NumberUtil.Val( cmbTTBUS_Estado.getItemValue(1), ".")) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
                  }
                  GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_12_idx ;
                  chkTTBUS_Alquilado.Name = GXCCtl ;
                  chkTTBUS_Alquilado.WebTags = "" ;
                  chkTTBUS_Alquilado.Caption = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
                  chkTTBUS_Alquilado.CheckedValue = "0" ;
                  Grid_PageSize12 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV7TTBUS_RubroBien = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TTBUS_RubroBien), 4, 0)));
                  edtavDelete_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
                  AV13Delete = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV13Delete));
                  edtavUpdate_Tooltiptext = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
                  AV12Update = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV12Update));
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxgrGrid_refresh( Grid_PageSize12, AV7TTBUS_RubroBien, AV13Delete, AV12Update, sPrefix) ;
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
            PA492( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "TBUS002TTBUS000WC" ;
               context.Gx_err = 0 ;
               WS492( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.WriteHtmlText( "<title>") ;
            context.WriteHtmlText( "TBUS002 TTBUS000 WC") ;
            context.WriteHtmlTextNl( "</title>") ;
            if ( StringUtil.Len( sDynURL) > 0 )
            {
               context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
            }
            define_styles( ) ;
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
         }
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"\""+FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tbus002ttbus000wc.aspx") + "?" + UrlEncode("" +AV7TTBUS_RubroBien)+"\" class=\""+"Form"+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            }
         }
      }

      protected void RenderHtmlCloseForm492( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_Grid", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7TTBUS_RubroBien", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV7TTBUS_RubroBien), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vTTBUS_RUBROBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7TTBUS_RubroBien), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 3, 0, ".", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("tbus002ttbus000wc.js", "?118330");
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
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
      }

      protected void WB490( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tbus002ttbus000wc.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_492( true) ;
         }
         else
         {
            wb_table1_2_492( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_492e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_RubroBien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17TTBUS_RubroBien), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, edtTTBUS_RubroBien_Visible, 0, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A17TTBUS_RubroBien), "ZZZ9"), "", 0, edtTTBUS_RubroBien_Jsonclick, "", 0, 1, 1, true, "right", "HLP_TBUS002TTBUS000WC.htm");
         }
         wbLoad = true ;
      }

      protected void START492( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "TBUS002 TTBUS000 WC", 0) ;
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
            context.wbHandled = 0 ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName") ;
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false ;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP490( ) ;
            }
         }
      }

      protected void WS492( )
      {
         START492( ) ;
         EVT492( ) ;
      }

      protected void EVT492( )
      {
         sXEvt = cgiGet( "_EventName") ;
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName") ;
                     EvtGridId = cgiGet( "_EventGridId") ;
                     EvtRowId = cgiGet( "_EventRowId") ;
                  }
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
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP490( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP490( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E11492 */
                                    E11492 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP490( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP490( ) ;
                              }
                              sEvt = cgiGet( sPrefix+"GRIDPAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'DOINSERT'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP490( ) ;
                              }
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
                              edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
                              edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
                              edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_12_idx ;
                              edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_12_idx ;
                              edtBUS_EMP_Internalname = sPrefix+"BUS_EMP_"+sGXsfl_12_idx ;
                              edtBUS_RUB_Internalname = sPrefix+"BUS_RUB_"+sGXsfl_12_idx ;
                              edtBUS_RUD_Internalname = sPrefix+"BUS_RUD_"+sGXsfl_12_idx ;
                              edtBUS_COD_Internalname = sPrefix+"BUS_COD_"+sGXsfl_12_idx ;
                              edtBUS_PAR_Internalname = sPrefix+"BUS_PAR_"+sGXsfl_12_idx ;
                              edtBUS_DES_Internalname = sPrefix+"BUS_DES_"+sGXsfl_12_idx ;
                              edtBUS_FAD_Internalname = sPrefix+"BUS_FAD_"+sGXsfl_12_idx ;
                              edtBUS_TIP_Internalname = sPrefix+"BUS_TIP_"+sGXsfl_12_idx ;
                              edtBUS_TID_Internalname = sPrefix+"BUS_TID_"+sGXsfl_12_idx ;
                              edtHARDWARE_ID_Internalname = sPrefix+"HARDWARE_ID_"+sGXsfl_12_idx ;
                              edtHARDWARE_DESCRIPCION_Internalname = sPrefix+"HARDWARE_DESCRIPCION_"+sGXsfl_12_idx ;
                              edtHARDWARE_NRO_SERIE_Internalname = sPrefix+"HARDWARE_NRO_SERIE_"+sGXsfl_12_idx ;
                              edtTTBUS_FechaCarga_Internalname = sPrefix+"TTBUS_FECHACARGA_"+sGXsfl_12_idx ;
                              cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_12_idx ;
                              edtTTBUS_CodProveedor_Internalname = sPrefix+"TTBUS_CODPROVEEDOR_"+sGXsfl_12_idx ;
                              edtTTBUS_DesProveedor_Internalname = sPrefix+"TTBUS_DESPROVEEDOR_"+sGXsfl_12_idx ;
                              edtTTBUS_CucProveedor_Internalname = sPrefix+"TTBUS_CUCPROVEEDOR_"+sGXsfl_12_idx ;
                              chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_12_idx ;
                              edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_12_idx ;
                              edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_12_idx ;
                              edtTTBUS_RubroDesc_Internalname = sPrefix+"TTBUS_RUBRODESC_"+sGXsfl_12_idx ;
                              edtTTBUS_ContDocu_Internalname = sPrefix+"TTBUS_CONTDOCU_"+sGXsfl_12_idx ;
                              edtTTBUS_UsuarioAlta_Internalname = sPrefix+"TTBUS_USUARIOALTA_"+sGXsfl_12_idx ;
                              edtTTBUS_MaquinaAlta_Internalname = sPrefix+"TTBUS_MAQUINAALTA_"+sGXsfl_12_idx ;
                              edtTTBUS_Empresa_Internalname = sPrefix+"TTBUS_EMPRESA_"+sGXsfl_12_idx ;
                              edtTTBUS_NroSerie_Internalname = sPrefix+"TTBUS_NROSERIE_"+sGXsfl_12_idx ;
                              AV12Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV12Update));
                              AV13Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV13Delete));
                              A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                              A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                              A8BUS_EMP = StringUtil.Upper( cgiGet( edtBUS_EMP_Internalname)) ;
                              n8BUS_EMP = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A8BUS_EMP", A8BUS_EMP);
                              A1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( edtBUS_RUB_Internalname), ",", ".")) ;
                              n1BUS_RUB = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
                              A61BUS_RUD = cgiGet( edtBUS_RUD_Internalname) ;
                              n61BUS_RUD = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BUS_RUD", A61BUS_RUD);
                              A3BUS_COD = (short)(context.localUtil.CToN( cgiGet( edtBUS_COD_Internalname), ",", ".")) ;
                              n3BUS_COD = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
                              A4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( edtBUS_PAR_Internalname), ",", ".")) ;
                              n4BUS_PAR = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
                              A54BUS_DES = StringUtil.Upper( cgiGet( edtBUS_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A54BUS_DES", A54BUS_DES);
                              A55BUS_FAD = context.localUtil.CToD( cgiGet( edtBUS_FAD_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
                              A56BUS_TIP = (short)(context.localUtil.CToN( cgiGet( edtBUS_TIP_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
                              A59BUS_TID = StringUtil.Upper( cgiGet( edtBUS_TID_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A59BUS_TID", A59BUS_TID);
                              A10HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtHARDWARE_ID_Internalname), ",", ".")) ;
                              n10HARDWARE_ID = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
                              A58HARDWARE_DESCRIPCION = cgiGet( edtHARDWARE_DESCRIPCION_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
                              A9HARDWARE_NRO_SERIE = cgiGet( edtHARDWARE_NRO_SERIE_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
                              A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
                              cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
                              cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
                              A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
                              A27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".")) ;
                              n27TTBUS_CodProveedor = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
                              A30TTBUS_DesProveedor = cgiGet( edtTTBUS_DesProveedor_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
                              A73TTBUS_CucProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CucProveedor_Internalname), ",", ".")) ;
                              n73TTBUS_CucProveedor = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A73TTBUS_CucProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A73TTBUS_CucProveedor), 8, 0)));
                              A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
                              A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
                              A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
                              A18TTBUS_RubroDesc = StringUtil.Upper( cgiGet( edtTTBUS_RubroDesc_Internalname)) ;
                              n18TTBUS_RubroDesc = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
                              A74TTBUS_ContDocu = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_ContDocu_Internalname), ",", ".")) ;
                              n74TTBUS_ContDocu = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
                              A75TTBUS_UsuarioAlta = cgiGet( edtTTBUS_UsuarioAlta_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A75TTBUS_UsuarioAlta", A75TTBUS_UsuarioAlta);
                              A76TTBUS_MaquinaAlta = cgiGet( edtTTBUS_MaquinaAlta_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A76TTBUS_MaquinaAlta", A76TTBUS_MaquinaAlta);
                              A41TTBUS_Empresa = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_Empresa_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41TTBUS_Empresa", StringUtil.Str( (decimal)(A41TTBUS_Empresa), 1, 0));
                              A42TTBUS_NroSerie = cgiGet( edtTTBUS_NroSerie_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A42TTBUS_NroSerie", A42TTBUS_NroSerie);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E12492 */
                                          E12492 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E13492 */
                                          E13492 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E11492 */
                                          E11492 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false ;
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP490( ) ;
                                    }
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                       }
                                    }
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
      }

      protected void WE492( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm492( ) ;
            }
         }
      }

      protected void PA492( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            GXCCtl = "TTBUS_ESTADO_" + sGXsfl_12_idx ;
            cmbTTBUS_Estado.Name = GXCCtl ;
            cmbTTBUS_Estado.WebTags = "" ;
            cmbTTBUS_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
            cmbTTBUS_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
            cmbTTBUS_Estado.addItem("3", "BAJA A CONFIRMAR", 0);
            cmbTTBUS_Estado.addItem("4", "BAJA", 0);
            if ( ( cmbTTBUS_Estado.ItemCount > 0 ) && (0==A23TTBUS_Estado) )
            {
               A23TTBUS_Estado = (short)(NumberUtil.Val( cmbTTBUS_Estado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            }
            GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_12_idx ;
            chkTTBUS_Alquilado.Name = GXCCtl ;
            chkTTBUS_Alquilado.WebTags = "" ;
            chkTTBUS_Alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
            chkTTBUS_Alquilado.CheckedValue = "0" ;
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGATTBUS_DESCRIPCION490( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS_DESCRIPCION_data490( A12TTBUS_Descripcion) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXSGATTBUS_DESCRIPCION_data490( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H00492 */
         pr_default.execute(0, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H00492_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H00492_A12TTBUS_Descripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid_newrow( short nRC_Grid ,
                                      short nGXsfl_12_idx ,
                                      String sGXsfl_12_idx ,
                                      String AV13Delete ,
                                      String AV12Update ,
                                      String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
         edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_12_idx ;
         edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_12_idx ;
         edtBUS_EMP_Internalname = sPrefix+"BUS_EMP_"+sGXsfl_12_idx ;
         edtBUS_RUB_Internalname = sPrefix+"BUS_RUB_"+sGXsfl_12_idx ;
         edtBUS_RUD_Internalname = sPrefix+"BUS_RUD_"+sGXsfl_12_idx ;
         edtBUS_COD_Internalname = sPrefix+"BUS_COD_"+sGXsfl_12_idx ;
         edtBUS_PAR_Internalname = sPrefix+"BUS_PAR_"+sGXsfl_12_idx ;
         edtBUS_DES_Internalname = sPrefix+"BUS_DES_"+sGXsfl_12_idx ;
         edtBUS_FAD_Internalname = sPrefix+"BUS_FAD_"+sGXsfl_12_idx ;
         edtBUS_TIP_Internalname = sPrefix+"BUS_TIP_"+sGXsfl_12_idx ;
         edtBUS_TID_Internalname = sPrefix+"BUS_TID_"+sGXsfl_12_idx ;
         edtHARDWARE_ID_Internalname = sPrefix+"HARDWARE_ID_"+sGXsfl_12_idx ;
         edtHARDWARE_DESCRIPCION_Internalname = sPrefix+"HARDWARE_DESCRIPCION_"+sGXsfl_12_idx ;
         edtHARDWARE_NRO_SERIE_Internalname = sPrefix+"HARDWARE_NRO_SERIE_"+sGXsfl_12_idx ;
         edtTTBUS_FechaCarga_Internalname = sPrefix+"TTBUS_FECHACARGA_"+sGXsfl_12_idx ;
         cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_12_idx ;
         edtTTBUS_CodProveedor_Internalname = sPrefix+"TTBUS_CODPROVEEDOR_"+sGXsfl_12_idx ;
         edtTTBUS_DesProveedor_Internalname = sPrefix+"TTBUS_DESPROVEEDOR_"+sGXsfl_12_idx ;
         edtTTBUS_CucProveedor_Internalname = sPrefix+"TTBUS_CUCPROVEEDOR_"+sGXsfl_12_idx ;
         chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_12_idx ;
         edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_12_idx ;
         edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_12_idx ;
         edtTTBUS_RubroDesc_Internalname = sPrefix+"TTBUS_RUBRODESC_"+sGXsfl_12_idx ;
         edtTTBUS_ContDocu_Internalname = sPrefix+"TTBUS_CONTDOCU_"+sGXsfl_12_idx ;
         edtTTBUS_UsuarioAlta_Internalname = sPrefix+"TTBUS_USUARIOALTA_"+sGXsfl_12_idx ;
         edtTTBUS_MaquinaAlta_Internalname = sPrefix+"TTBUS_MAQUINAALTA_"+sGXsfl_12_idx ;
         edtTTBUS_Empresa_Internalname = sPrefix+"TTBUS_EMPRESA_"+sGXsfl_12_idx ;
         edtTTBUS_NroSerie_Internalname = sPrefix+"TTBUS_NROSERIE_"+sGXsfl_12_idx ;
         while ( nGXsfl_12_idx <= nRC_Grid )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
            edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_12_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_12_idx ;
            edtBUS_EMP_Internalname = sPrefix+"BUS_EMP_"+sGXsfl_12_idx ;
            edtBUS_RUB_Internalname = sPrefix+"BUS_RUB_"+sGXsfl_12_idx ;
            edtBUS_RUD_Internalname = sPrefix+"BUS_RUD_"+sGXsfl_12_idx ;
            edtBUS_COD_Internalname = sPrefix+"BUS_COD_"+sGXsfl_12_idx ;
            edtBUS_PAR_Internalname = sPrefix+"BUS_PAR_"+sGXsfl_12_idx ;
            edtBUS_DES_Internalname = sPrefix+"BUS_DES_"+sGXsfl_12_idx ;
            edtBUS_FAD_Internalname = sPrefix+"BUS_FAD_"+sGXsfl_12_idx ;
            edtBUS_TIP_Internalname = sPrefix+"BUS_TIP_"+sGXsfl_12_idx ;
            edtBUS_TID_Internalname = sPrefix+"BUS_TID_"+sGXsfl_12_idx ;
            edtHARDWARE_ID_Internalname = sPrefix+"HARDWARE_ID_"+sGXsfl_12_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = sPrefix+"HARDWARE_DESCRIPCION_"+sGXsfl_12_idx ;
            edtHARDWARE_NRO_SERIE_Internalname = sPrefix+"HARDWARE_NRO_SERIE_"+sGXsfl_12_idx ;
            edtTTBUS_FechaCarga_Internalname = sPrefix+"TTBUS_FECHACARGA_"+sGXsfl_12_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_12_idx ;
            edtTTBUS_CodProveedor_Internalname = sPrefix+"TTBUS_CODPROVEEDOR_"+sGXsfl_12_idx ;
            edtTTBUS_DesProveedor_Internalname = sPrefix+"TTBUS_DESPROVEEDOR_"+sGXsfl_12_idx ;
            edtTTBUS_CucProveedor_Internalname = sPrefix+"TTBUS_CUCPROVEEDOR_"+sGXsfl_12_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_12_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_12_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_12_idx ;
            edtTTBUS_RubroDesc_Internalname = sPrefix+"TTBUS_RUBRODESC_"+sGXsfl_12_idx ;
            edtTTBUS_ContDocu_Internalname = sPrefix+"TTBUS_CONTDOCU_"+sGXsfl_12_idx ;
            edtTTBUS_UsuarioAlta_Internalname = sPrefix+"TTBUS_USUARIOALTA_"+sGXsfl_12_idx ;
            edtTTBUS_MaquinaAlta_Internalname = sPrefix+"TTBUS_MAQUINAALTA_"+sGXsfl_12_idx ;
            edtTTBUS_Empresa_Internalname = sPrefix+"TTBUS_EMPRESA_"+sGXsfl_12_idx ;
            edtTTBUS_NroSerie_Internalname = sPrefix+"TTBUS_NROSERIE_"+sGXsfl_12_idx ;
         }
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int Grid_PageSize12 ,
                                       short AV7TTBUS_RubroBien ,
                                       String AV13Delete ,
                                       String AV12Update ,
                                       String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid_Rows = (short)(Grid_PageSize12) ;
         RF492( ) ;
         enableOutput();
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxgrGrid_refresh */
      }

      protected void Refresh( )
      {
         RF492( ) ;
         /* End function Refresh */
      }

      protected void RF492( )
      {
         GridContainer.PageSize = subGrid_Recordsperpage( ) ;
         wbStart = 12 ;
         nGXsfl_12_idx = 1 ;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
         edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_12_idx ;
         edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_12_idx ;
         edtBUS_EMP_Internalname = sPrefix+"BUS_EMP_"+sGXsfl_12_idx ;
         edtBUS_RUB_Internalname = sPrefix+"BUS_RUB_"+sGXsfl_12_idx ;
         edtBUS_RUD_Internalname = sPrefix+"BUS_RUD_"+sGXsfl_12_idx ;
         edtBUS_COD_Internalname = sPrefix+"BUS_COD_"+sGXsfl_12_idx ;
         edtBUS_PAR_Internalname = sPrefix+"BUS_PAR_"+sGXsfl_12_idx ;
         edtBUS_DES_Internalname = sPrefix+"BUS_DES_"+sGXsfl_12_idx ;
         edtBUS_FAD_Internalname = sPrefix+"BUS_FAD_"+sGXsfl_12_idx ;
         edtBUS_TIP_Internalname = sPrefix+"BUS_TIP_"+sGXsfl_12_idx ;
         edtBUS_TID_Internalname = sPrefix+"BUS_TID_"+sGXsfl_12_idx ;
         edtHARDWARE_ID_Internalname = sPrefix+"HARDWARE_ID_"+sGXsfl_12_idx ;
         edtHARDWARE_DESCRIPCION_Internalname = sPrefix+"HARDWARE_DESCRIPCION_"+sGXsfl_12_idx ;
         edtHARDWARE_NRO_SERIE_Internalname = sPrefix+"HARDWARE_NRO_SERIE_"+sGXsfl_12_idx ;
         edtTTBUS_FechaCarga_Internalname = sPrefix+"TTBUS_FECHACARGA_"+sGXsfl_12_idx ;
         cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_12_idx ;
         edtTTBUS_CodProveedor_Internalname = sPrefix+"TTBUS_CODPROVEEDOR_"+sGXsfl_12_idx ;
         edtTTBUS_DesProveedor_Internalname = sPrefix+"TTBUS_DESPROVEEDOR_"+sGXsfl_12_idx ;
         edtTTBUS_CucProveedor_Internalname = sPrefix+"TTBUS_CUCPROVEEDOR_"+sGXsfl_12_idx ;
         chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_12_idx ;
         edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_12_idx ;
         edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_12_idx ;
         edtTTBUS_RubroDesc_Internalname = sPrefix+"TTBUS_RUBRODESC_"+sGXsfl_12_idx ;
         edtTTBUS_ContDocu_Internalname = sPrefix+"TTBUS_CONTDOCU_"+sGXsfl_12_idx ;
         edtTTBUS_UsuarioAlta_Internalname = sPrefix+"TTBUS_USUARIOALTA_"+sGXsfl_12_idx ;
         edtTTBUS_MaquinaAlta_Internalname = sPrefix+"TTBUS_MAQUINAALTA_"+sGXsfl_12_idx ;
         edtTTBUS_Empresa_Internalname = sPrefix+"TTBUS_EMPRESA_"+sGXsfl_12_idx ;
         edtTTBUS_NroSerie_Internalname = sPrefix+"TTBUS_NROSERIE_"+sGXsfl_12_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
            edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_12_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_12_idx ;
            edtBUS_EMP_Internalname = sPrefix+"BUS_EMP_"+sGXsfl_12_idx ;
            edtBUS_RUB_Internalname = sPrefix+"BUS_RUB_"+sGXsfl_12_idx ;
            edtBUS_RUD_Internalname = sPrefix+"BUS_RUD_"+sGXsfl_12_idx ;
            edtBUS_COD_Internalname = sPrefix+"BUS_COD_"+sGXsfl_12_idx ;
            edtBUS_PAR_Internalname = sPrefix+"BUS_PAR_"+sGXsfl_12_idx ;
            edtBUS_DES_Internalname = sPrefix+"BUS_DES_"+sGXsfl_12_idx ;
            edtBUS_FAD_Internalname = sPrefix+"BUS_FAD_"+sGXsfl_12_idx ;
            edtBUS_TIP_Internalname = sPrefix+"BUS_TIP_"+sGXsfl_12_idx ;
            edtBUS_TID_Internalname = sPrefix+"BUS_TID_"+sGXsfl_12_idx ;
            edtHARDWARE_ID_Internalname = sPrefix+"HARDWARE_ID_"+sGXsfl_12_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = sPrefix+"HARDWARE_DESCRIPCION_"+sGXsfl_12_idx ;
            edtHARDWARE_NRO_SERIE_Internalname = sPrefix+"HARDWARE_NRO_SERIE_"+sGXsfl_12_idx ;
            edtTTBUS_FechaCarga_Internalname = sPrefix+"TTBUS_FECHACARGA_"+sGXsfl_12_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_12_idx ;
            edtTTBUS_CodProveedor_Internalname = sPrefix+"TTBUS_CODPROVEEDOR_"+sGXsfl_12_idx ;
            edtTTBUS_DesProveedor_Internalname = sPrefix+"TTBUS_DESPROVEEDOR_"+sGXsfl_12_idx ;
            edtTTBUS_CucProveedor_Internalname = sPrefix+"TTBUS_CUCPROVEEDOR_"+sGXsfl_12_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_12_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_12_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_12_idx ;
            edtTTBUS_RubroDesc_Internalname = sPrefix+"TTBUS_RUBRODESC_"+sGXsfl_12_idx ;
            edtTTBUS_ContDocu_Internalname = sPrefix+"TTBUS_CONTDOCU_"+sGXsfl_12_idx ;
            edtTTBUS_UsuarioAlta_Internalname = sPrefix+"TTBUS_USUARIOALTA_"+sGXsfl_12_idx ;
            edtTTBUS_MaquinaAlta_Internalname = sPrefix+"TTBUS_MAQUINAALTA_"+sGXsfl_12_idx ;
            edtTTBUS_Empresa_Internalname = sPrefix+"TTBUS_EMPRESA_"+sGXsfl_12_idx ;
            edtTTBUS_NroSerie_Internalname = sPrefix+"TTBUS_NROSERIE_"+sGXsfl_12_idx ;
            /* Using cursor H00493 */
            pr_default.execute(1, new Object[] {AV7TTBUS_RubroBien});
            nGXsfl_12_idx = 1 ;
            GRID_nEOF = 0 ;
            while ( ( (pr_default.getStatus(1) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) ) )
            {
               A17TTBUS_RubroBien = H00493_A17TTBUS_RubroBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
               A42TTBUS_NroSerie = H00493_A42TTBUS_NroSerie[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A42TTBUS_NroSerie", A42TTBUS_NroSerie);
               A41TTBUS_Empresa = H00493_A41TTBUS_Empresa[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A41TTBUS_Empresa", StringUtil.Str( (decimal)(A41TTBUS_Empresa), 1, 0));
               A76TTBUS_MaquinaAlta = H00493_A76TTBUS_MaquinaAlta[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A76TTBUS_MaquinaAlta", A76TTBUS_MaquinaAlta);
               A75TTBUS_UsuarioAlta = H00493_A75TTBUS_UsuarioAlta[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A75TTBUS_UsuarioAlta", A75TTBUS_UsuarioAlta);
               A74TTBUS_ContDocu = H00493_A74TTBUS_ContDocu[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A74TTBUS_ContDocu", StringUtil.LTrim( StringUtil.Str( (decimal)(A74TTBUS_ContDocu), 8, 0)));
               n74TTBUS_ContDocu = H00493_n74TTBUS_ContDocu[0] ;
               A18TTBUS_RubroDesc = H00493_A18TTBUS_RubroDesc[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               n18TTBUS_RubroDesc = H00493_n18TTBUS_RubroDesc[0] ;
               A38TTBUS_DesPosicion = H00493_A38TTBUS_DesPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               A37TTBUS_CodPosicion = H00493_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A29TTBUS_Alquilado = H00493_A29TTBUS_Alquilado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A73TTBUS_CucProveedor = H00493_A73TTBUS_CucProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A73TTBUS_CucProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A73TTBUS_CucProveedor), 8, 0)));
               n73TTBUS_CucProveedor = H00493_n73TTBUS_CucProveedor[0] ;
               A30TTBUS_DesProveedor = H00493_A30TTBUS_DesProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
               A27TTBUS_CodProveedor = H00493_A27TTBUS_CodProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               n27TTBUS_CodProveedor = H00493_n27TTBUS_CodProveedor[0] ;
               A23TTBUS_Estado = H00493_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A13TTBUS_FechaCarga = H00493_A13TTBUS_FechaCarga[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A9HARDWARE_NRO_SERIE = H00493_A9HARDWARE_NRO_SERIE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
               A58HARDWARE_DESCRIPCION = H00493_A58HARDWARE_DESCRIPCION[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
               A10HARDWARE_ID = H00493_A10HARDWARE_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               n10HARDWARE_ID = H00493_n10HARDWARE_ID[0] ;
               A59BUS_TID = H00493_A59BUS_TID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A59BUS_TID", A59BUS_TID);
               A56BUS_TIP = H00493_A56BUS_TIP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
               A55BUS_FAD = H00493_A55BUS_FAD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
               A54BUS_DES = H00493_A54BUS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A54BUS_DES", A54BUS_DES);
               A4BUS_PAR = H00493_A4BUS_PAR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               n4BUS_PAR = H00493_n4BUS_PAR[0] ;
               A3BUS_COD = H00493_A3BUS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               n3BUS_COD = H00493_n3BUS_COD[0] ;
               A61BUS_RUD = H00493_A61BUS_RUD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BUS_RUD", A61BUS_RUD);
               n61BUS_RUD = H00493_n61BUS_RUD[0] ;
               A1BUS_RUB = H00493_A1BUS_RUB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               n1BUS_RUB = H00493_n1BUS_RUB[0] ;
               A8BUS_EMP = H00493_A8BUS_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A8BUS_EMP", A8BUS_EMP);
               n8BUS_EMP = H00493_n8BUS_EMP[0] ;
               A12TTBUS_Descripcion = H00493_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A11TTBUS_Id = H00493_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A18TTBUS_RubroDesc = H00493_A18TTBUS_RubroDesc[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               n18TTBUS_RubroDesc = H00493_n18TTBUS_RubroDesc[0] ;
               A9HARDWARE_NRO_SERIE = H00493_A9HARDWARE_NRO_SERIE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
               A58HARDWARE_DESCRIPCION = H00493_A58HARDWARE_DESCRIPCION[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
               A61BUS_RUD = H00493_A61BUS_RUD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BUS_RUD", A61BUS_RUD);
               n61BUS_RUD = H00493_n61BUS_RUD[0] ;
               A59BUS_TID = H00493_A59BUS_TID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A59BUS_TID", A59BUS_TID);
               A56BUS_TIP = H00493_A56BUS_TIP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
               A55BUS_FAD = H00493_A55BUS_FAD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
               A54BUS_DES = H00493_A54BUS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A54BUS_DES", A54BUS_DES);
               /* Execute user event: E13492 */
               E13492 ();
               pr_default.readNext(1);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(1) == 101) ? 1 : 0)) ;
            pr_default.close(1);
            wbEnd = 12 ;
            WB490( ) ;
         }
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( ) ;
         if ( ((int)(GRID_nRecordCount) % (subGrid_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         /* Using cursor H00494 */
         pr_default.execute(2, new Object[] {AV7TTBUS_RubroBien});
         GRID_nRecordCount = H00494_AGRID_nRecordCount[0] ;
         pr_default.close(2);
         return GRID_nRecordCount ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(subGrid_Rows*1) ;
            }
            else
            {
               return (int)(subGrid_Rows) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         GRID_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( ) ;
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (int)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (int)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( ) ;
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)(GRID_nRecordCount) % (subGrid_Recordsperpage( ))) == 0 )
            {
               GRID_nFirstRecordOnPage = (int)(GRID_nRecordCount-subGrid_Recordsperpage( )) ;
            }
            else
            {
               GRID_nFirstRecordOnPage = (int)(GRID_nRecordCount-((int)(GRID_nRecordCount) % (subGrid_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID_nFirstRecordOnPage = (int)(subGrid_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID_nFirstRecordOnPage = (int)(subGrid_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP490( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "TBUS002TTBUS000WC" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E12492 */
         E12492 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A17TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_RubroBien_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
            /* Read saved values. */
            nRC_Grid = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid"), ",", ".")) ;
            wcpOAV7TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7TTBUS_RubroBien"), ",", ".")) ;
            GRID_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ",", ".")) ;
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ",", ".")) ;
            subGrid_Rows = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ",", ".")) ;
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
         /* Execute user event: E12492 */
         E12492 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12492( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV16Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)) ;
         }
         subGrid_Rows = 10 ;
         AV12Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV12Update));
         edtavUpdate_Tooltiptext = "Modifica" ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
         AV13Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV13Delete));
         edtavDelete_Tooltiptext = "Eliminar" ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
         edtTTBUS_RubroBien_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtTTBUS_RubroBien_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_RubroBien_Visible), 5, 0)));
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E13492( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("ttbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A11TTBUS_Id) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Link", edtavUpdate_Link);
         edtavDelete_Link = formatLink("ttbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A11TTBUS_Id) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Link", edtavDelete_Link);
         edtBUS_DES_Link = formatLink("viewtbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim(A8BUS_EMP)) + "," + UrlEncode("" +A1BUS_RUB) + "," + UrlEncode("" +A3BUS_COD) + "," + UrlEncode("" +A4BUS_PAR) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBUS_DES_Internalname, "Link", edtBUS_DES_Link);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 12 ;
         }
         if ( ( subGrid_Islastpage == 1 ) || ( subGrid_Rows == 0 ) || ( ( GRID_nCurrentRecord >= GRID_nFirstRecordOnPage ) && ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) )
         {
            sendrow_122( ) ;
         }
         GRID_nCurrentRecord = (int)(GRID_nCurrentRecord+1) ;
      }

      protected void E11492( )
      {
         /* 'DoInsert' Routine */
         context.wjLoc = formatLink("ttbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new SdtTransactionContext(context) ;
         AV10TrnContext.gxTpr_Callerobject = AV16Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV10TrnContext.gxTpr_Callerondelete = true ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV10TrnContext.gxTpr_Transactionname = "TTBUS000" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", (Object)(AV10TrnContext));
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context) ;
         AV11TrnContextAtt.gxTpr_Attributename = "TTBUS_RubroBien" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7TTBUS_RubroBien), 4, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", (Object)(AV11TrnContextAtt));
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV8Session.Set("TrnContext", AV10TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_492( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable_Internalname, tblTable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_492( true) ;
         }
         else
         {
            wb_table2_5_492( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_492e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_492e( true) ;
         }
         else
         {
            wb_table1_2_492e( false) ;
         }
      }

      protected void wb_table2_5_492( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablegridcontainer_Internalname, tblTablegridcontainer_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td colspan=\"1\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "PagingButtons" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, sPrefix+"E\\'DOINSERT\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS002TTBUS000WC.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" colspan=\"2\" >") ;
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "WorkWith", 0, "", "", 4, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1 ;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor ;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Id del bien de uso:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO DE EMPRESA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "RUBRO DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCIPCION RUBRO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NUMERO DE CODIGO DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NUMERO DE PARTIDA DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "FECHA DE ADQUISICION DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO DE TIPO DE BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "BUS_ TID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "HARDWARE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NRO. SERIE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha de Carga:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de uso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cursograma Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "SI/ NO)") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Actual Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Actual Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "del bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de documentación") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de uso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "el bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de Empresa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de Serie") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               GridContainer.Clear();
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Class", "WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(4), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.convertURL( AV12Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.convertURL( AV13Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A12TTBUS_Descripcion));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A8BUS_EMP));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A61BUS_RUD));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A54BUS_DES));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBUS_DES_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A56BUS_TIP), 3, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A59BUS_TID));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A58HARDWARE_DESCRIPCION));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A9HARDWARE_NRO_SERIE));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23TTBUS_Estado), 1, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A30TTBUS_DesProveedor));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A73TTBUS_CucProveedor), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29TTBUS_Alquilado), 1, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A38TTBUS_DesPosicion));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A18TTBUS_RubroDesc));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A74TTBUS_ContDocu), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A75TTBUS_UsuarioAlta));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A76TTBUS_MaquinaAlta));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A41TTBUS_Empresa), 1, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A42TTBUS_NroSerie));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Allowselection", "false");
               GridContainer.AddObjectProperty("Allowcollapsing", "false");
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 12 )
         {
            wbEnd = 0 ;
            nRC_Grid = (short)(nGXsfl_12_idx-1) ;
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
               GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", (Object)(GridContainer));
               GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_492e( true) ;
         }
         else
         {
            wb_table2_5_492e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7TTBUS_RubroBien = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TTBUS_RubroBien), 4, 0)));
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
         PA492( ) ;
         WS492( ) ;
         WE492( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV7TTBUS_RubroBien = (String)((String)getParm(obj,0)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA492( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "tbus002ttbus000wc");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA492( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV7TTBUS_RubroBien = Convert.ToInt16(getParm(obj,2)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TTBUS_RubroBien), 4, 0)));
         }
         wcpOAV7TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7TTBUS_RubroBien"), ",", ".")) ;
         if ( ! GetJustCreated( ) && ( ( AV7TTBUS_RubroBien != wcpOAV7TTBUS_RubroBien ) ) )
         {
            setjustcreated();
         }
         wcpOAV7TTBUS_RubroBien = AV7TTBUS_RubroBien ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV7TTBUS_RubroBien = cgiGet( sPrefix+"AV7TTBUS_RubroBien_CTRL") ;
         if ( StringUtil.Len( sCtrlAV7TTBUS_RubroBien) > 0 )
         {
            AV7TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( sCtrlAV7TTBUS_RubroBien), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TTBUS_RubroBien), 4, 0)));
         }
         else
         {
            AV7TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV7TTBUS_RubroBien_PARM"), ",", ".")) ;
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix ;
         sSFPrefix = sPSFPrefix ;
         sPrefix = sCompPrefix + sSFPrefix ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         INITWEB( ) ;
         nDraw = 0 ;
         PA492( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS492( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1 ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WS492( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7TTBUS_RubroBien_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7TTBUS_RubroBien), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7TTBUS_RubroBien)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7TTBUS_RubroBien_CTRL", StringUtil.RTrim( sCtrlAV7TTBUS_RubroBien));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WCParametersSet( ) ;
         WE492( ) ;
         this.cleanup();
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1) ;
         }
         else
         {
            sCtrlName = sGXControl ;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?118451");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("tbus002ttbus000wc.js", "?118451");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_122( )
      {
         WB490( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_12_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer) ;
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd" ;
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0 ;
               subGrid_Backcolor = subGrid_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform" ;
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd" ;
               }
               subGrid_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1 ;
               if ( ((int)(nGXsfl_12_idx) % (2)) == 0 )
               {
                  subGrid_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd" ;
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)"",(String)AV12Update,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavUpdate_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)"",(String)AV13Delete,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavDelete_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_Id_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Descripcion_Internalname,StringUtil.RTrim( A12TTBUS_Descripcion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")),(String)"",(short)0,(String)edtTTBUS_Descripcion_Jsonclick,(String)"",(short)12,(short)1,(short)0,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_EMP_Internalname,StringUtil.RTrim( A8BUS_EMP),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A8BUS_EMP, "!")),(String)"",(short)0,(String)edtBUS_EMP_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_RUB_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A1BUS_RUB), "ZZZ9"),(String)"",(short)0,(String)edtBUS_RUB_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_RUD_Internalname,StringUtil.RTrim( A61BUS_RUD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A61BUS_RUD, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtBUS_RUD_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A3BUS_COD), "ZZZ9"),(String)"",(short)0,(String)edtBUS_COD_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_PAR_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A4BUS_PAR), "Z9"),(String)"",(short)0,(String)edtBUS_PAR_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_DES_Internalname,StringUtil.RTrim( A54BUS_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtBUS_DES_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A54BUS_DES, "@!")),(String)"",(short)0,(String)edtBUS_DES_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_FAD_Internalname,context.localUtil.Format(A55BUS_FAD, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A55BUS_FAD, "99/99/9999"),(String)"",(short)0,(String)edtBUS_FAD_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_TIP_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A56BUS_TIP), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A56BUS_TIP), "ZZ9"),(String)"",(short)0,(String)edtBUS_TIP_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_TID_Internalname,StringUtil.RTrim( A59BUS_TID),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A59BUS_TID, "@!")),(String)"",(short)0,(String)edtBUS_TID_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A10HARDWARE_ID), "ZZZ9"),(String)"",(short)0,(String)edtHARDWARE_ID_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_DESCRIPCION_Internalname,StringUtil.RTrim( A58HARDWARE_DESCRIPCION),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)40,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A58HARDWARE_DESCRIPCION, "")),(String)"",(short)0,(String)edtHARDWARE_DESCRIPCION_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_NRO_SERIE_Internalname,StringUtil.RTrim( A9HARDWARE_NRO_SERIE),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A9HARDWARE_NRO_SERIE, "")),(String)"",(short)0,(String)edtHARDWARE_NRO_SERIE_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaCarga_Internalname,context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaCarga_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_12_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TTBUS_ESTADO_" + sGXsfl_12_idx ;
               cmbTTBUS_Estado.Name = GXCCtl ;
               cmbTTBUS_Estado.WebTags = "" ;
               cmbTTBUS_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
               cmbTTBUS_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
               cmbTTBUS_Estado.addItem("3", "BAJA A CONFIRMAR", 0);
               cmbTTBUS_Estado.addItem("4", "BAJA", 0);
               if ( ( cmbTTBUS_Estado.ItemCount > 0 ) && (0==A23TTBUS_Estado) )
               {
                  A23TTBUS_Estado = (short)(NumberUtil.Val( cmbTTBUS_Estado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTTBUS_Estado,(String)cmbTTBUS_Estado_Internalname,StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbTTBUS_Estado_Jsonclick,(String)"",(String)"",(bool)true});
            cmbTTBUS_Estado.CurrentValue = StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbTTBUS_Estado_Internalname, "Values", (String)(cmbTTBUS_Estado.ToJavascriptSource()));
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodProveedor_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A27TTBUS_CodProveedor), "ZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_CodProveedor_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesProveedor_Internalname,StringUtil.RTrim( A30TTBUS_DesProveedor),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesProveedor_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CucProveedor_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A73TTBUS_CucProveedor), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A73TTBUS_CucProveedor), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_CucProveedor_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkTTBUS_Alquilado_Internalname,StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0),(String)"",(short)-1,(short)0,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodPosicion_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A37TTBUS_CodPosicion), "ZZ9"),(String)"",(short)0,(String)edtTTBUS_CodPosicion_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesPosicion_Internalname,StringUtil.RTrim( A38TTBUS_DesPosicion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesPosicion_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_RubroDesc_Internalname,StringUtil.RTrim( A18TTBUS_RubroDesc),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A18TTBUS_RubroDesc, "@!")),(String)"",(short)0,(String)edtTTBUS_RubroDesc_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_ContDocu_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A74TTBUS_ContDocu), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A74TTBUS_ContDocu), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_ContDocu_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_UsuarioAlta_Internalname,StringUtil.RTrim( A75TTBUS_UsuarioAlta),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A75TTBUS_UsuarioAlta, "XXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_UsuarioAlta_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_MaquinaAlta_Internalname,StringUtil.RTrim( A76TTBUS_MaquinaAlta),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A76TTBUS_MaquinaAlta, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_MaquinaAlta_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Empresa_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A41TTBUS_Empresa), 1, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A41TTBUS_Empresa), "9"),(String)"",(short)0,(String)edtTTBUS_Empresa_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_NroSerie_Internalname,StringUtil.RTrim( A42TTBUS_NroSerie),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A42TTBUS_NroSerie, "")),(String)"",(short)0,(String)edtTTBUS_NroSerie_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_12_idx ;
            edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_12_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_12_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_12_idx ;
            edtBUS_EMP_Internalname = sPrefix+"BUS_EMP_"+sGXsfl_12_idx ;
            edtBUS_RUB_Internalname = sPrefix+"BUS_RUB_"+sGXsfl_12_idx ;
            edtBUS_RUD_Internalname = sPrefix+"BUS_RUD_"+sGXsfl_12_idx ;
            edtBUS_COD_Internalname = sPrefix+"BUS_COD_"+sGXsfl_12_idx ;
            edtBUS_PAR_Internalname = sPrefix+"BUS_PAR_"+sGXsfl_12_idx ;
            edtBUS_DES_Internalname = sPrefix+"BUS_DES_"+sGXsfl_12_idx ;
            edtBUS_FAD_Internalname = sPrefix+"BUS_FAD_"+sGXsfl_12_idx ;
            edtBUS_TIP_Internalname = sPrefix+"BUS_TIP_"+sGXsfl_12_idx ;
            edtBUS_TID_Internalname = sPrefix+"BUS_TID_"+sGXsfl_12_idx ;
            edtHARDWARE_ID_Internalname = sPrefix+"HARDWARE_ID_"+sGXsfl_12_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = sPrefix+"HARDWARE_DESCRIPCION_"+sGXsfl_12_idx ;
            edtHARDWARE_NRO_SERIE_Internalname = sPrefix+"HARDWARE_NRO_SERIE_"+sGXsfl_12_idx ;
            edtTTBUS_FechaCarga_Internalname = sPrefix+"TTBUS_FECHACARGA_"+sGXsfl_12_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_12_idx ;
            edtTTBUS_CodProveedor_Internalname = sPrefix+"TTBUS_CODPROVEEDOR_"+sGXsfl_12_idx ;
            edtTTBUS_DesProveedor_Internalname = sPrefix+"TTBUS_DESPROVEEDOR_"+sGXsfl_12_idx ;
            edtTTBUS_CucProveedor_Internalname = sPrefix+"TTBUS_CUCPROVEEDOR_"+sGXsfl_12_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_12_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_12_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_12_idx ;
            edtTTBUS_RubroDesc_Internalname = sPrefix+"TTBUS_RUBRODESC_"+sGXsfl_12_idx ;
            edtTTBUS_ContDocu_Internalname = sPrefix+"TTBUS_CONTDOCU_"+sGXsfl_12_idx ;
            edtTTBUS_UsuarioAlta_Internalname = sPrefix+"TTBUS_USUARIOALTA_"+sGXsfl_12_idx ;
            edtTTBUS_MaquinaAlta_Internalname = sPrefix+"TTBUS_MAQUINAALTA_"+sGXsfl_12_idx ;
            edtTTBUS_Empresa_Internalname = sPrefix+"TTBUS_EMPRESA_"+sGXsfl_12_idx ;
            edtTTBUS_NroSerie_Internalname = sPrefix+"TTBUS_NROSERIE_"+sGXsfl_12_idx ;
         }
         /* End function sendrow_122 */
      }

      protected void init_default_properties( )
      {
         imgInsert_Internalname = sPrefix+"INSERT" ;
         tblTablegridcontainer_Internalname = sPrefix+"TABLEGRIDCONTAINER" ;
         tblTable_Internalname = sPrefix+"TABLE" ;
         edtTTBUS_RubroBien_Internalname = sPrefix+"TTBUS_RUBROBIEN" ;
         Form.Internalname = sPrefix+"FORM" ;
         subGrid_Internalname = sPrefix+"GRID" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtTTBUS_NroSerie_Jsonclick = "" ;
         edtTTBUS_Empresa_Jsonclick = "" ;
         edtTTBUS_MaquinaAlta_Jsonclick = "" ;
         edtTTBUS_UsuarioAlta_Jsonclick = "" ;
         edtTTBUS_ContDocu_Jsonclick = "" ;
         edtTTBUS_RubroDesc_Jsonclick = "" ;
         edtTTBUS_DesPosicion_Jsonclick = "" ;
         edtTTBUS_CodPosicion_Jsonclick = "" ;
         edtTTBUS_CucProveedor_Jsonclick = "" ;
         edtTTBUS_DesProveedor_Jsonclick = "" ;
         edtTTBUS_CodProveedor_Jsonclick = "" ;
         cmbTTBUS_Estado_Jsonclick = "" ;
         edtTTBUS_FechaCarga_Jsonclick = "" ;
         edtHARDWARE_NRO_SERIE_Jsonclick = "" ;
         edtHARDWARE_DESCRIPCION_Jsonclick = "" ;
         edtHARDWARE_ID_Jsonclick = "" ;
         edtBUS_TID_Jsonclick = "" ;
         edtBUS_TIP_Jsonclick = "" ;
         edtBUS_FAD_Jsonclick = "" ;
         edtBUS_DES_Jsonclick = "" ;
         edtBUS_PAR_Jsonclick = "" ;
         edtBUS_COD_Jsonclick = "" ;
         edtBUS_RUD_Jsonclick = "" ;
         edtBUS_RUB_Jsonclick = "" ;
         edtBUS_EMP_Jsonclick = "" ;
         edtTTBUS_Descripcion_Jsonclick = "" ;
         edtTTBUS_Id_Jsonclick = "" ;
         subGrid_Class = "WorkWith" ;
         subGrid_Backcolorstyle = 3 ;
         edtBUS_DES_Link = "" ;
         edtavDelete_Link = "" ;
         edtavUpdate_Link = "" ;
         edtTTBUS_RubroBien_Jsonclick = "" ;
         edtTTBUS_RubroBien_Visible = 1 ;
         subGrid_Rows = 0 ;
         chkTTBUS_Alquilado.Caption = "" ;
         edtavUpdate_Tooltiptext = "Modifica" ;
         edtavDelete_Tooltiptext = "Eliminar" ;
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
         sPrefix = "" ;
         A12TTBUS_Descripcion = "" ;
         edtavDelete_Internalname = "" ;
         AV13Delete = "" ;
         edtavUpdate_Internalname = "" ;
         AV12Update = "" ;
         AV16Pgmname = "" ;
         GXCCtl = "" ;
         chkTTBUS_Alquilado_Internalname = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         ClassString = "" ;
         StyleString = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtTTBUS_Id_Internalname = "" ;
         edtTTBUS_Descripcion_Internalname = "" ;
         edtBUS_EMP_Internalname = "" ;
         edtBUS_RUB_Internalname = "" ;
         edtBUS_RUD_Internalname = "" ;
         edtBUS_COD_Internalname = "" ;
         edtBUS_PAR_Internalname = "" ;
         edtBUS_DES_Internalname = "" ;
         edtBUS_FAD_Internalname = "" ;
         edtBUS_TIP_Internalname = "" ;
         edtBUS_TID_Internalname = "" ;
         edtHARDWARE_ID_Internalname = "" ;
         edtHARDWARE_DESCRIPCION_Internalname = "" ;
         edtHARDWARE_NRO_SERIE_Internalname = "" ;
         edtTTBUS_FechaCarga_Internalname = "" ;
         cmbTTBUS_Estado_Internalname = "" ;
         edtTTBUS_CodProveedor_Internalname = "" ;
         edtTTBUS_DesProveedor_Internalname = "" ;
         edtTTBUS_CucProveedor_Internalname = "" ;
         edtTTBUS_CodPosicion_Internalname = "" ;
         edtTTBUS_DesPosicion_Internalname = "" ;
         edtTTBUS_RubroDesc_Internalname = "" ;
         edtTTBUS_ContDocu_Internalname = "" ;
         edtTTBUS_UsuarioAlta_Internalname = "" ;
         edtTTBUS_MaquinaAlta_Internalname = "" ;
         edtTTBUS_Empresa_Internalname = "" ;
         edtTTBUS_NroSerie_Internalname = "" ;
         A8BUS_EMP = "" ;
         A61BUS_RUD = "" ;
         A54BUS_DES = "" ;
         A55BUS_FAD = DateTime.MinValue ;
         A59BUS_TID = "" ;
         A58HARDWARE_DESCRIPCION = "" ;
         A9HARDWARE_NRO_SERIE = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A30TTBUS_DesProveedor = "" ;
         A38TTBUS_DesPosicion = "" ;
         A18TTBUS_RubroDesc = "" ;
         A75TTBUS_UsuarioAlta = "" ;
         A76TTBUS_MaquinaAlta = "" ;
         A42TTBUS_NroSerie = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l12TTBUS_Descripcion = "" ;
         H00492_A12TTBUS_Descripcion = new String[] {""} ;
         GridContainer = new GXWebGrid( context);
         H00493_A17TTBUS_RubroBien = new short[1] ;
         H00493_A42TTBUS_NroSerie = new String[] {""} ;
         H00493_A41TTBUS_Empresa = new short[1] ;
         H00493_A76TTBUS_MaquinaAlta = new String[] {""} ;
         H00493_A75TTBUS_UsuarioAlta = new String[] {""} ;
         H00493_A74TTBUS_ContDocu = new int[1] ;
         H00493_n74TTBUS_ContDocu = new bool[] {false} ;
         H00493_A18TTBUS_RubroDesc = new String[] {""} ;
         H00493_n18TTBUS_RubroDesc = new bool[] {false} ;
         H00493_A38TTBUS_DesPosicion = new String[] {""} ;
         H00493_A37TTBUS_CodPosicion = new short[1] ;
         H00493_A29TTBUS_Alquilado = new short[1] ;
         H00493_A73TTBUS_CucProveedor = new int[1] ;
         H00493_n73TTBUS_CucProveedor = new bool[] {false} ;
         H00493_A30TTBUS_DesProveedor = new String[] {""} ;
         H00493_A27TTBUS_CodProveedor = new int[1] ;
         H00493_n27TTBUS_CodProveedor = new bool[] {false} ;
         H00493_A23TTBUS_Estado = new short[1] ;
         H00493_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         H00493_A9HARDWARE_NRO_SERIE = new String[] {""} ;
         H00493_A58HARDWARE_DESCRIPCION = new String[] {""} ;
         H00493_A10HARDWARE_ID = new short[1] ;
         H00493_n10HARDWARE_ID = new bool[] {false} ;
         H00493_A59BUS_TID = new String[] {""} ;
         H00493_A56BUS_TIP = new short[1] ;
         H00493_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         H00493_A54BUS_DES = new String[] {""} ;
         H00493_A4BUS_PAR = new short[1] ;
         H00493_n4BUS_PAR = new bool[] {false} ;
         H00493_A3BUS_COD = new short[1] ;
         H00493_n3BUS_COD = new bool[] {false} ;
         H00493_A61BUS_RUD = new String[] {""} ;
         H00493_n61BUS_RUD = new bool[] {false} ;
         H00493_A1BUS_RUB = new short[1] ;
         H00493_n1BUS_RUB = new bool[] {false} ;
         H00493_A8BUS_EMP = new String[] {""} ;
         H00493_n8BUS_EMP = new bool[] {false} ;
         H00493_A12TTBUS_Descripcion = new String[] {""} ;
         H00493_A11TTBUS_Id = new int[1] ;
         H00494_AGRID_nRecordCount = new int[1] ;
         AV10TrnContext = new SdtTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8Session = new GxWebSession( context);
         sStyleString = "" ;
         TempTags = "" ;
         imgInsert_Jsonclick = "" ;
         subGrid_Linesclass = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         GXt_char14 = "" ;
         GXt_char15 = "" ;
         GXt_char16 = "" ;
         GXt_char17 = "" ;
         GXt_char18 = "" ;
         GXt_char19 = "" ;
         GXt_char20 = "" ;
         GXt_char21 = "" ;
         GXt_char22 = "" ;
         GXt_char23 = "" ;
         GXt_char24 = "" ;
         GXt_char25 = "" ;
         GXt_char26 = "" ;
         GXt_char27 = "" ;
         GXt_char28 = "" ;
         GridColumn = new GXWebColumn();
         GXt_char29 = "" ;
         GXt_char30 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV7TTBUS_RubroBien = "" ;
         GridRow = new GXWebRow();
         ROClassString = "" ;
         GXt_char31 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tbus002ttbus000wc__default(),
            new Object[][] {
                new Object[] {
               H00492_A12TTBUS_Descripcion
               }
               , new Object[] {
               H00493_A17TTBUS_RubroBien, H00493_A42TTBUS_NroSerie, H00493_A41TTBUS_Empresa, H00493_A76TTBUS_MaquinaAlta, H00493_A75TTBUS_UsuarioAlta, H00493_A74TTBUS_ContDocu, H00493_n74TTBUS_ContDocu, H00493_A18TTBUS_RubroDesc, H00493_n18TTBUS_RubroDesc, H00493_A38TTBUS_DesPosicion,
               H00493_A37TTBUS_CodPosicion, H00493_A29TTBUS_Alquilado, H00493_A73TTBUS_CucProveedor, H00493_n73TTBUS_CucProveedor, H00493_A30TTBUS_DesProveedor, H00493_A27TTBUS_CodProveedor, H00493_n27TTBUS_CodProveedor, H00493_A23TTBUS_Estado, H00493_A13TTBUS_FechaCarga, H00493_A9HARDWARE_NRO_SERIE,
               H00493_A58HARDWARE_DESCRIPCION, H00493_A10HARDWARE_ID, H00493_n10HARDWARE_ID, H00493_A59BUS_TID, H00493_A56BUS_TIP, H00493_A55BUS_FAD, H00493_A54BUS_DES, H00493_A4BUS_PAR, H00493_n4BUS_PAR, H00493_A3BUS_COD,
               H00493_n3BUS_COD, H00493_A61BUS_RUD, H00493_n61BUS_RUD, H00493_A1BUS_RUB, H00493_n1BUS_RUB, H00493_A8BUS_EMP, H00493_n8BUS_EMP, H00493_A12TTBUS_Descripcion, H00493_A11TTBUS_Id
               }
               , new Object[] {
               H00494_AGRID_nRecordCount
               }
            }
         );
         AV16Pgmname = "TBUS002TTBUS000WC" ;
         /* GeneXus formulas. */
         AV16Pgmname = "TBUS002TTBUS000WC" ;
         context.Gx_err = 0 ;
      }

      private short AV7TTBUS_RubroBien ;
      private short wcpOAV7TTBUS_RubroBien ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_Grid ;
      private short nGXsfl_12_idx=1 ;
      private short A23TTBUS_Estado ;
      private short initialized ;
      private short nGXWrapped ;
      private short GRID_nEOF ;
      private short subGrid_Rows ;
      private short wbEnd ;
      private short wbStart ;
      private short A17TTBUS_RubroBien ;
      private short nDraw ;
      private short nDoneStart ;
      private short A1BUS_RUB ;
      private short A3BUS_COD ;
      private short A4BUS_PAR ;
      private short A56BUS_TIP ;
      private short A10HARDWARE_ID ;
      private short A29TTBUS_Alquilado ;
      private short A37TTBUS_CodPosicion ;
      private short A41TTBUS_Empresa ;
      private short nDonePA ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Collapsed ;
      private short subGrid_Backstyle ;
      private int Grid_PageSize12 ;
      private int GRID_nFirstRecordOnPage ;
      private int edtTTBUS_RubroBien_Visible ;
      private int A11TTBUS_Id ;
      private int A27TTBUS_CodProveedor ;
      private int A73TTBUS_CucProveedor ;
      private int A74TTBUS_ContDocu ;
      private int gxdynajaxindex ;
      private int subGrid_Islastpage ;
      private int GRID_nCurrentRecord ;
      private int GRID_nRecordCount ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_12_idx="0001" ;
      private String edtavDelete_Tooltiptext ;
      private String edtavDelete_Internalname ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavUpdate_Internalname ;
      private String AV16Pgmname ;
      private String GXCCtl ;
      private String chkTTBUS_Alquilado_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String ClassString ;
      private String StyleString ;
      private String edtTTBUS_RubroBien_Internalname ;
      private String edtTTBUS_RubroBien_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtTTBUS_Id_Internalname ;
      private String edtTTBUS_Descripcion_Internalname ;
      private String edtBUS_EMP_Internalname ;
      private String edtBUS_RUB_Internalname ;
      private String edtBUS_RUD_Internalname ;
      private String edtBUS_COD_Internalname ;
      private String edtBUS_PAR_Internalname ;
      private String edtBUS_DES_Internalname ;
      private String edtBUS_FAD_Internalname ;
      private String edtBUS_TIP_Internalname ;
      private String edtBUS_TID_Internalname ;
      private String edtHARDWARE_ID_Internalname ;
      private String edtHARDWARE_DESCRIPCION_Internalname ;
      private String edtHARDWARE_NRO_SERIE_Internalname ;
      private String edtTTBUS_FechaCarga_Internalname ;
      private String cmbTTBUS_Estado_Internalname ;
      private String edtTTBUS_CodProveedor_Internalname ;
      private String edtTTBUS_DesProveedor_Internalname ;
      private String edtTTBUS_CucProveedor_Internalname ;
      private String edtTTBUS_CodPosicion_Internalname ;
      private String edtTTBUS_DesPosicion_Internalname ;
      private String edtTTBUS_RubroDesc_Internalname ;
      private String edtTTBUS_ContDocu_Internalname ;
      private String edtTTBUS_UsuarioAlta_Internalname ;
      private String edtTTBUS_MaquinaAlta_Internalname ;
      private String edtTTBUS_Empresa_Internalname ;
      private String edtTTBUS_NroSerie_Internalname ;
      private String A8BUS_EMP ;
      private String A61BUS_RUD ;
      private String A54BUS_DES ;
      private String A59BUS_TID ;
      private String A30TTBUS_DesProveedor ;
      private String A38TTBUS_DesPosicion ;
      private String A18TTBUS_RubroDesc ;
      private String A75TTBUS_UsuarioAlta ;
      private String A76TTBUS_MaquinaAlta ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavUpdate_Link ;
      private String edtavDelete_Link ;
      private String edtBUS_DES_Link ;
      private String sStyleString ;
      private String tblTable_Internalname ;
      private String tblTablegridcontainer_Internalname ;
      private String TempTags ;
      private String imgInsert_Internalname ;
      private String imgInsert_Jsonclick ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String GXt_char13 ;
      private String GXt_char14 ;
      private String GXt_char15 ;
      private String GXt_char16 ;
      private String GXt_char17 ;
      private String GXt_char18 ;
      private String GXt_char19 ;
      private String GXt_char20 ;
      private String GXt_char21 ;
      private String GXt_char22 ;
      private String GXt_char23 ;
      private String GXt_char24 ;
      private String GXt_char25 ;
      private String GXt_char26 ;
      private String GXt_char27 ;
      private String GXt_char28 ;
      private String GXt_char29 ;
      private String GXt_char30 ;
      private String sCtrlAV7TTBUS_RubroBien ;
      private String ROClassString ;
      private String edtTTBUS_Id_Jsonclick ;
      private String edtTTBUS_Descripcion_Jsonclick ;
      private String edtBUS_EMP_Jsonclick ;
      private String edtBUS_RUB_Jsonclick ;
      private String edtBUS_RUD_Jsonclick ;
      private String edtBUS_COD_Jsonclick ;
      private String edtBUS_PAR_Jsonclick ;
      private String edtBUS_DES_Jsonclick ;
      private String edtBUS_FAD_Jsonclick ;
      private String edtBUS_TIP_Jsonclick ;
      private String edtBUS_TID_Jsonclick ;
      private String edtHARDWARE_ID_Jsonclick ;
      private String edtHARDWARE_DESCRIPCION_Jsonclick ;
      private String edtHARDWARE_NRO_SERIE_Jsonclick ;
      private String edtTTBUS_FechaCarga_Jsonclick ;
      private String cmbTTBUS_Estado_Jsonclick ;
      private String edtTTBUS_CodProveedor_Jsonclick ;
      private String edtTTBUS_DesProveedor_Jsonclick ;
      private String edtTTBUS_CucProveedor_Jsonclick ;
      private String edtTTBUS_CodPosicion_Jsonclick ;
      private String edtTTBUS_DesPosicion_Jsonclick ;
      private String edtTTBUS_RubroDesc_Jsonclick ;
      private String edtTTBUS_ContDocu_Jsonclick ;
      private String edtTTBUS_UsuarioAlta_Jsonclick ;
      private String edtTTBUS_MaquinaAlta_Jsonclick ;
      private String edtTTBUS_Empresa_Jsonclick ;
      private String edtTTBUS_NroSerie_Jsonclick ;
      private String GXt_char31 ;
      private DateTime A55BUS_FAD ;
      private DateTime A13TTBUS_FechaCarga ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n8BUS_EMP ;
      private bool n1BUS_RUB ;
      private bool n61BUS_RUD ;
      private bool n3BUS_COD ;
      private bool n4BUS_PAR ;
      private bool n10HARDWARE_ID ;
      private bool n27TTBUS_CodProveedor ;
      private bool n73TTBUS_CucProveedor ;
      private bool n18TTBUS_RubroDesc ;
      private bool n74TTBUS_ContDocu ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String A12TTBUS_Descripcion ;
      private String A58HARDWARE_DESCRIPCION ;
      private String A9HARDWARE_NRO_SERIE ;
      private String A42TTBUS_NroSerie ;
      private String l12TTBUS_Descripcion ;
      private String AV13Delete ;
      private String AV12Update ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTTBUS_Estado ;
      private GXCheckbox chkTTBUS_Alquilado ;
      private IDataStoreProvider pr_default ;
      private String[] H00492_A12TTBUS_Descripcion ;
      private short[] H00493_A17TTBUS_RubroBien ;
      private String[] H00493_A42TTBUS_NroSerie ;
      private short[] H00493_A41TTBUS_Empresa ;
      private String[] H00493_A76TTBUS_MaquinaAlta ;
      private String[] H00493_A75TTBUS_UsuarioAlta ;
      private int[] H00493_A74TTBUS_ContDocu ;
      private bool[] H00493_n74TTBUS_ContDocu ;
      private String[] H00493_A18TTBUS_RubroDesc ;
      private bool[] H00493_n18TTBUS_RubroDesc ;
      private String[] H00493_A38TTBUS_DesPosicion ;
      private short[] H00493_A37TTBUS_CodPosicion ;
      private short[] H00493_A29TTBUS_Alquilado ;
      private int[] H00493_A73TTBUS_CucProveedor ;
      private bool[] H00493_n73TTBUS_CucProveedor ;
      private String[] H00493_A30TTBUS_DesProveedor ;
      private int[] H00493_A27TTBUS_CodProveedor ;
      private bool[] H00493_n27TTBUS_CodProveedor ;
      private short[] H00493_A23TTBUS_Estado ;
      private DateTime[] H00493_A13TTBUS_FechaCarga ;
      private String[] H00493_A9HARDWARE_NRO_SERIE ;
      private String[] H00493_A58HARDWARE_DESCRIPCION ;
      private short[] H00493_A10HARDWARE_ID ;
      private bool[] H00493_n10HARDWARE_ID ;
      private String[] H00493_A59BUS_TID ;
      private short[] H00493_A56BUS_TIP ;
      private DateTime[] H00493_A55BUS_FAD ;
      private String[] H00493_A54BUS_DES ;
      private short[] H00493_A4BUS_PAR ;
      private bool[] H00493_n4BUS_PAR ;
      private short[] H00493_A3BUS_COD ;
      private bool[] H00493_n3BUS_COD ;
      private String[] H00493_A61BUS_RUD ;
      private bool[] H00493_n61BUS_RUD ;
      private short[] H00493_A1BUS_RUB ;
      private bool[] H00493_n1BUS_RUB ;
      private String[] H00493_A8BUS_EMP ;
      private bool[] H00493_n8BUS_EMP ;
      private String[] H00493_A12TTBUS_Descripcion ;
      private int[] H00493_A11TTBUS_Id ;
      private int[] H00494_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GxWebSession AV8Session ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class tbus002ttbus000wc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00492 ;
          prmH00492 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH00493 ;
          prmH00493 = new Object[] {
          new Object[] {"@AV7TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH00494 ;
          prmH00494 = new Object[] {
          new Object[] {"@AV7TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00492", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00492,0,0,true,false )
             ,new CursorDef("H00493", "SELECT T1.[TTBUS_RubroBien] AS TTBUS_RubroBien, T1.[TTBUS_NroSerie], T1.[TTBUS_Empresa], T1.[TTBUS_MaquinaAlta], T1.[TTBUS_UsuarioAlta], T1.[TTBUS_ContDocu], T2.[RBR_DES] AS TTBUS_RubroDesc, T1.[TTBUS_DesPosicion], T1.[TTBUS_CodPosicion], T1.[TTBUS_Alquilado], T1.[TTBUS_CucProveedor], T1.[TTBUS_DesProveedor], T1.[TTBUS_CodProveedor], T1.[TTBUS_Estado], T1.[TTBUS_FechaCarga], T3.[HARDWARE_NRO_SERIE], T3.[HARDWARE_DESCRIPCION], T1.[HARDWARE_ID], T5.[BUS_TID], T5.[BUS_TIP], T5.[BUS_FAD], T5.[BUS_DES], T1.[BUS_PAR], T1.[BUS_COD], T4.[RBR_DES] AS BUS_RUD, T1.[BUS_RUB] AS BUS_RUB, T1.[BUS_EMP], T1.[TTBUS_Descripcion], T1.[TTBUS_Id] FROM (((([TTBUS000] T1 WITH (NOLOCK) INNER JOIN [BUS002] T2 WITH (NOLOCK) ON T2.[RBR_COD] = T1.[TTBUS_RubroBien]) LEFT JOIN [HARDWARE] T3 WITH (NOLOCK) ON T3.[HARDWARE_ID] = T1.[HARDWARE_ID]) LEFT JOIN [BUS002] T4 WITH (NOLOCK) ON T4.[RBR_COD] = T1.[BUS_RUB]) LEFT JOIN [BUS000] T5 WITH (NOLOCK) ON T5.[BUS_EMP] = T1.[BUS_EMP] AND T5.[BUS_RUB] = T1.[BUS_RUB] AND T5.[BUS_COD] = T1.[BUS_COD] AND T5.[BUS_PAR] = T1.[BUS_PAR]) WHERE T1.[TTBUS_RubroBien] = @AV7TTBUS_RubroBien ORDER BY T1.[TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00493,11,0,true,false )
             ,new CursorDef("H00494", "SELECT COUNT(*) FROM (((([TTBUS000] T1 WITH (NOLOCK) INNER JOIN [BUS002] T5 WITH (NOLOCK) ON T5.[RBR_COD] = T1.[TTBUS_RubroBien]) LEFT JOIN [HARDWARE] T3 WITH (NOLOCK) ON T3.[HARDWARE_ID] = T1.[HARDWARE_ID]) LEFT JOIN [BUS002] T4 WITH (NOLOCK) ON T4.[RBR_COD] = T1.[BUS_RUB]) LEFT JOIN [BUS000] T2 WITH (NOLOCK) ON T2.[BUS_EMP] = T1.[BUS_EMP] AND T2.[BUS_RUB] = T1.[BUS_RUB] AND T2.[BUS_COD] = T1.[BUS_COD] AND T2.[BUS_PAR] = T1.[BUS_PAR]) WHERE T1.[TTBUS_RubroBien] = @AV7TTBUS_RubroBien ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00494,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 30) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getString(8, 50) ;
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                ((short[]) buf[11])[0] = rslt.getShort(10) ;
                ((int[]) buf[12])[0] = rslt.getInt(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((String[]) buf[14])[0] = rslt.getString(12, 30) ;
                ((int[]) buf[15])[0] = rslt.getInt(13) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(13);
                ((short[]) buf[17])[0] = rslt.getShort(14) ;
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(15) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[20])[0] = rslt.getVarchar(17) ;
                ((short[]) buf[21])[0] = rslt.getShort(18) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(18);
                ((String[]) buf[23])[0] = rslt.getString(19, 20) ;
                ((short[]) buf[24])[0] = rslt.getShort(20) ;
                ((DateTime[]) buf[25])[0] = rslt.getGXDate(21) ;
                ((String[]) buf[26])[0] = rslt.getString(22, 50) ;
                ((short[]) buf[27])[0] = rslt.getShort(23) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(23);
                ((short[]) buf[29])[0] = rslt.getShort(24) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(24);
                ((String[]) buf[31])[0] = rslt.getString(25, 30) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(25);
                ((short[]) buf[33])[0] = rslt.getShort(26) ;
                ((bool[]) buf[34])[0] = rslt.wasNull(26);
                ((String[]) buf[35])[0] = rslt.getString(27, 1) ;
                ((bool[]) buf[36])[0] = rslt.wasNull(27);
                ((String[]) buf[37])[0] = rslt.getVarchar(28) ;
                ((int[]) buf[38])[0] = rslt.getInt(29) ;
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
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
