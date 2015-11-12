/*
               File: HTBUS030
        Description: Consulta de Trazabilidad de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/20/2014 14:46:25.68
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
   public class htbus030 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus030( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus030( IGxContext context )
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

      public void execute( out int aP0_pTTBUS_Id )
      {
         this.AV33pTTBUS_Id = 0 ;
         executePrivate();
         aP0_pTTBUS_Id=this.AV33pTTBUS_Id;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavTtbus7_pos = new GXCombobox();
         chkTTBUS_Alquilado = new GXCheckbox();
         cmbTTBUS_Estado = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vFTTBUS_DESCRIPCION") == 0 )
            {
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvFTTBUS_DESCRIPCION0C0( A12TTBUS_Descripcion) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"TTBUS_DESCRIPCION") == 0 )
            {
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGATTBUS_DESCRIPCION0C0( A12TTBUS_Descripcion) ;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_50_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_50_idx = GetNextPar( ) ;
               edtavSec_dre_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_50_idx, sGXsfl_50_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavSec_cre_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_cre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_cre_Enabled), 5, 0)));
               cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
               cmbavTtbus7_pos.WebTags = "" ;
               if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV25TTBUS7_Pos) )
               {
                  AV25TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TTBUS7_Pos), 3, 0)));
               }
               GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_50_idx ;
               chkTTBUS_Alquilado.Name = GXCCtl ;
               chkTTBUS_Alquilado.WebTags = "" ;
               chkTTBUS_Alquilado.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
               chkTTBUS_Alquilado.CheckedValue = "0" ;
               GXCCtl = "TTBUS_ESTADO_" + sGXsfl_50_idx ;
               cmbTTBUS_Estado.Name = GXCCtl ;
               cmbTTBUS_Estado.WebTags = "" ;
               cmbTTBUS_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
               cmbTTBUS_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
               cmbTTBUS_Estado.addItem("3", "BAJA A CONFIRMAR", 0);
               cmbTTBUS_Estado.addItem("4", "BAJA", 0);
               if ( ( cmbTTBUS_Estado.ItemCount > 0 ) && (0==A23TTBUS_Estado) )
               {
                  A23TTBUS_Estado = (short)(NumberUtil.Val( cmbTTBUS_Estado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               }
               Grid1_PageSize50 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV21TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TTBUS_Id), 8, 0)));
               AV31fTTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31fTTBUS_Descripcion", AV31fTTBUS_Descripcion);
               AV34TTBUS_RubroBien = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_RubroBien), 4, 0)));
               AV25TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TTBUS7_Pos), 3, 0)));
               AV32TTBUS_FechaCarga = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TTBUS_FechaCarga", context.localUtil.Format(AV32TTBUS_FechaCarga, "99/99/9999"));
               edtavSec_dre_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
               A7USU_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A25TTBUS2_RespHacia = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               A24TTBUS2_RespDesde = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A36TTBUS7_DesResp = GetNextPar( ) ;
               n36TTBUS7_DesResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               A35TTBUS7_CodResp = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize50, AV21TTBUS_Id, AV31fTTBUS_Descripcion, AV34TTBUS_RubroBien, AV25TTBUS7_Pos, AV32TTBUS_FechaCarga, A7USU_DES, A6USU_COD, A25TTBUS2_RespHacia, A24TTBUS2_RespDesde, A36TTBUS7_DesResp, A35TTBUS7_CodResp, A33TTBUS7_Pos) ;
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
               AV33pTTBUS_Id = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33pTTBUS_Id), 8, 0)));
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
         PA0C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0C2( ) ;
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
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus030.aspx") + "?" + UrlEncode("" +AV33pTTBUS_Id)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vFTTBUS_DESCRIPCION", StringUtil.RTrim( AV31fTTBUS_Descripcion));
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS_RUBROBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34TTBUS_RubroBien), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS_FECHACARGA", context.localUtil.Format(AV32TTBUS_FechaCarga, "99/99/9999"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33pTTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USU_DES", StringUtil.RTrim( A7USU_DES));
         GxWebStd.gx_hidden_field( context, "USU_COD", StringUtil.RTrim( A6USU_COD));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPHACIA", StringUtil.RTrim( A25TTBUS2_RespHacia));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPDESDE", StringUtil.RTrim( A24TTBUS2_RespDesde));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DESRESP", StringUtil.RTrim( A36TTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODRESP", StringUtil.RTrim( A35TTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
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
            WE0C2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0C2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS030" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Trazabilidad de Bienes de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus030.aspx") + "?" + UrlEncode("" +AV33pTTBUS_Id) ;
      }

      protected void WB0C0( )
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
            wb_table1_2_0C2( true) ;
         }
         else
         {
            wb_table1_2_0C2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0C2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0C2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Consulta de Trazabilidad de Bienes de Uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0C0( ) ;
      }

      protected void WS0C2( )
      {
         START0C2( ) ;
         EVT0C2( ) ;
      }

      protected void EVT0C2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_ID"), ",", ".") != Convert.ToDecimal( AV21TTBUS_Id )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS_DESCRIPCION"), AV31fTTBUS_Descripcion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_RUBROBIEN"), ",", ".") != Convert.ToDecimal( AV34TTBUS_RubroBien )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV25TTBUS7_Pos )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vTTBUS_FECHACARGA"), 4) != AV32TTBUS_FechaCarga )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
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
                           else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E110C2 */
                              E110C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'FILTRAR POR IDENTIFICADORES'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E120C2 */
                              E120C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'MOVIMIENTOS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E130C2 */
                              E130C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LISTAR MOVIMIENTOS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E140C2 */
                              E140C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "'MOVIMIENTOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 29), "'FILTRAR POR IDENTIFICADORES'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 20), "'LISTAR MOVIMIENTOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'BUSCAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_50_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
                              edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_50_idx ;
                              edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_50_idx ;
                              edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_50_idx ;
                              edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_50_idx ;
                              edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_50_idx ;
                              edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_50_idx ;
                              edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_50_idx ;
                              chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_50_idx ;
                              edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_50_idx ;
                              edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_50_idx ;
                              cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_50_idx ;
                              edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_50_idx ;
                              edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_50_idx ;
                              edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_50_idx ;
                              edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_50_idx ;
                              edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_50_idx ;
                              edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_50_idx ;
                              edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_50_idx ;
                              edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_50_idx ;
                              AV27visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV27visualizacion));
                              A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                              A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                              A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
                              A17TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_RubroBien_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
                              A18TTBUS_RubroDesc = StringUtil.Upper( cgiGet( edtTTBUS_RubroDesc_Internalname)) ;
                              n18TTBUS_RubroDesc = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
                              A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
                              n16TTBUS_FechaBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
                              A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
                              A27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".")) ;
                              n27TTBUS_CodProveedor = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
                              A30TTBUS_DesProveedor = cgiGet( edtTTBUS_DesProveedor_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
                              cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
                              cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
                              A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
                              A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
                              A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
                              AV14SEC_CRE = cgiGet( edtavSec_cre_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14SEC_CRE", AV14SEC_CRE);
                              AV15SEC_DRE = cgiGet( edtavSec_dre_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SEC_DRE", AV15SEC_DRE);
                              A8BUS_EMP = StringUtil.Upper( cgiGet( edtBUS_EMP_Internalname)) ;
                              n8BUS_EMP = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
                              A3BUS_COD = (short)(context.localUtil.CToN( cgiGet( edtBUS_COD_Internalname), ",", ".")) ;
                              n3BUS_COD = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
                              A4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( edtBUS_PAR_Internalname), ",", ".")) ;
                              n4BUS_PAR = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
                              A1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( edtBUS_RUB_Internalname), ",", ".")) ;
                              n1BUS_RUB = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E150C2 */
                                    E150C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'VISUALIZACION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E160C2 */
                                    E160C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E170C2 */
                                    E170C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MOVIMIENTOS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E130C2 */
                                    E130C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Ttbus_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_ID"), ",", ".") != Convert.ToDecimal( AV21TTBUS_Id )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Fttbus_descripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS_DESCRIPCION"), AV31fTTBUS_Descripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ttbus_rubrobien Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_RUBROBIEN"), ",", ".") != Convert.ToDecimal( AV34TTBUS_RubroBien )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ttbus7_pos Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV25TTBUS7_Pos )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ttbus_fechacarga Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vTTBUS_FECHACARGA"), 4) != AV32TTBUS_FechaCarga )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E180C2 */
                                          E180C2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'FILTRAR POR IDENTIFICADORES'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120C2 */
                                    E120C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'LISTAR MOVIMIENTOS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E140C2 */
                                    E140C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110C2 */
                                    E110C2 ();
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
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE0C2( )
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

      protected void PA0C2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
            cmbavTtbus7_pos.WebTags = "" ;
            if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV25TTBUS7_Pos) )
            {
               AV25TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TTBUS7_Pos), 3, 0)));
            }
            GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_50_idx ;
            chkTTBUS_Alquilado.Name = GXCCtl ;
            chkTTBUS_Alquilado.WebTags = "" ;
            chkTTBUS_Alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
            chkTTBUS_Alquilado.CheckedValue = "0" ;
            GXCCtl = "TTBUS_ESTADO_" + sGXsfl_50_idx ;
            cmbTTBUS_Estado.Name = GXCCtl ;
            cmbTTBUS_Estado.WebTags = "" ;
            cmbTTBUS_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
            cmbTTBUS_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
            cmbTTBUS_Estado.addItem("3", "BAJA A CONFIRMAR", 0);
            cmbTTBUS_Estado.addItem("4", "BAJA", 0);
            if ( ( cmbTTBUS_Estado.ItemCount > 0 ) && (0==A23TTBUS_Estado) )
            {
               A23TTBUS_Estado = (short)(NumberUtil.Val( cmbTTBUS_Estado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            }
            GX_FocusControl = edtavTtbus_id_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGVvFTTBUS_DESCRIPCION0C0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvFTTBUS_DESCRIPCION_data0C0( A12TTBUS_Descripcion) ;
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

      protected void GXSGVvFTTBUS_DESCRIPCION_data0C0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H000C2 */
         pr_default.execute(0, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H000C2_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H000C2_A12TTBUS_Descripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXSGATTBUS_DESCRIPCION0C0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS_DESCRIPCION_data0C0( A12TTBUS_Descripcion) ;
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

      protected void GXSGATTBUS_DESCRIPCION_data0C0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H000C3 */
         pr_default.execute(1, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H000C3_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H000C3_A12TTBUS_Descripcion[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_50_idx ,
                                       String sGXsfl_50_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_50_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_50_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_50_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_50_idx ;
         edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_50_idx ;
         edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_50_idx ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_50_idx ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_50_idx ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_50_idx ;
         edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_50_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_50_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_50_idx ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_50_idx ;
         edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_50_idx ;
         edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_50_idx ;
         edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_50_idx ;
         edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_50_idx ;
         edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_50_idx ;
         edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_50_idx ;
         while ( nGXsfl_50_idx <= nRC_Grid1 )
         {
            sendrow_502( ) ;
            nGXsfl_50_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_50_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_50_idx+1)) ;
            sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_50_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_50_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_50_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_50_idx ;
            edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_50_idx ;
            edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_50_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_50_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_50_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_50_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_50_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_50_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_50_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_50_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_50_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_50_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_50_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_50_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_50_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_50_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize50 ,
                                        int AV21TTBUS_Id ,
                                        String AV31fTTBUS_Descripcion ,
                                        short AV34TTBUS_RubroBien ,
                                        short AV25TTBUS7_Pos ,
                                        DateTime AV32TTBUS_FechaCarga ,
                                        String A7USU_DES ,
                                        String A6USU_COD ,
                                        String A25TTBUS2_RespHacia ,
                                        String A24TTBUS2_RespDesde ,
                                        String A36TTBUS7_DesResp ,
                                        String A35TTBUS7_CodResp ,
                                        short A33TTBUS7_Pos )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize50) ;
         RF0C2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0C2( ) ;
         /* End function Refresh */
      }

      protected void RF0C2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 50 ;
         nGXsfl_50_idx = 1 ;
         sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_50_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_50_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_50_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_50_idx ;
         edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_50_idx ;
         edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_50_idx ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_50_idx ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_50_idx ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_50_idx ;
         edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_50_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_50_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_50_idx ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_50_idx ;
         edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_50_idx ;
         edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_50_idx ;
         edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_50_idx ;
         edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_50_idx ;
         edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_50_idx ;
         edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_50_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_50_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_50_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_50_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_50_idx ;
            edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_50_idx ;
            edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_50_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_50_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_50_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_50_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_50_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_50_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_50_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_50_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_50_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_50_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_50_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_50_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_50_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_50_idx ;
            pr_default.dynParam(2, new Object[]{ new Object[]{
                                                 AV25TTBUS7_Pos ,
                                                 AV31fTTBUS_Descripcion ,
                                                 AV32TTBUS_FechaCarga ,
                                                 AV34TTBUS_RubroBien ,
                                                 A37TTBUS_CodPosicion ,
                                                 A12TTBUS_Descripcion ,
                                                 AV30TTBUS_Descripcion ,
                                                 A13TTBUS_FechaCarga ,
                                                 A17TTBUS_RubroBien ,
                                                 A16TTBUS_FechaBaja ,
                                                 A23TTBUS_Estado ,
                                                 A8BUS_EMP ,
                                                 A1BUS_RUB ,
                                                 A3BUS_COD ,
                                                 A4BUS_PAR ,
                                                 AV21TTBUS_Id },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DATE,
                                                 TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN,
                                                 TypeConstants.INT
                                                 }
            });
            lV30TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV30TTBUS_Descripcion), 50, "%") ;
            /* Using cursor H000C4 */
            pr_default.execute(2, new Object[] {AV21TTBUS_Id, AV25TTBUS7_Pos, lV30TTBUS_Descripcion, AV32TTBUS_FechaCarga, AV34TTBUS_RubroBien});
            nGXsfl_50_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(2) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A11TTBUS_Id = H000C4_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A37TTBUS_CodPosicion = H000C4_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A1BUS_RUB = H000C4_A1BUS_RUB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               n1BUS_RUB = H000C4_n1BUS_RUB[0] ;
               A4BUS_PAR = H000C4_A4BUS_PAR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               n4BUS_PAR = H000C4_n4BUS_PAR[0] ;
               A3BUS_COD = H000C4_A3BUS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               n3BUS_COD = H000C4_n3BUS_COD[0] ;
               A8BUS_EMP = H000C4_A8BUS_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               n8BUS_EMP = H000C4_n8BUS_EMP[0] ;
               A38TTBUS_DesPosicion = H000C4_A38TTBUS_DesPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               A23TTBUS_Estado = H000C4_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A30TTBUS_DesProveedor = H000C4_A30TTBUS_DesProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
               A27TTBUS_CodProveedor = H000C4_A27TTBUS_CodProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               n27TTBUS_CodProveedor = H000C4_n27TTBUS_CodProveedor[0] ;
               A29TTBUS_Alquilado = H000C4_A29TTBUS_Alquilado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A16TTBUS_FechaBaja = H000C4_A16TTBUS_FechaBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               n16TTBUS_FechaBaja = H000C4_n16TTBUS_FechaBaja[0] ;
               A18TTBUS_RubroDesc = H000C4_A18TTBUS_RubroDesc[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               n18TTBUS_RubroDesc = H000C4_n18TTBUS_RubroDesc[0] ;
               A17TTBUS_RubroBien = H000C4_A17TTBUS_RubroBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
               A13TTBUS_FechaCarga = H000C4_A13TTBUS_FechaCarga[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A12TTBUS_Descripcion = H000C4_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A18TTBUS_RubroDesc = H000C4_A18TTBUS_RubroDesc[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               n18TTBUS_RubroDesc = H000C4_n18TTBUS_RubroDesc[0] ;
               /* Execute user event: E170C2 */
               E170C2 ();
               pr_default.readNext(2);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(2) == 101) ? 1 : 0)) ;
            pr_default.close(2);
            wbEnd = 50 ;
            WB0C0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV25TTBUS7_Pos ,
                                              AV31fTTBUS_Descripcion ,
                                              AV32TTBUS_FechaCarga ,
                                              AV34TTBUS_RubroBien ,
                                              A37TTBUS_CodPosicion ,
                                              A12TTBUS_Descripcion ,
                                              AV30TTBUS_Descripcion ,
                                              A13TTBUS_FechaCarga ,
                                              A17TTBUS_RubroBien ,
                                              A16TTBUS_FechaBaja ,
                                              A23TTBUS_Estado ,
                                              A8BUS_EMP ,
                                              A1BUS_RUB ,
                                              A3BUS_COD ,
                                              A4BUS_PAR ,
                                              AV21TTBUS_Id },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN,
                                              TypeConstants.INT
                                              }
         });
         lV30TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV30TTBUS_Descripcion), 50, "%") ;
         /* Using cursor H000C5 */
         pr_default.execute(3, new Object[] {AV21TTBUS_Id, AV25TTBUS7_Pos, lV30TTBUS_Descripcion, AV32TTBUS_FechaCarga, AV34TTBUS_RubroBien});
         GRID1_nRecordCount = H000C5_AGRID1_nRecordCount[0] ;
         pr_default.close(3);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
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

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid1_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP0C0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavSec_cre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_cre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_cre_Enabled), 5, 0)));
         imgprompt_Ttbus_rubrobien_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus_rub.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS_RUBROBIEN"+"'), id:'"+"vTTBUS_RUBROBIEN"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E150C2 */
         E150C2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavTtbus_id_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vTTBUS_ID");
               GX_FocusControl = edtavTtbus_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV21TTBUS_Id = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TTBUS_Id), 8, 0)));
            }
            else
            {
               AV21TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TTBUS_Id), 8, 0)));
            }
            AV31fTTBUS_Descripcion = StringUtil.Upper( cgiGet( edtavFttbus_descripcion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31fTTBUS_Descripcion", AV31fTTBUS_Descripcion);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavTtbus_rubrobien_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavTtbus_rubrobien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavTtbus_rubrobien_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vTTBUS_RUBROBIEN");
               GX_FocusControl = edtavTtbus_rubrobien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV34TTBUS_RubroBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_RubroBien), 4, 0)));
            }
            else
            {
               AV34TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtavTtbus_rubrobien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_RubroBien), 4, 0)));
            }
            cmbavTtbus7_pos.Name = cmbavTtbus7_pos_Internalname ;
            cmbavTtbus7_pos.CurrentValue = cgiGet( cmbavTtbus7_pos_Internalname) ;
            AV25TTBUS7_Pos = (short)(NumberUtil.Val( cgiGet( cmbavTtbus7_pos_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TTBUS7_Pos), 3, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavTtbus_fechacarga_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TTBUS_ Fecha Carga"}), 1, "vTTBUS_FECHACARGA");
               GX_FocusControl = edtavTtbus_fechacarga_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV32TTBUS_FechaCarga = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TTBUS_FechaCarga", context.localUtil.Format(AV32TTBUS_FechaCarga, "99/99/9999"));
            }
            else
            {
               AV32TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtavTtbus_fechacarga_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TTBUS_FechaCarga", context.localUtil.Format(AV32TTBUS_FechaCarga, "99/99/9999"));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV33pTTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "vPTTBUS_ID"), ",", ".")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            nGXsfl_50_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_50_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_50_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_50_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_50_idx ;
            edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_50_idx ;
            edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_50_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_50_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_50_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_50_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_50_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_50_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_50_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_50_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_50_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_50_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_50_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_50_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_50_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_50_idx ;
            if ( nGXsfl_50_idx > 0 )
            {
               AV27visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
               A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A17TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_RubroBien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
               A18TTBUS_RubroDesc = StringUtil.Upper( cgiGet( edtTTBUS_RubroDesc_Internalname)) ;
               n18TTBUS_RubroDesc = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
               n16TTBUS_FechaBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".")) ;
               n27TTBUS_CodProveedor = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               A30TTBUS_DesProveedor = cgiGet( edtTTBUS_DesProveedor_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
               cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
               cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
               A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               AV14SEC_CRE = cgiGet( edtavSec_cre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14SEC_CRE", AV14SEC_CRE);
               AV15SEC_DRE = cgiGet( edtavSec_dre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SEC_DRE", AV15SEC_DRE);
               A8BUS_EMP = StringUtil.Upper( cgiGet( edtBUS_EMP_Internalname)) ;
               n8BUS_EMP = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               A3BUS_COD = (short)(context.localUtil.CToN( cgiGet( edtBUS_COD_Internalname), ",", ".")) ;
               n3BUS_COD = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               A4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( edtBUS_PAR_Internalname), ",", ".")) ;
               n4BUS_PAR = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               A1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( edtBUS_RUB_Internalname), ",", ".")) ;
               n1BUS_RUB = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E150C2 */
         E150C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E150C2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV7Context) ;
         AV26USUARIO = AV7Context.gxTpr_User ;
         edtavSec_dre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
         AV11inicio = (short)(NumberUtil.Val( AV16SESION.Get("Inicio"), ".")) ;
         if ( AV11inicio < 2 )
         {
            AV11inicio = (short)(AV11inicio+1) ;
            AV16SESION.Set("Inicio", StringUtil.Str( (decimal)(AV11inicio), 1, 0));
            context.DoAjaxRefresh();
         }
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E160C2( )
      {
         /* 'Visualizacion' Routine */
         context.wjLoc = formatLink("ttbus000.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A37TTBUS_CodPosicion) + "," + UrlEncode(StringUtil.RTrim(AV14SEC_CRE)) + "," + UrlEncode("" +AV20TTBUS_Estado) + "," + UrlEncode("" +1) + "," + UrlEncode(StringUtil.RTrim(AV17SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV26USUARIO)) ;
      }

      private void E170C2( )
      {
         /* Grid1_Load Routine */
         AV27visualizacion = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV27visualizacion));
         if ( A23TTBUS_Estado == 1 )
         {
            /* Using cursor H000C6 */
            pr_default.execute(4, new Object[] {A37TTBUS_CodPosicion});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A33TTBUS7_Pos = H000C6_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A35TTBUS7_CodResp = H000C6_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A36TTBUS7_DesResp = H000C6_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H000C6_n36TTBUS7_DesResp[0] ;
               A36TTBUS7_DesResp = H000C6_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H000C6_n36TTBUS7_DesResp[0] ;
               AV14SEC_CRE = A35TTBUS7_CodResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14SEC_CRE", AV14SEC_CRE);
               AV15SEC_DRE = A36TTBUS7_DesResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SEC_DRE", AV15SEC_DRE);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(4);
         }
         else
         {
            /* Using cursor H000C7 */
            pr_default.execute(5, new Object[] {A11TTBUS_Id});
            while ( (pr_default.getStatus(5) != 101) )
            {
               A22TTBUS2_IdBien = H000C7_A22TTBUS2_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
               A26TTBUS2_EstadoEnvio = H000C7_A26TTBUS2_EstadoEnvio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
               A24TTBUS2_RespDesde = H000C7_A24TTBUS2_RespDesde[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A25TTBUS2_RespHacia = H000C7_A25TTBUS2_RespHacia[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               AV22TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
               AV23TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
               /* Execute user subroutine: S124 */
               S124 ();
               if ( returnInSub )
               {
                  pr_default.close(5);
                  returnInSub = true;
                  if (true) return;
               }
               pr_default.readNext(5);
            }
            pr_default.close(5);
            AV15SEC_DRE = StringUtil.Trim( AV8dUSU_DES) + " Y " + StringUtil.Trim( AV10hUSU_DES) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SEC_DRE", AV15SEC_DRE);
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 50 ;
         }
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_502( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void E130C2( )
      {
         /* 'Movimientos' Routine */
         AV16SESION.Set("CONT_MOV", "1");
         context.PopUp(formatLink("htbus002.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(A12TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim(AV17SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV26USUARIO)), new Object[] {"A11TTBUS_Id","A12TTBUS_Descripcion","AV17SISTEMA","AV26USUARIO"});
      }

      protected void S112( )
      {
         /* 'CARGA POSICIONES' Routine */
         AV6band = 0 ;
         /* Using cursor H000C8 */
         pr_default.execute(6, new Object[] {AV26USUARIO});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A40TTBUS8_CodUsuario = H000C8_A40TTBUS8_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
            AV6band = 1 ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(6);
         if ( ( ( AV6band == 1 ) ) || ( ( StringUtil.StrCmp(AV26USUARIO, "SUPERVISOR") == 0 ) ) )
         {
            cmbavTtbus7_pos.addItem(" -1", "TODAS", 0);
            /* Using cursor H000C9 */
            pr_default.execute(7);
            while ( (pr_default.getStatus(7) != 101) )
            {
               A34TTBUS7_Des = H000C9_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H000C9_n34TTBUS7_Des[0] ;
               A33TTBUS7_Pos = H000C9_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A34TTBUS7_Des = H000C9_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H000C9_n34TTBUS7_Des[0] ;
               cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
               pr_default.readNext(7);
            }
            pr_default.close(7);
            AV25TTBUS7_Pos = -1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TTBUS7_Pos), 3, 0)));
         }
         else
         {
            /* Using cursor H000C10 */
            pr_default.execute(8);
            while ( (pr_default.getStatus(8) != 101) )
            {
               A34TTBUS7_Des = H000C10_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H000C10_n34TTBUS7_Des[0] ;
               A35TTBUS7_CodResp = H000C10_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A33TTBUS7_Pos = H000C10_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A34TTBUS7_Des = H000C10_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H000C10_n34TTBUS7_Des[0] ;
               AV28vTTBUS7_Pos = A33TTBUS7_Pos ;
               if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV26USUARIO) == 0 )
               {
                  cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
               }
               else
               {
                  /* Using cursor H000C11 */
                  pr_default.execute(9, new Object[] {AV28vTTBUS7_Pos, AV26USUARIO});
                  while ( (pr_default.getStatus(9) != 101) )
                  {
                     A39TTBUS7_CodUsuario = H000C11_A39TTBUS7_CodUsuario[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
                     A33TTBUS7_Pos = H000C11_A33TTBUS7_Pos[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                     cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(9);
               }
               pr_default.readNext(8);
            }
            pr_default.close(8);
         }
      }

      protected void S124( )
      {
         /* 'RESPONSABLES' Routine */
         /* Using cursor H000C12 */
         pr_default.execute(10, new Object[] {AV22TTBUS2_RespDesde});
         while ( (pr_default.getStatus(10) != 101) )
         {
            A6USU_COD = H000C12_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H000C12_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV8dUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(10);
         /* Using cursor H000C13 */
         pr_default.execute(11, new Object[] {AV23TTBUS2_RespHacia});
         while ( (pr_default.getStatus(11) != 101) )
         {
            A6USU_COD = H000C13_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H000C13_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV10hUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(11);
      }

      protected void E110C2( )
      {
         /* 'Buscar' Routine */
         AV30TTBUS_Descripcion = "%" + StringUtil.Trim( AV31fTTBUS_Descripcion) + "%" ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E180C2 */
         E180C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E180C2( )
      {
         /* Enter Routine */
         AV33pTTBUS_Id = A11TTBUS_Id ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33pTTBUS_Id), 8, 0)));
         context.setWebReturnParms(new Object[] {(int)AV33pTTBUS_Id});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void E120C2( )
      {
         /* 'Filtrar por Identificadores' Routine */
         context.wjLoc = formatLink("htbus030_1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV26USUARIO)) ;
      }

      protected void E140C2( )
      {
         /* 'Listar Movimientos' Routine */
         GXt_char3 = "PDF" ;
         new prep000(context ).execute( ref  AV12NOMBRE_REPORTE, ref  GXt_char3) ;
         context.wjLoc = formatLink("aptbus012.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12NOMBRE_REPORTE)) + "," + UrlEncode(StringUtil.RTrim(AV26USUARIO)) + "," + UrlEncode(StringUtil.Str(AV45Gttbus_id,10,2)) ;
      }

      protected void wb_table1_2_0C2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(57), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(824), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_8_0C2( true) ;
         }
         else
         {
            wb_table2_8_0C2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_0C2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Carga") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cód. Rubro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Desc. Rubro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Fecha Baja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Alquilado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Cod. Posición Actual Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "SEC_ CRE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "CODIGO DE EMPRESA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "NUMERO DE CODIGO DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "NUMERO DE PARTIDA DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "RUBRO DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV27visualizacion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A12TTBUS_Descripcion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17TTBUS_RubroBien), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A18TTBUS_RubroDesc));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29TTBUS_Alquilado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A30TTBUS_DesProveedor));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23TTBUS_Estado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A38TTBUS_DesPosicion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV14SEC_CRE));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavSec_cre_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV15SEC_DRE));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavSec_dre_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A8BUS_EMP));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 50 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_50_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "left")+";height:24px\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Ver Movimientos del Bien", "Ver Movimientos del Bien", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'MOVIMIENTOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(50), 3, 0)+","+"null"+");", "", "HLP_HTBUS030.htm");
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton4_Internalname, "Listar Movimientos del Bien", "Listar Movimientos del Bien", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton4_Jsonclick, "E\\'LISTAR MOVIMIENTOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(50), 3, 0)+","+"null"+");", "", "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0C2e( true) ;
         }
         else
         {
            wb_table1_2_0C2e( false) ;
         }
      }

      protected void wb_table2_8_0C2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(36), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(191), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Nº Bien:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TTBUS_Id), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV21TTBUS_Id), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(13);\"", 0, edtavTtbus_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "Descripción:", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus_descripcion_Internalname, StringUtil.RTrim( AV31fTTBUS_Descripcion), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV31fTTBUS_Descripcion, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(18);\"", 0, edtavFttbus_descripcion_Jsonclick, "", 0, 1, 0, true, "left", "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Rubro:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_rubrobien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34TTBUS_RubroBien), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV34TTBUS_RubroBien), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(23);\"", 0, edtavTtbus_rubrobien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS030.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_Ttbus_rubrobien_Internalname, "", "prompt.gif", "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_Ttbus_rubrobien_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Posición:", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavTtbus7_pos, cmbavTtbus7_pos_Internalname, StringUtil.Str( (decimal)(AV25TTBUS7_Pos), 3, 0), "", "int", 1, 1, 0, 1, 0, 3, "chr", 0, "", StyleString, ClassString, "", 0, cmbavTtbus7_pos_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(28);\"", true, "HLP_HTBUS030.htm");
            cmbavTtbus7_pos.CurrentValue = StringUtil.Str( (decimal)(AV25TTBUS7_Pos), 3, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTtbus7_pos_Internalname, "Values", (String)(cmbavTtbus7_pos.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "Fecha de Carga:", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavTtbus_fechacarga_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_fechacarga_Internalname, context.localUtil.Format(AV32TTBUS_FechaCarga, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV32TTBUS_FechaCarga, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(33);\"", 0, edtavTtbus_fechacarga_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS030.htm");
            GxWebStd.gx_bitmap( context, edtavTtbus_fechacarga_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_HTBUS030.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton3_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton3_Jsonclick, "E\\'BUSCAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(50), 3, 0)+","+"null"+");", "", "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton2_Internalname, "Filtrar por Identificadores", "Filtrar por Identificadores", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton2_Jsonclick, "E\\'FILTRAR POR IDENTIFICADORES\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(50), 3, 0)+","+"null"+");", "", "HLP_HTBUS030.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_0C2e( true) ;
         }
         else
         {
            wb_table2_8_0C2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV33pTTBUS_Id = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33pTTBUS_Id), 8, 0)));
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
         PA0C2( ) ;
         WS0C2( ) ;
         WE0C2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?15564175");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?14462731");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbus030.js", "?14462731");
         /* End function include_jscripts */
      }

      protected void sendrow_502( )
      {
         WB0C0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_50_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_50_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            imgprompt_Ttbus_rubrobien_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus_rub.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS_RUBROBIEN"+"'), id:'"+"vTTBUS_RUBROBIEN"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavVisualizacion_Enabled!=0)&&(edtavVisualizacion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 51,'',false,'',50)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavVisualizacion_Internalname,(String)"",(String)AV27visualizacion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Visualización",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavVisualizacion_Jsonclick,"E\\'VISUALIZACION\\'."+sGXsfl_50_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"),(String)"",(short)5,(String)edtTTBUS_Id_Jsonclick,"EENTER."+sGXsfl_50_idx,(short)50,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Descripcion_Internalname,StringUtil.RTrim( A12TTBUS_Descripcion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")),(String)"",(short)0,(String)edtTTBUS_Descripcion_Jsonclick,(String)"",(short)50,(short)1,(short)0,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaCarga_Internalname,context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaCarga_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_RubroBien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17TTBUS_RubroBien), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A17TTBUS_RubroBien), "ZZZ9"),(String)"",(short)0,(String)edtTTBUS_RubroBien_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_RubroDesc_Internalname,StringUtil.RTrim( A18TTBUS_RubroDesc),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A18TTBUS_RubroDesc, "@!")),(String)"",(short)0,(String)edtTTBUS_RubroDesc_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaBaja_Internalname,context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaBaja_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkTTBUS_Alquilado_Internalname,StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0),(String)"",(short)-1,(short)0,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodProveedor_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A27TTBUS_CodProveedor), "ZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_CodProveedor_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesProveedor_Internalname,StringUtil.RTrim( A30TTBUS_DesProveedor),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesProveedor_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_50_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TTBUS_ESTADO_" + sGXsfl_50_idx ;
               cmbTTBUS_Estado.Name = GXCCtl ;
               cmbTTBUS_Estado.WebTags = "" ;
               cmbTTBUS_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
               cmbTTBUS_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
               cmbTTBUS_Estado.addItem("3", "BAJA A CONFIRMAR", 0);
               cmbTTBUS_Estado.addItem("4", "BAJA", 0);
               if ( ( cmbTTBUS_Estado.ItemCount > 0 ) && (0==A23TTBUS_Estado) )
               {
                  A23TTBUS_Estado = (short)(NumberUtil.Val( cmbTTBUS_Estado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTTBUS_Estado,(String)cmbTTBUS_Estado_Internalname,StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)150,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbTTBUS_Estado_Jsonclick,(String)"",(String)"",(bool)true});
            cmbTTBUS_Estado.CurrentValue = StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS_Estado_Internalname, "Values", (String)(cmbTTBUS_Estado.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodPosicion_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A37TTBUS_CodPosicion), "ZZ9"),(String)"",(short)0,(String)edtTTBUS_CodPosicion_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesPosicion_Internalname,StringUtil.RTrim( A38TTBUS_DesPosicion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesPosicion_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 64,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavSec_cre_Internalname,StringUtil.RTrim( AV14SEC_CRE),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(int)edtavSec_cre_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV14SEC_CRE, "XXXXXXXXXXXXXXX")),TempTags+((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(64);\"" : " "),(short)0,(String)edtavSec_cre_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 65,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavSec_dre_Internalname,StringUtil.RTrim( AV15SEC_DRE),(String)"",(short)150,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavSec_dre_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV15SEC_DRE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(65);\"" : " "),(short)0,(String)edtavSec_dre_Jsonclick,(String)"",(short)50,(short)1,(short)-1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_EMP_Internalname,StringUtil.RTrim( A8BUS_EMP),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A8BUS_EMP, "!")),(String)"",(short)0,(String)edtBUS_EMP_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A3BUS_COD), "ZZZ9"),(String)"",(short)0,(String)edtBUS_COD_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_PAR_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A4BUS_PAR), "Z9"),(String)"",(short)0,(String)edtBUS_PAR_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_RUB_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A1BUS_RUB), "ZZZ9"),(String)"",(short)0,(String)edtBUS_RUB_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_50_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_50_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_50_idx+1)) ;
            sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_50_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_50_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_50_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_50_idx ;
            edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_50_idx ;
            edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_50_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_50_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_50_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_50_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_50_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_50_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_50_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_50_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_50_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_50_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_50_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_50_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_50_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_50_idx ;
         }
         /* End function sendrow_502 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavTtbus_id_Internalname = "vTTBUS_ID" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavFttbus_descripcion_Internalname = "vFTTBUS_DESCRIPCION" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavTtbus_rubrobien_Internalname = "vTTBUS_RUBROBIEN" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         cmbavTtbus7_pos_Internalname = "vTTBUS7_POS" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavTtbus_fechacarga_Internalname = "vTTBUS_FECHACARGA" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable3_Internalname = "TABLE3" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton4_Internalname = "BUTTON4" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_Ttbus_rubrobien_Internalname = "PROMPT_TTBUS_RUBROBIEN" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtBUS_RUB_Jsonclick = "" ;
         edtBUS_PAR_Jsonclick = "" ;
         edtBUS_COD_Jsonclick = "" ;
         edtBUS_EMP_Jsonclick = "" ;
         edtavSec_dre_Jsonclick = "" ;
         edtavSec_dre_Visible = -1 ;
         edtavSec_cre_Jsonclick = "" ;
         edtavSec_cre_Visible = 0 ;
         edtTTBUS_DesPosicion_Jsonclick = "" ;
         edtTTBUS_CodPosicion_Jsonclick = "" ;
         cmbTTBUS_Estado_Jsonclick = "" ;
         edtTTBUS_DesProveedor_Jsonclick = "" ;
         edtTTBUS_CodProveedor_Jsonclick = "" ;
         edtTTBUS_FechaBaja_Jsonclick = "" ;
         edtTTBUS_RubroDesc_Jsonclick = "" ;
         edtTTBUS_RubroBien_Jsonclick = "" ;
         edtTTBUS_FechaCarga_Jsonclick = "" ;
         edtTTBUS_Descripcion_Jsonclick = "" ;
         edtTTBUS_Id_Jsonclick = "" ;
         edtavVisualizacion_Jsonclick = "" ;
         edtavVisualizacion_Visible = -1 ;
         edtavVisualizacion_Enabled = 1 ;
         edtavTtbus_fechacarga_Jsonclick = "" ;
         cmbavTtbus7_pos_Jsonclick = "" ;
         imgprompt_Ttbus_rubrobien_Link = "" ;
         edtavTtbus_rubrobien_Jsonclick = "" ;
         edtavFttbus_descripcion_Jsonclick = "" ;
         edtavTtbus_id_Jsonclick = "" ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         edtavSec_cre_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Consulta de Trazabilidad de Bienes de Uso" ;
         chkTTBUS_Alquilado.Caption = "" ;
         edtavSec_dre_Enabled = 1 ;
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
         A12TTBUS_Descripcion = "" ;
         edtavSec_dre_Internalname = "" ;
         edtavSec_cre_Internalname = "" ;
         GXCCtl = "" ;
         chkTTBUS_Alquilado_Internalname = "" ;
         AV31fTTBUS_Descripcion = "" ;
         AV32TTBUS_FechaCarga = DateTime.MinValue ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
         A25TTBUS2_RespHacia = "" ;
         A24TTBUS2_RespDesde = "" ;
         A36TTBUS7_DesResp = "" ;
         A35TTBUS7_CodResp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavVisualizacion_Internalname = "" ;
         edtTTBUS_Id_Internalname = "" ;
         edtTTBUS_Descripcion_Internalname = "" ;
         edtTTBUS_FechaCarga_Internalname = "" ;
         edtTTBUS_RubroBien_Internalname = "" ;
         edtTTBUS_RubroDesc_Internalname = "" ;
         edtTTBUS_FechaBaja_Internalname = "" ;
         edtTTBUS_CodProveedor_Internalname = "" ;
         edtTTBUS_DesProveedor_Internalname = "" ;
         cmbTTBUS_Estado_Internalname = "" ;
         edtTTBUS_CodPosicion_Internalname = "" ;
         edtTTBUS_DesPosicion_Internalname = "" ;
         edtBUS_EMP_Internalname = "" ;
         edtBUS_COD_Internalname = "" ;
         edtBUS_PAR_Internalname = "" ;
         edtBUS_RUB_Internalname = "" ;
         AV27visualizacion = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A18TTBUS_RubroDesc = "" ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         A30TTBUS_DesProveedor = "" ;
         A38TTBUS_DesPosicion = "" ;
         AV14SEC_CRE = "" ;
         AV15SEC_DRE = "" ;
         A8BUS_EMP = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l12TTBUS_Descripcion = "" ;
         H000C2_A12TTBUS_Descripcion = new String[] {""} ;
         H000C3_A12TTBUS_Descripcion = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         AV30TTBUS_Descripcion = "" ;
         lV30TTBUS_Descripcion = "" ;
         H000C4_A11TTBUS_Id = new int[1] ;
         H000C4_A37TTBUS_CodPosicion = new short[1] ;
         H000C4_A1BUS_RUB = new short[1] ;
         H000C4_n1BUS_RUB = new bool[] {false} ;
         H000C4_A4BUS_PAR = new short[1] ;
         H000C4_n4BUS_PAR = new bool[] {false} ;
         H000C4_A3BUS_COD = new short[1] ;
         H000C4_n3BUS_COD = new bool[] {false} ;
         H000C4_A8BUS_EMP = new String[] {""} ;
         H000C4_n8BUS_EMP = new bool[] {false} ;
         H000C4_A38TTBUS_DesPosicion = new String[] {""} ;
         H000C4_A23TTBUS_Estado = new short[1] ;
         H000C4_A30TTBUS_DesProveedor = new String[] {""} ;
         H000C4_A27TTBUS_CodProveedor = new int[1] ;
         H000C4_n27TTBUS_CodProveedor = new bool[] {false} ;
         H000C4_A29TTBUS_Alquilado = new short[1] ;
         H000C4_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         H000C4_n16TTBUS_FechaBaja = new bool[] {false} ;
         H000C4_A18TTBUS_RubroDesc = new String[] {""} ;
         H000C4_n18TTBUS_RubroDesc = new bool[] {false} ;
         H000C4_A17TTBUS_RubroBien = new short[1] ;
         H000C4_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         H000C4_A12TTBUS_Descripcion = new String[] {""} ;
         H000C5_AGRID1_nRecordCount = new int[1] ;
         AV7Context = new SdtContext(context);
         AV26USUARIO = "" ;
         AV16SESION = new GxWebSession( context);
         AV20TTBUS_Estado = 1 ;
         AV17SISTEMA = "" ;
         H000C6_A33TTBUS7_Pos = new short[1] ;
         H000C6_A35TTBUS7_CodResp = new String[] {""} ;
         H000C6_A36TTBUS7_DesResp = new String[] {""} ;
         H000C6_n36TTBUS7_DesResp = new bool[] {false} ;
         H000C7_A52TTBUS2_IdMovimiento = new long[1] ;
         H000C7_A22TTBUS2_IdBien = new int[1] ;
         H000C7_A26TTBUS2_EstadoEnvio = new short[1] ;
         H000C7_A24TTBUS2_RespDesde = new String[] {""} ;
         H000C7_A25TTBUS2_RespHacia = new String[] {""} ;
         AV22TTBUS2_RespDesde = "" ;
         AV23TTBUS2_RespHacia = "" ;
         AV8dUSU_DES = "" ;
         AV10hUSU_DES = "" ;
         H000C8_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         H000C9_A34TTBUS7_Des = new String[] {""} ;
         H000C9_n34TTBUS7_Des = new bool[] {false} ;
         H000C9_A33TTBUS7_Pos = new short[1] ;
         A34TTBUS7_Des = "" ;
         H000C10_A34TTBUS7_Des = new String[] {""} ;
         H000C10_n34TTBUS7_Des = new bool[] {false} ;
         H000C10_A35TTBUS7_CodResp = new String[] {""} ;
         H000C10_A33TTBUS7_Pos = new short[1] ;
         H000C11_A39TTBUS7_CodUsuario = new String[] {""} ;
         H000C11_A33TTBUS7_Pos = new short[1] ;
         A39TTBUS7_CodUsuario = "" ;
         H000C12_A6USU_COD = new String[] {""} ;
         H000C12_A7USU_DES = new String[] {""} ;
         H000C13_A6USU_COD = new String[] {""} ;
         H000C13_A7USU_DES = new String[] {""} ;
         AV12NOMBRE_REPORTE = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
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
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         GXt_char18 = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char19 = "" ;
         GXt_char20 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus030__default(),
            new Object[][] {
                new Object[] {
               H000C2_A12TTBUS_Descripcion
               }
               , new Object[] {
               H000C3_A12TTBUS_Descripcion
               }
               , new Object[] {
               H000C4_A11TTBUS_Id, H000C4_A37TTBUS_CodPosicion, H000C4_A1BUS_RUB, H000C4_n1BUS_RUB, H000C4_A4BUS_PAR, H000C4_n4BUS_PAR, H000C4_A3BUS_COD, H000C4_n3BUS_COD, H000C4_A8BUS_EMP, H000C4_n8BUS_EMP,
               H000C4_A38TTBUS_DesPosicion, H000C4_A23TTBUS_Estado, H000C4_A30TTBUS_DesProveedor, H000C4_A27TTBUS_CodProveedor, H000C4_n27TTBUS_CodProveedor, H000C4_A29TTBUS_Alquilado, H000C4_A16TTBUS_FechaBaja, H000C4_n16TTBUS_FechaBaja, H000C4_A18TTBUS_RubroDesc, H000C4_n18TTBUS_RubroDesc,
               H000C4_A17TTBUS_RubroBien, H000C4_A13TTBUS_FechaCarga, H000C4_A12TTBUS_Descripcion
               }
               , new Object[] {
               H000C5_AGRID1_nRecordCount
               }
               , new Object[] {
               H000C6_A33TTBUS7_Pos, H000C6_A35TTBUS7_CodResp, H000C6_A36TTBUS7_DesResp, H000C6_n36TTBUS7_DesResp
               }
               , new Object[] {
               H000C7_A52TTBUS2_IdMovimiento, H000C7_A22TTBUS2_IdBien, H000C7_A26TTBUS2_EstadoEnvio, H000C7_A24TTBUS2_RespDesde, H000C7_A25TTBUS2_RespHacia
               }
               , new Object[] {
               H000C8_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               H000C9_A34TTBUS7_Des, H000C9_n34TTBUS7_Des, H000C9_A33TTBUS7_Pos
               }
               , new Object[] {
               H000C10_A34TTBUS7_Des, H000C10_n34TTBUS7_Des, H000C10_A35TTBUS7_CodResp, H000C10_A33TTBUS7_Pos
               }
               , new Object[] {
               H000C11_A39TTBUS7_CodUsuario, H000C11_A33TTBUS7_Pos
               }
               , new Object[] {
               H000C12_A6USU_COD, H000C12_A7USU_DES
               }
               , new Object[] {
               H000C13_A6USU_COD, H000C13_A7USU_DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavSec_cre_Enabled = 0 ;
         imgprompt_Ttbus_rubrobien_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus_rub.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS_RUBROBIEN"+"'), id:'"+"vTTBUS_RUBROBIEN"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_50_idx=1 ;
      private short AV25TTBUS7_Pos ;
      private short A23TTBUS_Estado ;
      private short AV34TTBUS_RubroBien ;
      private short A33TTBUS7_Pos ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A17TTBUS_RubroBien ;
      private short A29TTBUS_Alquilado ;
      private short A37TTBUS_CodPosicion ;
      private short A3BUS_COD ;
      private short A4BUS_PAR ;
      private short A1BUS_RUB ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short AV11inicio ;
      private short AV20TTBUS_Estado ;
      private short A26TTBUS2_EstadoEnvio ;
      private short AV6band ;
      private short AV28vTTBUS7_Pos ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int edtavSec_dre_Enabled ;
      private int Grid1_PageSize50 ;
      private int edtavSec_cre_Enabled ;
      private int AV21TTBUS_Id ;
      private int AV33pTTBUS_Id ;
      private int GRID1_nFirstRecordOnPage ;
      private int A11TTBUS_Id ;
      private int A27TTBUS_CodProveedor ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int A22TTBUS2_IdBien ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavVisualizacion_Enabled ;
      private int edtavVisualizacion_Visible ;
      private int edtavSec_cre_Visible ;
      private int edtavSec_dre_Visible ;
      private decimal AV45Gttbus_id ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_50_idx="0001" ;
      private String edtavSec_dre_Internalname ;
      private String edtavSec_cre_Internalname ;
      private String GXCCtl ;
      private String chkTTBUS_Alquilado_Internalname ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String A25TTBUS2_RespHacia ;
      private String A24TTBUS2_RespDesde ;
      private String A36TTBUS7_DesResp ;
      private String A35TTBUS7_CodResp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavVisualizacion_Internalname ;
      private String edtTTBUS_Id_Internalname ;
      private String edtTTBUS_Descripcion_Internalname ;
      private String edtTTBUS_FechaCarga_Internalname ;
      private String edtTTBUS_RubroBien_Internalname ;
      private String edtTTBUS_RubroDesc_Internalname ;
      private String edtTTBUS_FechaBaja_Internalname ;
      private String edtTTBUS_CodProveedor_Internalname ;
      private String edtTTBUS_DesProveedor_Internalname ;
      private String cmbTTBUS_Estado_Internalname ;
      private String edtTTBUS_CodPosicion_Internalname ;
      private String edtTTBUS_DesPosicion_Internalname ;
      private String edtBUS_EMP_Internalname ;
      private String edtBUS_COD_Internalname ;
      private String edtBUS_PAR_Internalname ;
      private String edtBUS_RUB_Internalname ;
      private String A18TTBUS_RubroDesc ;
      private String A30TTBUS_DesProveedor ;
      private String A38TTBUS_DesPosicion ;
      private String AV14SEC_CRE ;
      private String AV15SEC_DRE ;
      private String A8BUS_EMP ;
      private String edtavTtbus_id_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String imgprompt_Ttbus_rubrobien_Link ;
      private String edtavFttbus_descripcion_Internalname ;
      private String edtavTtbus_rubrobien_Internalname ;
      private String cmbavTtbus7_pos_Internalname ;
      private String edtavTtbus_fechacarga_Internalname ;
      private String subGrid1_Internalname ;
      private String AV26USUARIO ;
      private String AV17SISTEMA ;
      private String AV22TTBUS2_RespDesde ;
      private String AV23TTBUS2_RespHacia ;
      private String AV8dUSU_DES ;
      private String AV10hUSU_DES ;
      private String A40TTBUS8_CodUsuario ;
      private String A34TTBUS7_Des ;
      private String A39TTBUS7_CodUsuario ;
      private String AV12NOMBRE_REPORTE ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
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
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavTtbus_id_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavFttbus_descripcion_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavTtbus_rubrobien_Jsonclick ;
      private String imgprompt_Ttbus_rubrobien_Internalname ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String cmbavTtbus7_pos_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavTtbus_fechacarga_Jsonclick ;
      private String GXt_char18 ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String edtavVisualizacion_Jsonclick ;
      private String ROClassString ;
      private String edtTTBUS_Id_Jsonclick ;
      private String edtTTBUS_Descripcion_Jsonclick ;
      private String edtTTBUS_FechaCarga_Jsonclick ;
      private String edtTTBUS_RubroBien_Jsonclick ;
      private String edtTTBUS_RubroDesc_Jsonclick ;
      private String edtTTBUS_FechaBaja_Jsonclick ;
      private String edtTTBUS_CodProveedor_Jsonclick ;
      private String edtTTBUS_DesProveedor_Jsonclick ;
      private String cmbTTBUS_Estado_Jsonclick ;
      private String edtTTBUS_CodPosicion_Jsonclick ;
      private String edtTTBUS_DesPosicion_Jsonclick ;
      private String edtavSec_cre_Jsonclick ;
      private String GXt_char19 ;
      private String edtavSec_dre_Jsonclick ;
      private String edtBUS_EMP_Jsonclick ;
      private String edtBUS_COD_Jsonclick ;
      private String edtBUS_PAR_Jsonclick ;
      private String edtBUS_RUB_Jsonclick ;
      private String GXt_char20 ;
      private DateTime AV32TTBUS_FechaCarga ;
      private DateTime A13TTBUS_FechaCarga ;
      private DateTime A16TTBUS_FechaBaja ;
      private bool entryPointCalled ;
      private bool n36TTBUS7_DesResp ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n18TTBUS_RubroDesc ;
      private bool n16TTBUS_FechaBaja ;
      private bool n27TTBUS_CodProveedor ;
      private bool n8BUS_EMP ;
      private bool n3BUS_COD ;
      private bool n4BUS_PAR ;
      private bool n1BUS_RUB ;
      private bool returnInSub ;
      private bool n34TTBUS7_Des ;
      private String A12TTBUS_Descripcion ;
      private String AV31fTTBUS_Descripcion ;
      private String l12TTBUS_Descripcion ;
      private String AV30TTBUS_Descripcion ;
      private String lV30TTBUS_Descripcion ;
      private String AV27visualizacion ;
      private GxWebSession AV16SESION ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavTtbus7_pos ;
      private GXCheckbox chkTTBUS_Alquilado ;
      private GXCombobox cmbTTBUS_Estado ;
      private IDataStoreProvider pr_default ;
      private String[] H000C2_A12TTBUS_Descripcion ;
      private String[] H000C3_A12TTBUS_Descripcion ;
      private int[] H000C4_A11TTBUS_Id ;
      private short[] H000C4_A37TTBUS_CodPosicion ;
      private short[] H000C4_A1BUS_RUB ;
      private bool[] H000C4_n1BUS_RUB ;
      private short[] H000C4_A4BUS_PAR ;
      private bool[] H000C4_n4BUS_PAR ;
      private short[] H000C4_A3BUS_COD ;
      private bool[] H000C4_n3BUS_COD ;
      private String[] H000C4_A8BUS_EMP ;
      private bool[] H000C4_n8BUS_EMP ;
      private String[] H000C4_A38TTBUS_DesPosicion ;
      private short[] H000C4_A23TTBUS_Estado ;
      private String[] H000C4_A30TTBUS_DesProveedor ;
      private int[] H000C4_A27TTBUS_CodProveedor ;
      private bool[] H000C4_n27TTBUS_CodProveedor ;
      private short[] H000C4_A29TTBUS_Alquilado ;
      private DateTime[] H000C4_A16TTBUS_FechaBaja ;
      private bool[] H000C4_n16TTBUS_FechaBaja ;
      private String[] H000C4_A18TTBUS_RubroDesc ;
      private bool[] H000C4_n18TTBUS_RubroDesc ;
      private short[] H000C4_A17TTBUS_RubroBien ;
      private DateTime[] H000C4_A13TTBUS_FechaCarga ;
      private String[] H000C4_A12TTBUS_Descripcion ;
      private int[] H000C5_AGRID1_nRecordCount ;
      private short[] H000C6_A33TTBUS7_Pos ;
      private String[] H000C6_A35TTBUS7_CodResp ;
      private String[] H000C6_A36TTBUS7_DesResp ;
      private bool[] H000C6_n36TTBUS7_DesResp ;
      private long[] H000C7_A52TTBUS2_IdMovimiento ;
      private int[] H000C7_A22TTBUS2_IdBien ;
      private short[] H000C7_A26TTBUS2_EstadoEnvio ;
      private String[] H000C7_A24TTBUS2_RespDesde ;
      private String[] H000C7_A25TTBUS2_RespHacia ;
      private String[] H000C8_A40TTBUS8_CodUsuario ;
      private String[] H000C9_A34TTBUS7_Des ;
      private bool[] H000C9_n34TTBUS7_Des ;
      private short[] H000C9_A33TTBUS7_Pos ;
      private String[] H000C10_A34TTBUS7_Des ;
      private bool[] H000C10_n34TTBUS7_Des ;
      private String[] H000C10_A35TTBUS7_CodResp ;
      private short[] H000C10_A33TTBUS7_Pos ;
      private String[] H000C11_A39TTBUS7_CodUsuario ;
      private short[] H000C11_A33TTBUS7_Pos ;
      private String[] H000C12_A6USU_COD ;
      private String[] H000C12_A7USU_DES ;
      private String[] H000C13_A6USU_COD ;
      private String[] H000C13_A7USU_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pTTBUS_Id ;
      private GXWebForm Form ;
      private SdtContext AV7Context ;
   }

   public class htbus030__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000C4( short AV25TTBUS7_Pos ,
                                             String AV31fTTBUS_Descripcion ,
                                             DateTime AV32TTBUS_FechaCarga ,
                                             short AV34TTBUS_RubroBien ,
                                             short A37TTBUS_CodPosicion ,
                                             String A12TTBUS_Descripcion ,
                                             String AV30TTBUS_Descripcion ,
                                             DateTime A13TTBUS_FechaCarga ,
                                             short A17TTBUS_RubroBien ,
                                             DateTime A16TTBUS_FechaBaja ,
                                             short A23TTBUS_Estado ,
                                             String A8BUS_EMP ,
                                             short A1BUS_RUB ,
                                             short A3BUS_COD ,
                                             short A4BUS_PAR ,
                                             int AV21TTBUS_Id )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int21 ;
         GXv_int21 = new short [5] ;
         Object[] GXv_Object22 ;
         GXv_Object22 = new Object [2] ;
         scmdbuf = "SELECT T1.[TTBUS_Id], T1.[TTBUS_CodPosicion], T1.[BUS_RUB], T1.[BUS_PAR], T1.[BUS_COD], T1.[BUS_EMP], T1.[TTBUS_DesPosicion], T1.[TTBUS_Estado], T1.[TTBUS_DesProveedor], T1.[TTBUS_CodProveedor], T1.[TTBUS_Alquilado], T1.[TTBUS_FechaBaja], T2.[RBR_DES] AS TTBUS_RubroDesc, T1.[TTBUS_RubroBien] AS TTBUS_RubroBien, T1.[TTBUS_FechaCarga], T1.[TTBUS_Descripcion] FROM ([TTBUS000] T1 WITH (NOLOCK) INNER JOIN [BUS002] T2 WITH (NOLOCK) ON T2.[RBR_COD] = T1.[TTBUS_RubroBien])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS_Id] >= @AV21TTBUS_Id)" ;
         scmdbuf = scmdbuf + " and ((T1.[TTBUS_FechaBaja] = convert( DATETIME, '17530101', 112 )))" ;
         scmdbuf = scmdbuf + " and (T1.[TTBUS_Estado] <= 2)" ;
         scmdbuf = scmdbuf + " and (T1.[BUS_EMP] = '')" ;
         scmdbuf = scmdbuf + " and (T1.[BUS_RUB] = 0)" ;
         scmdbuf = scmdbuf + " and (T1.[BUS_COD] = 0)" ;
         scmdbuf = scmdbuf + " and (T1.[BUS_PAR] = 0)" ;
         if ( AV25TTBUS7_Pos != -1 )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_CodPosicion] = @AV25TTBUS7_Pos)" ;
         }
         else
         {
            GXv_int21[1] = 1 ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV31fTTBUS_Descripcion)) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_Descripcion] like @AV30TTBUS_Descripcion)" ;
         }
         else
         {
            GXv_int21[2] = 1 ;
         }
         if ( ! (DateTime.MinValue==AV32TTBUS_FechaCarga) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_FechaCarga] >= @AV32TTBUS_FechaCarga)" ;
         }
         else
         {
            GXv_int21[3] = 1 ;
         }
         if ( ! (0==AV34TTBUS_RubroBien) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_RubroBien] = @AV34TTBUS_RubroBien)" ;
         }
         else
         {
            GXv_int21[4] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS_Id]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 11)" ;
         GXv_Object22[0] = scmdbuf ;
         GXv_Object22[1] = (Object)(GXv_int21) ;
         return GXv_Object22 ;
      }

      protected Object[] conditional_H000C5( short AV25TTBUS7_Pos ,
                                             String AV31fTTBUS_Descripcion ,
                                             DateTime AV32TTBUS_FechaCarga ,
                                             short AV34TTBUS_RubroBien ,
                                             short A37TTBUS_CodPosicion ,
                                             String A12TTBUS_Descripcion ,
                                             String AV30TTBUS_Descripcion ,
                                             DateTime A13TTBUS_FechaCarga ,
                                             short A17TTBUS_RubroBien ,
                                             DateTime A16TTBUS_FechaBaja ,
                                             short A23TTBUS_Estado ,
                                             String A8BUS_EMP ,
                                             short A1BUS_RUB ,
                                             short A3BUS_COD ,
                                             short A4BUS_PAR ,
                                             int AV21TTBUS_Id )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int23 ;
         GXv_int23 = new short [5] ;
         Object[] GXv_Object24 ;
         GXv_Object24 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([TTBUS000] T1 WITH (NOLOCK) INNER JOIN [BUS002] T2 WITH (NOLOCK) ON T2.[RBR_COD] = T1.[TTBUS_RubroBien])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS_Id] >= @AV21TTBUS_Id)" ;
         scmdbuf = scmdbuf + " and ((T1.[TTBUS_FechaBaja] = convert( DATETIME, '17530101', 112 )))" ;
         scmdbuf = scmdbuf + " and (T1.[TTBUS_Estado] <= 2)" ;
         scmdbuf = scmdbuf + " and (T1.[BUS_EMP] = '')" ;
         scmdbuf = scmdbuf + " and (T1.[BUS_RUB] = 0)" ;
         scmdbuf = scmdbuf + " and (T1.[BUS_COD] = 0)" ;
         scmdbuf = scmdbuf + " and (T1.[BUS_PAR] = 0)" ;
         if ( AV25TTBUS7_Pos != -1 )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_CodPosicion] = @AV25TTBUS7_Pos)" ;
         }
         else
         {
            GXv_int23[1] = 1 ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV31fTTBUS_Descripcion)) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_Descripcion] like @AV30TTBUS_Descripcion)" ;
         }
         else
         {
            GXv_int23[2] = 1 ;
         }
         if ( ! (DateTime.MinValue==AV32TTBUS_FechaCarga) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_FechaCarga] >= @AV32TTBUS_FechaCarga)" ;
         }
         else
         {
            GXv_int23[3] = 1 ;
         }
         if ( ! (0==AV34TTBUS_RubroBien) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_RubroBien] = @AV34TTBUS_RubroBien)" ;
         }
         else
         {
            GXv_int23[4] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + "" ;
         GXv_Object24[0] = scmdbuf ;
         GXv_Object24[1] = (Object)(GXv_int23) ;
         return GXv_Object24 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 2 :
                     return conditional_H000C4( (short)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (short)dynConstraints[8] , (DateTime)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (int)dynConstraints[15] );
               case 3 :
                     return conditional_H000C5( (short)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (short)dynConstraints[8] , (DateTime)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (int)dynConstraints[15] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000C2 ;
          prmH000C2 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH000C3 ;
          prmH000C3 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH000C6 ;
          prmH000C6 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH000C7 ;
          prmH000C7 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH000C8 ;
          prmH000C8 = new Object[] {
          new Object[] {"@AV26USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH000C9 ;
          prmH000C9 = new Object[] {
          } ;
          Object[] prmH000C10 ;
          prmH000C10 = new Object[] {
          } ;
          Object[] prmH000C11 ;
          prmH000C11 = new Object[] {
          new Object[] {"@AV28vTTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV26USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH000C12 ;
          prmH000C12 = new Object[] {
          new Object[] {"@AV22TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmH000C13 ;
          prmH000C13 = new Object[] {
          new Object[] {"@AV23TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmH000C4 ;
          prmH000C4 = new Object[] {
          new Object[] {"@AV21TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV25TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV30TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV32TTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV34TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000C5 ;
          prmH000C5 = new Object[] {
          new Object[] {"@AV21TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV25TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV30TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV32TTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV34TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000C2", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C2,0,0,true,false )
             ,new CursorDef("H000C3", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C3,0,0,true,false )
             ,new CursorDef("H000C4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C4,11,0,true,false )
             ,new CursorDef("H000C5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C5,1,0,true,false )
             ,new CursorDef("H000C6", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @TTBUS_CodPosicion ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C6,1,0,false,true )
             ,new CursorDef("H000C7", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_RespDesde], [TTBUS2_RespHacia] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C7,100,0,true,false )
             ,new CursorDef("H000C8", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV26USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C8,1,0,false,true )
             ,new CursorDef("H000C9", "SELECT T2.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_Pos] AS TTBUS7_Pos FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C9,100,0,false,false )
             ,new CursorDef("H000C10", "SELECT T2.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T1.[TTBUS7_Pos] AS TTBUS7_Pos FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C10,100,0,true,false )
             ,new CursorDef("H000C11", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV28vTTBUS7_Pos and [TTBUS7_CodUsuario] = @AV26USUARIO ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C11,1,0,false,true )
             ,new CursorDef("H000C12", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV22TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C12,1,0,false,true )
             ,new CursorDef("H000C13", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV23TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C13,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getString(7, 50) ;
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((String[]) buf[12])[0] = rslt.getString(9, 30) ;
                ((int[]) buf[13])[0] = rslt.getInt(10) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(10);
                ((short[]) buf[15])[0] = rslt.getShort(11) ;
                ((DateTime[]) buf[16])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(12);
                ((String[]) buf[18])[0] = rslt.getString(13, 30) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((short[]) buf[20])[0] = rslt.getShort(14) ;
                ((DateTime[]) buf[21])[0] = rslt.getGXDate(15) ;
                ((String[]) buf[22])[0] = rslt.getVarchar(16) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 16) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (DateTime)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                break;
             case 3 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (DateTime)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
