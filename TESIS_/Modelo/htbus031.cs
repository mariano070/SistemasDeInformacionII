/*
               File: HTBUS031
        Description: Consulta de Trazabilidad de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:6.82
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
   public class htbus031 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus031( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus031( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_pTTBUS_Id ,
                           ref String aP1_SISTEMA ,
                           ref String aP2_USUARIO )
      {
         this.AV33pTTBUS_Id = aP0_pTTBUS_Id;
         this.AV17SISTEMA = aP1_SISTEMA;
         this.AV26USUARIO = aP2_USUARIO;
         executePrivate();
         aP0_pTTBUS_Id=this.AV33pTTBUS_Id;
         aP1_SISTEMA=this.AV17SISTEMA;
         aP2_USUARIO=this.AV26USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               GXSGATTBUS_DESCRIPCION0D0( A12TTBUS_Descripcion) ;
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
               nGXsfl_8_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_8_idx = GetNextPar( ) ;
               edtavSec_dre_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_8_idx, sGXsfl_8_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavSec_cre_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_cre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_cre_Enabled), 5, 0)));
               GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_8_idx ;
               chkTTBUS_Alquilado.Name = GXCCtl ;
               chkTTBUS_Alquilado.WebTags = "" ;
               chkTTBUS_Alquilado.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
               chkTTBUS_Alquilado.CheckedValue = "0" ;
               GXCCtl = "TTBUS_ESTADO_" + sGXsfl_8_idx ;
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
               AV33pTTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33pTTBUS_Id), 8, 0)));
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
               n35TTBUS7_CodResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( AV33pTTBUS_Id, A7USU_DES, A6USU_COD, A25TTBUS2_RespHacia, A24TTBUS2_RespDesde, A36TTBUS7_DesResp, A35TTBUS7_CodResp, A33TTBUS7_Pos) ;
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
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV17SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17SISTEMA", AV17SISTEMA);
                  AV26USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26USUARIO", AV26USUARIO);
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
         PA0D2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0D2( ) ;
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
         FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus031.aspx") + "?" + UrlEncode("" +AV33pTTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(AV17SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV26USUARIO))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33pTTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV17SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV26USUARIO));
         GxWebStd.gx_hidden_field( context, "USU_DES", StringUtil.RTrim( A7USU_DES));
         GxWebStd.gx_hidden_field( context, "USU_COD", StringUtil.RTrim( A6USU_COD));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPHACIA", StringUtil.RTrim( A25TTBUS2_RespHacia));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPDESDE", StringUtil.RTrim( A24TTBUS2_RespDesde));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DESRESP", StringUtil.RTrim( A36TTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODRESP", StringUtil.RTrim( A35TTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE0D2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0D2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS031" ;
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
         return formatLink("htbus031.aspx") + "?" + UrlEncode("" +AV33pTTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(AV17SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV26USUARIO)) ;
      }

      protected void WB0D0( )
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
            wb_table1_2_0D2( true) ;
         }
         else
         {
            wb_table1_2_0D2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0D2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0D2( )
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
         STRUP0D0( ) ;
      }

      protected void WS0D2( )
      {
         START0D2( ) ;
         EVT0D2( ) ;
      }

      protected void EVT0D2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'MOVIMIENTOS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E110D2 */
                              E110D2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "'MOVIMIENTOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) )
                           {
                              nGXsfl_8_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
                              edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_8_idx ;
                              edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
                              edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
                              edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
                              edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_8_idx ;
                              edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_8_idx ;
                              edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_8_idx ;
                              chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_8_idx ;
                              edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_8_idx ;
                              edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_8_idx ;
                              cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_8_idx ;
                              edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_8_idx ;
                              edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_8_idx ;
                              edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_8_idx ;
                              edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_8_idx ;
                              AV27visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV27visualizacion));
                              A14IdIdentificador = (int)(context.localUtil.CToN( cgiGet( edtIdIdentificador_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
                              A15NumeroIdentificador = cgiGet( edtNumeroIdentificador_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
                              A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                              A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                              A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
                              A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
                              n16TTBUS_FechaBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
                              A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
                              A27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".")) ;
                              n27TTBUS_CodProveedor = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
                              A30TTBUS_DesProveedor = cgiGet( edtTTBUS_DesProveedor_Internalname) ;
                              n30TTBUS_DesProveedor = false ;
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
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120D2 */
                                    E120D2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'VISUALIZACION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E130D2 */
                                    E130D2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E140D2 */
                                    E140D2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MOVIMIENTOS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110D2 */
                                    E110D2 ();
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
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE0D2( )
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

      protected void PA0D2( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_8_idx ;
            chkTTBUS_Alquilado.Name = GXCCtl ;
            chkTTBUS_Alquilado.WebTags = "" ;
            chkTTBUS_Alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
            chkTTBUS_Alquilado.CheckedValue = "0" ;
            GXCCtl = "TTBUS_ESTADO_" + sGXsfl_8_idx ;
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
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGATTBUS_DESCRIPCION0D0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS_DESCRIPCION_data0D0( A12TTBUS_Descripcion) ;
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

      protected void GXSGATTBUS_DESCRIPCION_data0D0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H000D2 */
         pr_default.execute(0, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H000D2_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H000D2_A12TTBUS_Descripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_8_idx ,
                                       String sGXsfl_8_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_8_idx ;
         edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_8_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_8_idx ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_8_idx ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_8_idx ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_8_idx ;
         edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_8_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_8_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_8_idx ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_8_idx ;
         edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_8_idx ;
         edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_8_idx ;
         while ( nGXsfl_8_idx <= nRC_Grid1 )
         {
            sendrow_82( ) ;
            nGXsfl_8_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_8_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_8_idx+1)) ;
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_8_idx ;
            edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_8_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_8_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_8_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_8_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_8_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_8_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_8_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_8_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_8_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_8_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_8_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int AV33pTTBUS_Id ,
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
         RF0D2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0D2( ) ;
         /* End function Refresh */
      }

      protected void RF0D2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 8 ;
         nGXsfl_8_idx = 1 ;
         sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_8_idx ;
         edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_8_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_8_idx ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_8_idx ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_8_idx ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_8_idx ;
         edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_8_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_8_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_8_idx ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_8_idx ;
         edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_8_idx ;
         edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_8_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_8_idx ;
            edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_8_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_8_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_8_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_8_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_8_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_8_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_8_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_8_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_8_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_8_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_8_idx ;
            /* Using cursor H000D3 */
            pr_default.execute(1, new Object[] {AV33pTTBUS_Id});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A11TTBUS_Id = H000D3_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A37TTBUS_CodPosicion = H000D3_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A35TTBUS7_CodResp = H000D3_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               n35TTBUS7_CodResp = H000D3_n35TTBUS7_CodResp[0] ;
               A36TTBUS7_DesResp = H000D3_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H000D3_n36TTBUS7_DesResp[0] ;
               A38TTBUS_DesPosicion = H000D3_A38TTBUS_DesPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               A23TTBUS_Estado = H000D3_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A30TTBUS_DesProveedor = H000D3_A30TTBUS_DesProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
               n30TTBUS_DesProveedor = H000D3_n30TTBUS_DesProveedor[0] ;
               A27TTBUS_CodProveedor = H000D3_A27TTBUS_CodProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               n27TTBUS_CodProveedor = H000D3_n27TTBUS_CodProveedor[0] ;
               A29TTBUS_Alquilado = H000D3_A29TTBUS_Alquilado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A16TTBUS_FechaBaja = H000D3_A16TTBUS_FechaBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               n16TTBUS_FechaBaja = H000D3_n16TTBUS_FechaBaja[0] ;
               A13TTBUS_FechaCarga = H000D3_A13TTBUS_FechaCarga[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A12TTBUS_Descripcion = H000D3_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A15NumeroIdentificador = H000D3_A15NumeroIdentificador[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
               A14IdIdentificador = H000D3_A14IdIdentificador[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
               A37TTBUS_CodPosicion = H000D3_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A38TTBUS_DesPosicion = H000D3_A38TTBUS_DesPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               A23TTBUS_Estado = H000D3_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A27TTBUS_CodProveedor = H000D3_A27TTBUS_CodProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               n27TTBUS_CodProveedor = H000D3_n27TTBUS_CodProveedor[0] ;
               A29TTBUS_Alquilado = H000D3_A29TTBUS_Alquilado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A16TTBUS_FechaBaja = H000D3_A16TTBUS_FechaBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               n16TTBUS_FechaBaja = H000D3_n16TTBUS_FechaBaja[0] ;
               A13TTBUS_FechaCarga = H000D3_A13TTBUS_FechaCarga[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A12TTBUS_Descripcion = H000D3_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A35TTBUS7_CodResp = H000D3_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               n35TTBUS7_CodResp = H000D3_n35TTBUS7_CodResp[0] ;
               A36TTBUS7_DesResp = H000D3_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H000D3_n36TTBUS7_DesResp[0] ;
               A30TTBUS_DesProveedor = H000D3_A30TTBUS_DesProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
               n30TTBUS_DesProveedor = H000D3_n30TTBUS_DesProveedor[0] ;
               /* Execute user event: E140D2 */
               E140D2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            wbEnd = 8 ;
            WB0D0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP0D0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavSec_cre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_cre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_cre_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E120D2 */
         E120D2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV33pTTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "vPTTBUS_ID"), ",", ".")) ;
            AV17SISTEMA = cgiGet( "vSISTEMA") ;
            AV26USUARIO = cgiGet( "vUSUARIO") ;
            /* Read subfile selected row values. */
            nGXsfl_8_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_8_idx ;
            edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_8_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_8_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_8_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_8_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_8_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_8_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_8_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_8_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_8_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_8_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_8_idx ;
            if ( nGXsfl_8_idx > 0 )
            {
               AV27visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
               A14IdIdentificador = (int)(context.localUtil.CToN( cgiGet( edtIdIdentificador_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
               A15NumeroIdentificador = cgiGet( edtNumeroIdentificador_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
               A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
               n16TTBUS_FechaBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".")) ;
               n27TTBUS_CodProveedor = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               A30TTBUS_DesProveedor = cgiGet( edtTTBUS_DesProveedor_Internalname) ;
               n30TTBUS_DesProveedor = false ;
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
         /* Execute user event: E120D2 */
         E120D2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E120D2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV7Context) ;
         AV26USUARIO = AV7Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26USUARIO", AV26USUARIO);
         edtavSec_dre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
         AV11inicio = (short)(NumberUtil.Val( AV16SESION.Get("Inicio"), ".")) ;
         if ( AV11inicio < 2 )
         {
            AV11inicio = (short)(AV11inicio+1) ;
            AV16SESION.Set("Inicio", StringUtil.Str( (decimal)(AV11inicio), 1, 0));
            context.DoAjaxRefresh();
         }
      }

      protected void E130D2( )
      {
         /* 'Visualizacion' Routine */
         context.wjLoc = formatLink("ttbus000.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A37TTBUS_CodPosicion) + "," + UrlEncode(StringUtil.RTrim(AV14SEC_CRE)) + "," + UrlEncode("" +AV20TTBUS_Estado) + "," + UrlEncode("" +2) + "," + UrlEncode(StringUtil.RTrim(AV17SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV26USUARIO)) ;
      }

      private void E140D2( )
      {
         /* Grid1_Load Routine */
         AV27visualizacion = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV27visualizacion));
         if ( A23TTBUS_Estado == 1 )
         {
            /* Using cursor H000D4 */
            pr_default.execute(2, new Object[] {A37TTBUS_CodPosicion});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A33TTBUS7_Pos = H000D4_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               AV14SEC_CRE = A35TTBUS7_CodResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14SEC_CRE", AV14SEC_CRE);
               AV15SEC_DRE = A36TTBUS7_DesResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SEC_DRE", AV15SEC_DRE);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
         }
         else
         {
            /* Using cursor H000D5 */
            pr_default.execute(3, new Object[] {A11TTBUS_Id});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A22TTBUS2_IdBien = H000D5_A22TTBUS2_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
               A26TTBUS2_EstadoEnvio = H000D5_A26TTBUS2_EstadoEnvio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
               A24TTBUS2_RespDesde = H000D5_A24TTBUS2_RespDesde[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A25TTBUS2_RespHacia = H000D5_A25TTBUS2_RespHacia[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               AV22TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
               AV23TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
               /* Execute user subroutine: S114 */
               S114 ();
               if ( returnInSub )
               {
                  pr_default.close(3);
                  returnInSub = true;
                  if (true) return;
               }
               pr_default.readNext(3);
            }
            pr_default.close(3);
            AV15SEC_DRE = StringUtil.Trim( AV8dUSU_DES) + " Y " + StringUtil.Trim( AV10hUSU_DES) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SEC_DRE", AV15SEC_DRE);
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 8 ;
         }
         sendrow_82( ) ;
      }

      protected void E110D2( )
      {
         /* 'Movimientos' Routine */
         AV16SESION.Set("CONT_MOV", "1");
         context.PopUp(formatLink("htbus002.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(A12TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim(AV17SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV26USUARIO)), new Object[] {"A11TTBUS_Id","A12TTBUS_Descripcion","AV17SISTEMA","AV26USUARIO"});
      }

      protected void S114( )
      {
         /* 'RESPONSABLES' Routine */
         /* Using cursor H000D6 */
         pr_default.execute(4, new Object[] {AV22TTBUS2_RespDesde});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A6USU_COD = H000D6_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H000D6_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV8dUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(4);
         /* Using cursor H000D7 */
         pr_default.execute(5, new Object[] {AV23TTBUS2_RespHacia});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A6USU_COD = H000D7_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H000D7_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV10hUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(5);
      }

      protected void wb_table1_2_0D2( bool wbgen )
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id Identificador") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Etiqueta") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14IdIdentificador), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A15NumeroIdentificador));
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
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 8 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_8_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Ver Movimientos del Bien", "Ver Movimientos del Bien", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'MOVIMIENTOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(8), 3, 0)+","+"null"+");", "", "HLP_HTBUS031.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0D2e( true) ;
         }
         else
         {
            wb_table1_2_0D2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV33pTTBUS_Id = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33pTTBUS_Id), 8, 0)));
         AV17SISTEMA = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17SISTEMA", AV17SISTEMA);
         AV26USUARIO = (String)getParm(obj,2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26USUARIO", AV26USUARIO);
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
         PA0D2( ) ;
         WS0D2( ) ;
         WE0D2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1147739");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("htbus031.js", "?1147739");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_82( )
      {
         WB0D0( ) ;
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
            if ( ((int)(nGXsfl_8_idx) % (2)) == 0 )
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
         TempTags = " " + ((edtavVisualizacion_Enabled!=0)&&(edtavVisualizacion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 9,'',false,'',8)\"" : " ") ;
         ClassString = "Image" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavVisualizacion_Internalname,(String)"",(String)AV27visualizacion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Visualización",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavVisualizacion_Jsonclick,"E\\'VISUALIZACION\\'."+sGXsfl_8_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtIdIdentificador_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A14IdIdentificador), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A14IdIdentificador), "ZZZZZZZ9"),(String)"",(short)0,(String)edtIdIdentificador_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNumeroIdentificador_Internalname,StringUtil.RTrim( A15NumeroIdentificador),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)80,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A15NumeroIdentificador, "")),(String)"",(short)0,(String)edtNumeroIdentificador_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_Id_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Descripcion_Internalname,StringUtil.RTrim( A12TTBUS_Descripcion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")),(String)"",(short)0,(String)edtTTBUS_Descripcion_Jsonclick,(String)"",(short)8,(short)1,(short)0,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaCarga_Internalname,context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaCarga_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaBaja_Internalname,context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaBaja_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
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
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodProveedor_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A27TTBUS_CodProveedor), "ZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_CodProveedor_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesProveedor_Internalname,StringUtil.RTrim( A30TTBUS_DesProveedor),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesProveedor_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         ClassString = "Attribute" ;
         StyleString = "" ;
         GXCCtl = "TTBUS_ESTADO_" + sGXsfl_8_idx ;
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
         /* ComboBox */
         Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTTBUS_Estado,(String)cmbTTBUS_Estado_Internalname,StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)1,(short)1,(short)0,(short)150,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbTTBUS_Estado_Jsonclick,(String)"",(String)"",(bool)true});
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
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodPosicion_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A37TTBUS_CodPosicion), "ZZ9"),(String)"",(short)0,(String)edtTTBUS_CodPosicion_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesPosicion_Internalname,StringUtil.RTrim( A38TTBUS_DesPosicion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesPosicion_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 22,'',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavSec_cre_Internalname,StringUtil.RTrim( AV14SEC_CRE),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(int)edtavSec_cre_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV14SEC_CRE, "XXXXXXXXXXXXXXX")),TempTags+((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(22);\"" : " "),(short)0,(String)edtavSec_cre_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 23,'',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavSec_dre_Internalname,StringUtil.RTrim( AV15SEC_DRE),(String)"",(short)150,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavSec_dre_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV15SEC_DRE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(23);\"" : " "),(short)0,(String)edtavSec_dre_Jsonclick,(String)"",(short)8,(short)1,(short)-1,(bool)true,(String)"left"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_8_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_8_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_8_idx+1)) ;
         sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_8_idx ;
         edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtNumeroIdentificador_Internalname = "NUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_8_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_8_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_8_idx ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_8_idx ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_8_idx ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_8_idx ;
         edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_8_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_8_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_8_idx ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_8_idx ;
         edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_8_idx ;
         edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_8_idx ;
         /* End function sendrow_82 */
      }

      protected void init_default_properties( )
      {
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
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
         edtTTBUS_FechaCarga_Jsonclick = "" ;
         edtTTBUS_Descripcion_Jsonclick = "" ;
         edtTTBUS_Id_Jsonclick = "" ;
         edtNumeroIdentificador_Jsonclick = "" ;
         edtIdIdentificador_Jsonclick = "" ;
         edtavVisualizacion_Jsonclick = "" ;
         edtavVisualizacion_Visible = -1 ;
         edtavVisualizacion_Enabled = 1 ;
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
         wcpOAV17SISTEMA = "" ;
         wcpOAV26USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A12TTBUS_Descripcion = "" ;
         edtavSec_dre_Internalname = "" ;
         edtavSec_cre_Internalname = "" ;
         GXCCtl = "" ;
         chkTTBUS_Alquilado_Internalname = "" ;
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
         edtIdIdentificador_Internalname = "" ;
         edtNumeroIdentificador_Internalname = "" ;
         edtTTBUS_Id_Internalname = "" ;
         edtTTBUS_Descripcion_Internalname = "" ;
         edtTTBUS_FechaCarga_Internalname = "" ;
         edtTTBUS_FechaBaja_Internalname = "" ;
         edtTTBUS_CodProveedor_Internalname = "" ;
         edtTTBUS_DesProveedor_Internalname = "" ;
         cmbTTBUS_Estado_Internalname = "" ;
         edtTTBUS_CodPosicion_Internalname = "" ;
         edtTTBUS_DesPosicion_Internalname = "" ;
         AV27visualizacion = "" ;
         A15NumeroIdentificador = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         A30TTBUS_DesProveedor = "" ;
         A38TTBUS_DesPosicion = "" ;
         AV14SEC_CRE = "" ;
         AV15SEC_DRE = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l12TTBUS_Descripcion = "" ;
         H000D2_A12TTBUS_Descripcion = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         H000D3_A11TTBUS_Id = new int[1] ;
         H000D3_A37TTBUS_CodPosicion = new short[1] ;
         H000D3_A35TTBUS7_CodResp = new String[] {""} ;
         H000D3_n35TTBUS7_CodResp = new bool[] {false} ;
         H000D3_A36TTBUS7_DesResp = new String[] {""} ;
         H000D3_n36TTBUS7_DesResp = new bool[] {false} ;
         H000D3_A38TTBUS_DesPosicion = new String[] {""} ;
         H000D3_A23TTBUS_Estado = new short[1] ;
         H000D3_A30TTBUS_DesProveedor = new String[] {""} ;
         H000D3_n30TTBUS_DesProveedor = new bool[] {false} ;
         H000D3_A27TTBUS_CodProveedor = new int[1] ;
         H000D3_n27TTBUS_CodProveedor = new bool[] {false} ;
         H000D3_A29TTBUS_Alquilado = new short[1] ;
         H000D3_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         H000D3_n16TTBUS_FechaBaja = new bool[] {false} ;
         H000D3_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         H000D3_A12TTBUS_Descripcion = new String[] {""} ;
         H000D3_A15NumeroIdentificador = new String[] {""} ;
         H000D3_A14IdIdentificador = new int[1] ;
         AV7Context = new SdtContext(context);
         AV16SESION = new GxWebSession( context);
         AV20TTBUS_Estado = 1 ;
         H000D4_A33TTBUS7_Pos = new short[1] ;
         H000D5_A52TTBUS2_IdMovimiento = new long[1] ;
         H000D5_A22TTBUS2_IdBien = new int[1] ;
         H000D5_A26TTBUS2_EstadoEnvio = new short[1] ;
         H000D5_A24TTBUS2_RespDesde = new String[] {""} ;
         H000D5_A25TTBUS2_RespHacia = new String[] {""} ;
         AV22TTBUS2_RespDesde = "" ;
         AV23TTBUS2_RespHacia = "" ;
         AV8dUSU_DES = "" ;
         AV10hUSU_DES = "" ;
         H000D6_A6USU_COD = new String[] {""} ;
         H000D6_A7USU_DES = new String[] {""} ;
         H000D7_A6USU_COD = new String[] {""} ;
         H000D7_A7USU_DES = new String[] {""} ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
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
         Grid1Column = new GXWebColumn();
         GXt_char14 = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char15 = "" ;
         GXt_char16 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus031__default(),
            new Object[][] {
                new Object[] {
               H000D2_A12TTBUS_Descripcion
               }
               , new Object[] {
               H000D3_A11TTBUS_Id, H000D3_A37TTBUS_CodPosicion, H000D3_A35TTBUS7_CodResp, H000D3_n35TTBUS7_CodResp, H000D3_A36TTBUS7_DesResp, H000D3_n36TTBUS7_DesResp, H000D3_A38TTBUS_DesPosicion, H000D3_A23TTBUS_Estado, H000D3_A30TTBUS_DesProveedor, H000D3_n30TTBUS_DesProveedor,
               H000D3_A27TTBUS_CodProveedor, H000D3_n27TTBUS_CodProveedor, H000D3_A29TTBUS_Alquilado, H000D3_A16TTBUS_FechaBaja, H000D3_n16TTBUS_FechaBaja, H000D3_A13TTBUS_FechaCarga, H000D3_A12TTBUS_Descripcion, H000D3_A15NumeroIdentificador, H000D3_A14IdIdentificador
               }
               , new Object[] {
               H000D4_A33TTBUS7_Pos
               }
               , new Object[] {
               H000D5_A52TTBUS2_IdMovimiento, H000D5_A22TTBUS2_IdBien, H000D5_A26TTBUS2_EstadoEnvio, H000D5_A24TTBUS2_RespDesde, H000D5_A25TTBUS2_RespHacia
               }
               , new Object[] {
               H000D6_A6USU_COD, H000D6_A7USU_DES
               }
               , new Object[] {
               H000D7_A6USU_COD, H000D7_A7USU_DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavSec_cre_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_8_idx=1 ;
      private short A23TTBUS_Estado ;
      private short A33TTBUS7_Pos ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short A29TTBUS_Alquilado ;
      private short A37TTBUS_CodPosicion ;
      private short nDonePA ;
      private short AV11inicio ;
      private short AV20TTBUS_Estado ;
      private short A26TTBUS2_EstadoEnvio ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int AV33pTTBUS_Id ;
      private int wcpOAV33pTTBUS_Id ;
      private int edtavSec_dre_Enabled ;
      private int edtavSec_cre_Enabled ;
      private int A14IdIdentificador ;
      private int A11TTBUS_Id ;
      private int A27TTBUS_CodProveedor ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
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
      private String AV17SISTEMA ;
      private String AV26USUARIO ;
      private String wcpOAV17SISTEMA ;
      private String wcpOAV26USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_8_idx="0001" ;
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
      private String edtIdIdentificador_Internalname ;
      private String edtNumeroIdentificador_Internalname ;
      private String edtTTBUS_Id_Internalname ;
      private String edtTTBUS_Descripcion_Internalname ;
      private String edtTTBUS_FechaCarga_Internalname ;
      private String edtTTBUS_FechaBaja_Internalname ;
      private String edtTTBUS_CodProveedor_Internalname ;
      private String edtTTBUS_DesProveedor_Internalname ;
      private String cmbTTBUS_Estado_Internalname ;
      private String edtTTBUS_CodPosicion_Internalname ;
      private String edtTTBUS_DesPosicion_Internalname ;
      private String A30TTBUS_DesProveedor ;
      private String A38TTBUS_DesPosicion ;
      private String AV14SEC_CRE ;
      private String AV15SEC_DRE ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String subGrid1_Internalname ;
      private String AV22TTBUS2_RespDesde ;
      private String AV23TTBUS2_RespHacia ;
      private String AV8dUSU_DES ;
      private String AV10hUSU_DES ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
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
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String edtavVisualizacion_Jsonclick ;
      private String ROClassString ;
      private String edtIdIdentificador_Jsonclick ;
      private String edtNumeroIdentificador_Jsonclick ;
      private String edtTTBUS_Id_Jsonclick ;
      private String edtTTBUS_Descripcion_Jsonclick ;
      private String edtTTBUS_FechaCarga_Jsonclick ;
      private String edtTTBUS_FechaBaja_Jsonclick ;
      private String edtTTBUS_CodProveedor_Jsonclick ;
      private String edtTTBUS_DesProveedor_Jsonclick ;
      private String cmbTTBUS_Estado_Jsonclick ;
      private String edtTTBUS_CodPosicion_Jsonclick ;
      private String edtTTBUS_DesPosicion_Jsonclick ;
      private String edtavSec_cre_Jsonclick ;
      private String GXt_char15 ;
      private String edtavSec_dre_Jsonclick ;
      private String GXt_char16 ;
      private DateTime A13TTBUS_FechaCarga ;
      private DateTime A16TTBUS_FechaBaja ;
      private bool entryPointCalled ;
      private bool n36TTBUS7_DesResp ;
      private bool n35TTBUS7_CodResp ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n16TTBUS_FechaBaja ;
      private bool n27TTBUS_CodProveedor ;
      private bool n30TTBUS_DesProveedor ;
      private bool returnInSub ;
      private String A12TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String l12TTBUS_Descripcion ;
      private String AV27visualizacion ;
      private GxWebSession AV16SESION ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private int aP0_pTTBUS_Id ;
      private String aP1_SISTEMA ;
      private String aP2_USUARIO ;
      private GXCheckbox chkTTBUS_Alquilado ;
      private GXCombobox cmbTTBUS_Estado ;
      private IDataStoreProvider pr_default ;
      private String[] H000D2_A12TTBUS_Descripcion ;
      private int[] H000D3_A11TTBUS_Id ;
      private short[] H000D3_A37TTBUS_CodPosicion ;
      private String[] H000D3_A35TTBUS7_CodResp ;
      private bool[] H000D3_n35TTBUS7_CodResp ;
      private String[] H000D3_A36TTBUS7_DesResp ;
      private bool[] H000D3_n36TTBUS7_DesResp ;
      private String[] H000D3_A38TTBUS_DesPosicion ;
      private short[] H000D3_A23TTBUS_Estado ;
      private String[] H000D3_A30TTBUS_DesProveedor ;
      private bool[] H000D3_n30TTBUS_DesProveedor ;
      private int[] H000D3_A27TTBUS_CodProveedor ;
      private bool[] H000D3_n27TTBUS_CodProveedor ;
      private short[] H000D3_A29TTBUS_Alquilado ;
      private DateTime[] H000D3_A16TTBUS_FechaBaja ;
      private bool[] H000D3_n16TTBUS_FechaBaja ;
      private DateTime[] H000D3_A13TTBUS_FechaCarga ;
      private String[] H000D3_A12TTBUS_Descripcion ;
      private String[] H000D3_A15NumeroIdentificador ;
      private int[] H000D3_A14IdIdentificador ;
      private short[] H000D4_A33TTBUS7_Pos ;
      private long[] H000D5_A52TTBUS2_IdMovimiento ;
      private int[] H000D5_A22TTBUS2_IdBien ;
      private short[] H000D5_A26TTBUS2_EstadoEnvio ;
      private String[] H000D5_A24TTBUS2_RespDesde ;
      private String[] H000D5_A25TTBUS2_RespHacia ;
      private String[] H000D6_A6USU_COD ;
      private String[] H000D6_A7USU_DES ;
      private String[] H000D7_A6USU_COD ;
      private String[] H000D7_A7USU_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtContext AV7Context ;
   }

   public class htbus031__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000D2 ;
          prmH000D2 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH000D3 ;
          prmH000D3 = new Object[] {
          new Object[] {"@AV33pTTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH000D4 ;
          prmH000D4 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH000D5 ;
          prmH000D5 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH000D6 ;
          prmH000D6 = new Object[] {
          new Object[] {"@AV22TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmH000D7 ;
          prmH000D7 = new Object[] {
          new Object[] {"@AV23TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000D2", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000D2,0,0,true,false )
             ,new CursorDef("H000D3", "SELECT T1.[TTBUS_Id], T2.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T3.[TTBUS7_CodResp] AS TTBUS7_CodResp, T4.[USU_DES] AS TTBUS7_DesResp, T2.[TTBUS_DesPosicion], T2.[TTBUS_Estado], T5.[PV_DESC] AS TTBUS_DesProveedor, T2.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T2.[TTBUS_Alquilado], T2.[TTBUS_FechaBaja], T2.[TTBUS_FechaCarga], T2.[TTBUS_Descripcion], T1.[NumeroIdentificador], T1.[IdIdentificador] FROM (((([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) INNER JOIN [TTBUS007] T3 WITH (NOLOCK) ON T3.[TTBUS7_Pos] = T2.[TTBUS_CodPosicion]) LEFT JOIN [SEG002] T4 WITH (NOLOCK) ON T4.[USU_COD] = T3.[TTBUS7_CodResp]) LEFT JOIN [M124FPROV] T5 WITH (NOLOCK) ON T5.[PV_NPRO] = T2.[TTBUS_CodProveedor]) WHERE T1.[TTBUS_Id] = @AV33pTTBUS_Id and T1.[IdIdentificador] = 1 ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000D3,1,0,true,true )
             ,new CursorDef("H000D4", "SELECT [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000D4,1,0,false,true )
             ,new CursorDef("H000D5", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_RespDesde], [TTBUS2_RespHacia] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000D5,100,0,true,false )
             ,new CursorDef("H000D6", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV22TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000D6,1,0,false,true )
             ,new CursorDef("H000D7", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV23TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000D7,1,0,false,true )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 50) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((String[]) buf[8])[0] = rslt.getString(7, 30) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((int[]) buf[10])[0] = rslt.getInt(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((short[]) buf[12])[0] = rslt.getShort(9) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(11) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(13) ;
                ((int[]) buf[18])[0] = rslt.getInt(14) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
