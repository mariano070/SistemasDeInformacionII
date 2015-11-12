/*
               File: HTBUS003_b
        Description: Bajas de Bienes de Uso Pendientes de Confirmar/Rechazar
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:33.31
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
   public class htbus003_b : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public htbus003_b( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus003_b( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUARIO ,
                           ref String aP1_SISTEMA )
      {
         this.AV19USUARIO = aP0_USUARIO;
         this.AV15SISTEMA = aP1_SISTEMA;
         executePrivate();
         aP0_USUARIO=this.AV19USUARIO;
         aP1_SISTEMA=this.AV15SISTEMA;
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
         chkavSeleccion = new GXCheckbox();
         chkTTBUS_Alquilado = new GXCheckbox();
         cmbTTBUS_Estado = new GXCombobox();
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
                  AV19USUARIO = GetNextPar( ) ;
                  AV15SISTEMA = GetNextPar( ) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV19USUARIO,(String)AV15SISTEMA});
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
                  GXSGATTBUS_DESCRIPCION1G0( A12TTBUS_Descripcion) ;
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
                  nGXsfl_10_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  sGXsfl_10_idx = GetNextPar( ) ;
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxnrGrid1_newrow( nRC_Grid1, nGXsfl_10_idx, sGXsfl_10_idx, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
               {
                  /* GeneXus formulas. */
                  context.Gx_err = 0 ;
                  edtavGnumeroidentificador_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
                  edtavTtbus7_codresp_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTtbus7_codresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_codresp_Enabled), 5, 0)));
                  edtavTtbus7_desresp_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTtbus7_desresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_desresp_Enabled), 5, 0)));
                  edtavVer_movimientos_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVer_movimientos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVer_movimientos_Enabled), 5, 0)));
                  edtavListar_movimirneotos_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavListar_movimirneotos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavListar_movimirneotos_Enabled), 5, 0)));
                  GXCCtl = "vSELECCION_" + sGXsfl_10_idx ;
                  chkavSeleccion.Name = GXCCtl ;
                  chkavSeleccion.WebTags = "" ;
                  chkavSeleccion.Caption = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavSeleccion_Internalname, "Caption", chkavSeleccion.Caption);
                  chkavSeleccion.CheckedValue = "0" ;
                  GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_10_idx ;
                  chkTTBUS_Alquilado.Name = GXCCtl ;
                  chkTTBUS_Alquilado.WebTags = "" ;
                  chkTTBUS_Alquilado.Caption = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
                  chkTTBUS_Alquilado.CheckedValue = "0" ;
                  GXCCtl = "TTBUS_ESTADO_" + sGXsfl_10_idx ;
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
                  A36TTBUS7_DesResp = GetNextPar( ) ;
                  n36TTBUS7_DesResp = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
                  A35TTBUS7_CodResp = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                  A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  AV19USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19USUARIO", AV19USUARIO);
                  AV15SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15SISTEMA", AV15SISTEMA);
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxgrGrid1_refresh( A36TTBUS7_DesResp, A35TTBUS7_CodResp, A33TTBUS7_Pos, AV19USUARIO, AV15SISTEMA, sPrefix) ;
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
            PA1G2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavGnumeroidentificador_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
               edtavTtbus7_codresp_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTtbus7_codresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_codresp_Enabled), 5, 0)));
               edtavTtbus7_desresp_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTtbus7_desresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_desresp_Enabled), 5, 0)));
               edtavVer_movimientos_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVer_movimientos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVer_movimientos_Enabled), 5, 0)));
               edtavListar_movimirneotos_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavListar_movimirneotos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavListar_movimirneotos_Enabled), 5, 0)));
               WS1G2( ) ;
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
            context.WriteHtmlText( "Bajas de Bienes de Uso Pendientes de Confirmar/Rechazar") ;
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus003_b.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV19USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV15SISTEMA))+"\" class=\""+"Form"+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            }
         }
      }

      protected void RenderHtmlCloseForm1G2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV19USUARIO", StringUtil.RTrim( wcpOAV19USUARIO));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV15SISTEMA", StringUtil.RTrim( wcpOAV15SISTEMA));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS7_DESRESP", StringUtil.RTrim( A36TTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS7_CODRESP", StringUtil.RTrim( A35TTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vUSUARIO", StringUtil.RTrim( AV19USUARIO));
         GxWebStd.gx_hidden_field( context, sPrefix+"vSISTEMA", StringUtil.RTrim( AV15SISTEMA));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("htbus003_b.js", "?19293338");
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

      protected void WB1G0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "htbus003_b.aspx");
            }
            wb_table1_2_1G2( true) ;
         }
         else
         {
            wb_table1_2_1G2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1G2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1G2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "Bajas de Bienes de Uso Pendientes de Confirmar/Rechazar", 0) ;
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
               STRUP1G0( ) ;
            }
         }
      }

      protected void WS1G2( )
      {
         START1G2( ) ;
         EVT1G2( ) ;
      }

      protected void EVT1G2( )
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
                                 STRUP1G0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "'SELECCIONAR TODOS'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1G0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E111G2 */
                                    E111G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CONFIRMAR BAJA'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1G0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E121G2 */
                                    E121G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CANCELAR BAJA'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1G0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E131G2 */
                                    E131G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1G0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = chkavSeleccion_Internalname ;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 19), "'SELECCIONAR TODOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "'CONFIRMAR BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'CANCELAR BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1G0( ) ;
                              }
                              nGXsfl_10_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_10_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)), 4, "0") ;
                              chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_idx ;
                              edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_idx ;
                              edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_idx ;
                              edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_idx ;
                              edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_idx ;
                              chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_idx ;
                              edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_idx ;
                              edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_idx ;
                              edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_idx ;
                              edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_idx ;
                              edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_idx ;
                              cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_idx ;
                              edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_idx ;
                              edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_idx ;
                              edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_idx ;
                              edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_idx ;
                              if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
                                 GX_FocusControl = chkavSeleccion_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV14seleccion = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14seleccion", StringUtil.Str( (decimal)(AV14seleccion), 1, 0));
                              }
                              else
                              {
                                 AV14seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14seleccion", StringUtil.Str( (decimal)(AV14seleccion), 1, 0));
                              }
                              AV6deltalles = cgiGet( "GXimg"+edtavDeltalles_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDeltalles_Internalname, "Bitmap", context.convertURL( AV6deltalles));
                              AV22gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22gNumeroIdentificador", AV22gNumeroIdentificador);
                              A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                              A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                              A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
                              A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
                              A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
                              AV18TTBUS7_CodResp = StringUtil.Upper( cgiGet( edtavTtbus7_codresp_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TTBUS7_CodResp", AV18TTBUS7_CodResp);
                              AV5TTBUS7_DesResp = StringUtil.Upper( cgiGet( edtavTtbus7_desresp_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5TTBUS7_DesResp", AV5TTBUS7_DesResp);
                              A195TTBUS_UsuarioBaja = cgiGet( edtTTBUS_UsuarioBaja_Internalname) ;
                              n195TTBUS_UsuarioBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
                              cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
                              cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
                              A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
                              A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
                              n16TTBUS_FechaBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
                              A43TTBUS_MotivoBaja = StringUtil.Upper( cgiGet( edtTTBUS_MotivoBaja_Internalname)) ;
                              n43TTBUS_MotivoBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
                              AV20ver_movimientos = cgiGet( edtavVer_movimientos_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ver_movimientos", AV20ver_movimientos);
                              AV21listar_movimirneotos = cgiGet( edtavListar_movimirneotos_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21listar_movimirneotos", AV21listar_movimirneotos);
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
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E141G2 */
                                          E141G2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E151G2 */
                                          E151G2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'SELECCIONAR TODOS'") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E111G2 */
                                          E111G2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'CONFIRMAR BAJA'") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E121G2 */
                                          E121G2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'CANCELAR BAJA'") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E131G2 */
                                          E131G2 ();
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
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP1G0( ) ;
                                    }
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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

      protected void WE1G2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1G2( ) ;
            }
         }
      }

      protected void PA1G2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            GXCCtl = "vSELECCION_" + sGXsfl_10_idx ;
            chkavSeleccion.Name = GXCCtl ;
            chkavSeleccion.WebTags = "" ;
            chkavSeleccion.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavSeleccion_Internalname, "Caption", chkavSeleccion.Caption);
            chkavSeleccion.CheckedValue = "0" ;
            GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_10_idx ;
            chkTTBUS_Alquilado.Name = GXCCtl ;
            chkTTBUS_Alquilado.WebTags = "" ;
            chkTTBUS_Alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
            chkTTBUS_Alquilado.CheckedValue = "0" ;
            GXCCtl = "TTBUS_ESTADO_" + sGXsfl_10_idx ;
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
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGATTBUS_DESCRIPCION1G0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS_DESCRIPCION_data1G0( A12TTBUS_Descripcion) ;
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

      protected void GXSGATTBUS_DESCRIPCION_data1G0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H001G2 */
         pr_default.execute(0, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001G2_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001G2_A12TTBUS_Descripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_10_idx ,
                                       String sGXsfl_10_idx ,
                                       String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_idx ;
         edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_idx ;
         edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_idx ;
         edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_idx ;
         edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_idx ;
         chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_idx ;
         edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_idx ;
         edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_idx ;
         edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_idx ;
         edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_idx ;
         edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_idx ;
         cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_idx ;
         edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_idx ;
         edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_idx ;
         edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_idx ;
         edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_idx ;
         while ( nGXsfl_10_idx <= nRC_Grid1 )
         {
            sendrow_102( ) ;
            nGXsfl_10_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_10_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_10_idx+1)) ;
            sGXsfl_10_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_idx ;
            edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_idx ;
            edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_idx ;
            edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_idx ;
            edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_idx ;
            edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_idx ;
            edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_idx ;
            edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_idx ;
            edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String A36TTBUS7_DesResp ,
                                        String A35TTBUS7_CodResp ,
                                        short A33TTBUS7_Pos ,
                                        String AV19USUARIO ,
                                        String AV15SISTEMA ,
                                        String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF1G2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1G2( ) ;
         /* End function Refresh */
      }

      protected void RF1G2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 10 ;
         nGXsfl_10_idx = 1 ;
         sGXsfl_10_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)), 4, "0") ;
         chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_idx ;
         edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_idx ;
         edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_idx ;
         edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_idx ;
         edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_idx ;
         chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_idx ;
         edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_idx ;
         edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_idx ;
         edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_idx ;
         edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_idx ;
         edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_idx ;
         cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_idx ;
         edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_idx ;
         edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_idx ;
         edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_idx ;
         edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_idx ;
            edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_idx ;
            edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_idx ;
            edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_idx ;
            edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_idx ;
            edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_idx ;
            edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_idx ;
            edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_idx ;
            edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_idx ;
            /* Using cursor H001G3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               A43TTBUS_MotivoBaja = H001G3_A43TTBUS_MotivoBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
               n43TTBUS_MotivoBaja = H001G3_n43TTBUS_MotivoBaja[0] ;
               A16TTBUS_FechaBaja = H001G3_A16TTBUS_FechaBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               n16TTBUS_FechaBaja = H001G3_n16TTBUS_FechaBaja[0] ;
               A23TTBUS_Estado = H001G3_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A195TTBUS_UsuarioBaja = H001G3_A195TTBUS_UsuarioBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
               n195TTBUS_UsuarioBaja = H001G3_n195TTBUS_UsuarioBaja[0] ;
               A38TTBUS_DesPosicion = H001G3_A38TTBUS_DesPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               A37TTBUS_CodPosicion = H001G3_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A29TTBUS_Alquilado = H001G3_A29TTBUS_Alquilado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A12TTBUS_Descripcion = H001G3_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A11TTBUS_Id = H001G3_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               /* Execute user event: E151G2 */
               E151G2 ();
               pr_default.readNext(1);
            }
            pr_default.close(1);
            wbEnd = 10 ;
            WB1G0( ) ;
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

      protected void STRUP1G0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavGnumeroidentificador_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
         edtavTtbus7_codresp_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTtbus7_codresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_codresp_Enabled), 5, 0)));
         edtavTtbus7_desresp_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTtbus7_desresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_desresp_Enabled), 5, 0)));
         edtavVer_movimientos_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVer_movimientos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVer_movimientos_Enabled), 5, 0)));
         edtavListar_movimirneotos_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavListar_movimirneotos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavListar_movimirneotos_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E141G2 */
         E141G2 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid1"), ",", ".")) ;
            wcpOAV19USUARIO = cgiGet( sPrefix+"wcpOAV19USUARIO") ;
            wcpOAV15SISTEMA = cgiGet( sPrefix+"wcpOAV15SISTEMA") ;
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
         /* Execute user event: E141G2 */
         E141G2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E141G2( )
      {
         /* Start Routine */
      }

      private void E151G2( )
      {
         /* Grid1_Load Routine */
         AV6deltalles = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDeltalles_Internalname, "Bitmap", context.convertURL( AV6deltalles));
         edtavDeltalles_Link = formatLink("ttbus000.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A37TTBUS_CodPosicion) + "," + UrlEncode(StringUtil.RTrim(AV18TTBUS7_CodResp)) + "," + UrlEncode("" +A23TTBUS_Estado) + "," + UrlEncode("" +3) + "," + UrlEncode(StringUtil.RTrim(AV15SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV19USUARIO)) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDeltalles_Internalname, "Link", edtavDeltalles_Link);
         edtavDeltalles_Linktarget = "_blank" ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDeltalles_Internalname, "Linktarget", edtavDeltalles_Linktarget);
         new ptbus009(context ).execute(  A11TTBUS_Id,  1, out  AV22gNumeroIdentificador) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22gNumeroIdentificador", AV22gNumeroIdentificador);
         AV20ver_movimientos = "Ver Movimientos" ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ver_movimientos", AV20ver_movimientos);
         edtavVer_movimientos_Link = formatLink("htbus002.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(A12TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim(AV15SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV19USUARIO)) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVer_movimientos_Internalname, "Link", edtavVer_movimientos_Link);
         edtavVer_movimientos_Linktarget = "_blank" ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVer_movimientos_Internalname, "Linktarget", edtavVer_movimientos_Linktarget);
         AV21listar_movimirneotos = "Listar Movimientos" ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21listar_movimirneotos", AV21listar_movimirneotos);
         edtavListar_movimirneotos_Link = formatLink("htbus012.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(AV15SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV19USUARIO)) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavListar_movimirneotos_Internalname, "Link", edtavListar_movimirneotos_Link);
         edtavListar_movimirneotos_Linktarget = "_blank" ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavListar_movimirneotos_Internalname, "Linktarget", edtavListar_movimirneotos_Linktarget);
         AV23TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 10 ;
         }
         sendrow_102( ) ;
      }

      protected void E111G2( )
      {
         /* 'Seleccionar Todos' Routine */
         /* Start For Each Line */
         nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid1"), ",", ".")) ;
         nGXsfl_10_fel_idx = 0 ;
         while ( nGXsfl_10_fel_idx < nRC_Grid1 )
         {
            nGXsfl_10_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_10_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_10_fel_idx+1)) ;
            sGXsfl_10_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_fel_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_fel_idx ;
            edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_fel_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_fel_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_fel_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_fel_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_fel_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_fel_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_fel_idx ;
            edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_fel_idx ;
            edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_fel_idx ;
            edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_fel_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_fel_idx ;
            edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_fel_idx ;
            edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_fel_idx ;
            edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_fel_idx ;
            edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_fel_idx ;
            if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
               GX_FocusControl = chkavSeleccion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14seleccion = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14seleccion", StringUtil.Str( (decimal)(AV14seleccion), 1, 0));
            }
            else
            {
               AV14seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14seleccion", StringUtil.Str( (decimal)(AV14seleccion), 1, 0));
            }
            AV6deltalles = cgiGet( "GXimg"+edtavDeltalles_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDeltalles_Internalname, "Bitmap", context.convertURL( AV6deltalles));
            AV22gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22gNumeroIdentificador", AV22gNumeroIdentificador);
            A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
            A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
            AV18TTBUS7_CodResp = StringUtil.Upper( cgiGet( edtavTtbus7_codresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TTBUS7_CodResp", AV18TTBUS7_CodResp);
            AV5TTBUS7_DesResp = StringUtil.Upper( cgiGet( edtavTtbus7_desresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5TTBUS7_DesResp", AV5TTBUS7_DesResp);
            A195TTBUS_UsuarioBaja = cgiGet( edtTTBUS_UsuarioBaja_Internalname) ;
            n195TTBUS_UsuarioBaja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
            cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
            cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
            A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
            n16TTBUS_FechaBaja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
            A43TTBUS_MotivoBaja = StringUtil.Upper( cgiGet( edtTTBUS_MotivoBaja_Internalname)) ;
            n43TTBUS_MotivoBaja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
            AV20ver_movimientos = cgiGet( edtavVer_movimientos_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ver_movimientos", AV20ver_movimientos);
            AV21listar_movimirneotos = cgiGet( edtavListar_movimirneotos_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21listar_movimirneotos", AV21listar_movimirneotos);
            AV14seleccion = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14seleccion", StringUtil.Str( (decimal)(AV14seleccion), 1, 0));
            /* End For Each Line */
         }
         if ( nGXsfl_10_fel_idx == 0 )
         {
            nGXsfl_10_idx = 1 ;
            sGXsfl_10_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_idx ;
            edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_idx ;
            edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_idx ;
            edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_idx ;
            edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_idx ;
            edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_idx ;
            edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_idx ;
            edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_idx ;
            edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_idx ;
         }
         nGXsfl_10_fel_idx = 1 ;
      }

      protected void E121G2( )
      {
         /* 'Confirmar Baja' Routine */
         /* Start For Each Line */
         nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid1"), ",", ".")) ;
         nGXsfl_10_fel_idx = 0 ;
         while ( nGXsfl_10_fel_idx < nRC_Grid1 )
         {
            nGXsfl_10_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_10_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_10_fel_idx+1)) ;
            sGXsfl_10_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_fel_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_fel_idx ;
            edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_fel_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_fel_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_fel_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_fel_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_fel_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_fel_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_fel_idx ;
            edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_fel_idx ;
            edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_fel_idx ;
            edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_fel_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_fel_idx ;
            edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_fel_idx ;
            edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_fel_idx ;
            edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_fel_idx ;
            edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_fel_idx ;
            if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
               GX_FocusControl = chkavSeleccion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14seleccion = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14seleccion", StringUtil.Str( (decimal)(AV14seleccion), 1, 0));
            }
            else
            {
               AV14seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14seleccion", StringUtil.Str( (decimal)(AV14seleccion), 1, 0));
            }
            AV6deltalles = cgiGet( "GXimg"+edtavDeltalles_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDeltalles_Internalname, "Bitmap", context.convertURL( AV6deltalles));
            AV22gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22gNumeroIdentificador", AV22gNumeroIdentificador);
            A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
            A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
            AV18TTBUS7_CodResp = StringUtil.Upper( cgiGet( edtavTtbus7_codresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TTBUS7_CodResp", AV18TTBUS7_CodResp);
            AV5TTBUS7_DesResp = StringUtil.Upper( cgiGet( edtavTtbus7_desresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5TTBUS7_DesResp", AV5TTBUS7_DesResp);
            A195TTBUS_UsuarioBaja = cgiGet( edtTTBUS_UsuarioBaja_Internalname) ;
            n195TTBUS_UsuarioBaja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
            cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
            cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
            A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
            n16TTBUS_FechaBaja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
            A43TTBUS_MotivoBaja = StringUtil.Upper( cgiGet( edtTTBUS_MotivoBaja_Internalname)) ;
            n43TTBUS_MotivoBaja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
            AV20ver_movimientos = cgiGet( edtavVer_movimientos_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ver_movimientos", AV20ver_movimientos);
            AV21listar_movimirneotos = cgiGet( edtavListar_movimirneotos_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21listar_movimirneotos", AV21listar_movimirneotos);
            if ( AV14seleccion == 1 )
            {
               new ptbus003_b_1(context ).execute( ref  A11TTBUS_Id, ref  AV19USUARIO) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19USUARIO", AV19USUARIO);
            }
            /* End For Each Line */
         }
         if ( nGXsfl_10_fel_idx == 0 )
         {
            nGXsfl_10_idx = 1 ;
            sGXsfl_10_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_idx ;
            edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_idx ;
            edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_idx ;
            edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_idx ;
            edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_idx ;
            edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_idx ;
            edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_idx ;
            edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_idx ;
            edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_idx ;
         }
         nGXsfl_10_fel_idx = 1 ;
         context.DoAjaxRefresh();
      }

      protected void E131G2( )
      {
         /* 'Cancelar Baja' Routine */
         /* Start For Each Line */
         nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid1"), ",", ".")) ;
         nGXsfl_10_fel_idx = 0 ;
         while ( nGXsfl_10_fel_idx < nRC_Grid1 )
         {
            nGXsfl_10_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_10_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_10_fel_idx+1)) ;
            sGXsfl_10_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_fel_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_fel_idx ;
            edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_fel_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_fel_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_fel_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_fel_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_fel_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_fel_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_fel_idx ;
            edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_fel_idx ;
            edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_fel_idx ;
            edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_fel_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_fel_idx ;
            edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_fel_idx ;
            edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_fel_idx ;
            edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_fel_idx ;
            edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_fel_idx ;
            if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
               GX_FocusControl = chkavSeleccion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14seleccion = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14seleccion", StringUtil.Str( (decimal)(AV14seleccion), 1, 0));
            }
            else
            {
               AV14seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14seleccion", StringUtil.Str( (decimal)(AV14seleccion), 1, 0));
            }
            AV6deltalles = cgiGet( "GXimg"+edtavDeltalles_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDeltalles_Internalname, "Bitmap", context.convertURL( AV6deltalles));
            AV22gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22gNumeroIdentificador", AV22gNumeroIdentificador);
            A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
            A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
            AV18TTBUS7_CodResp = StringUtil.Upper( cgiGet( edtavTtbus7_codresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TTBUS7_CodResp", AV18TTBUS7_CodResp);
            AV5TTBUS7_DesResp = StringUtil.Upper( cgiGet( edtavTtbus7_desresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5TTBUS7_DesResp", AV5TTBUS7_DesResp);
            A195TTBUS_UsuarioBaja = cgiGet( edtTTBUS_UsuarioBaja_Internalname) ;
            n195TTBUS_UsuarioBaja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
            cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
            cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
            A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
            n16TTBUS_FechaBaja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
            A43TTBUS_MotivoBaja = StringUtil.Upper( cgiGet( edtTTBUS_MotivoBaja_Internalname)) ;
            n43TTBUS_MotivoBaja = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
            AV20ver_movimientos = cgiGet( edtavVer_movimientos_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ver_movimientos", AV20ver_movimientos);
            AV21listar_movimirneotos = cgiGet( edtavListar_movimirneotos_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21listar_movimirneotos", AV21listar_movimirneotos);
            if ( AV14seleccion == 1 )
            {
               new ptbus003_b_2(context ).execute( ref  A11TTBUS_Id) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            }
            /* End For Each Line */
         }
         if ( nGXsfl_10_fel_idx == 0 )
         {
            nGXsfl_10_idx = 1 ;
            sGXsfl_10_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_idx ;
            edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_idx ;
            edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_idx ;
            edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_idx ;
            chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_idx ;
            edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_idx ;
            edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_idx ;
            edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_idx ;
            edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_idx ;
            edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_idx ;
            cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_idx ;
            edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_idx ;
            edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_idx ;
            edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_idx ;
            edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_idx ;
         }
         nGXsfl_10_fel_idx = 1 ;
         context.DoAjaxRefresh();
      }

      protected void S112( )
      {
         /* 'RESPONSABLE' Routine */
         AV18TTBUS7_CodResp = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TTBUS7_CodResp", AV18TTBUS7_CodResp);
         AV5TTBUS7_DesResp = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5TTBUS7_DesResp", AV5TTBUS7_DesResp);
         /* Using cursor H001G4 */
         pr_default.execute(2, new Object[] {AV23TTBUS_CodPosicion});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A33TTBUS7_Pos = H001G4_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            A35TTBUS7_CodResp = H001G4_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            A36TTBUS7_DesResp = H001G4_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = H001G4_n36TTBUS7_DesResp[0] ;
            A36TTBUS7_DesResp = H001G4_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = H001G4_n36TTBUS7_DesResp[0] ;
            AV18TTBUS7_CodResp = A35TTBUS7_CodResp ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TTBUS7_CodResp", AV18TTBUS7_CodResp);
            AV5TTBUS7_DesResp = A36TTBUS7_DesResp ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5TTBUS7_DesResp", AV5TTBUS7_DesResp);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
      }

      protected void wb_table1_2_1G2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(104), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(918), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "left")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "left")+"\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Etiqueta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(200), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Alquilado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Cod. Posición Actual Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(130), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "TTBUS7_ Cod Resp") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Usuario que da la Baja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(130), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha de Baja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Motivo de Baja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Ver Movimientos") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Listar Movimientos") ;
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
               Grid1Container.AddObjectProperty("CmpContext", sPrefix);
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14seleccion), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV6deltalles));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavDeltalles_Link));
               Grid1Column.AddObjectProperty("Linktarget", StringUtil.RTrim( edtavDeltalles_Linktarget));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV22gNumeroIdentificador));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A12TTBUS_Descripcion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29TTBUS_Alquilado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A38TTBUS_DesPosicion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV18TTBUS7_CodResp));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTtbus7_codresp_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV5TTBUS7_DesResp));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTtbus7_desresp_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A195TTBUS_UsuarioBaja));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23TTBUS_Estado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A43TTBUS_MotivoBaja));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV20ver_movimientos));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavVer_movimientos_Enabled), 5, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavVer_movimientos_Link));
               Grid1Column.AddObjectProperty("Linktarget", StringUtil.RTrim( edtavVer_movimientos_Linktarget));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV21listar_movimirneotos));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavListar_movimirneotos_Enabled), 5, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavListar_movimirneotos_Link));
               Grid1Column.AddObjectProperty("Linktarget", StringUtil.RTrim( edtavListar_movimirneotos_Linktarget));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 10 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_10_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton2_Internalname, "Seleccionar Todos", "Seleccionar Todos", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton2_Jsonclick, sPrefix+"E\\'SELECCIONAR TODOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(10), 3, 0)+","+"null"+");", "", "HLP_HTBUS003_b.htm");
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton3_Internalname, "Confirmar Baja", "Confirmar Baja", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton3_Jsonclick, sPrefix+"E\\'CONFIRMAR BAJA\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(10), 3, 0)+","+"null"+");", "", "HLP_HTBUS003_b.htm");
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Cancelar Baja", "Cancelar Baja", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, sPrefix+"E\\'CANCELAR BAJA\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(10), 3, 0)+","+"null"+");", "", "HLP_HTBUS003_b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1G2e( true) ;
         }
         else
         {
            wb_table1_2_1G2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV19USUARIO = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19USUARIO", AV19USUARIO);
         AV15SISTEMA = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15SISTEMA", AV15SISTEMA);
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
         PA1G2( ) ;
         WS1G2( ) ;
         WE1G2( ) ;
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
         sCtrlAV19USUARIO = (String)((String)getParm(obj,0)) ;
         sCtrlAV15SISTEMA = (String)((String)getParm(obj,1)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA1G2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "htbus003_b");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA1G2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV19USUARIO = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19USUARIO", AV19USUARIO);
            AV15SISTEMA = (String)getParm(obj,3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15SISTEMA", AV15SISTEMA);
         }
         wcpOAV19USUARIO = cgiGet( sPrefix+"wcpOAV19USUARIO") ;
         wcpOAV15SISTEMA = cgiGet( sPrefix+"wcpOAV15SISTEMA") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV19USUARIO, wcpOAV19USUARIO) != 0 ) || ( StringUtil.StrCmp(AV15SISTEMA, wcpOAV15SISTEMA) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV19USUARIO = AV19USUARIO ;
         wcpOAV15SISTEMA = AV15SISTEMA ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV19USUARIO = cgiGet( sPrefix+"AV19USUARIO_CTRL") ;
         if ( StringUtil.Len( sCtrlAV19USUARIO) > 0 )
         {
            AV19USUARIO = cgiGet( sCtrlAV19USUARIO) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19USUARIO", AV19USUARIO);
         }
         else
         {
            AV19USUARIO = cgiGet( sPrefix+"AV19USUARIO_PARM") ;
         }
         sCtrlAV15SISTEMA = cgiGet( sPrefix+"AV15SISTEMA_CTRL") ;
         if ( StringUtil.Len( sCtrlAV15SISTEMA) > 0 )
         {
            AV15SISTEMA = cgiGet( sCtrlAV15SISTEMA) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15SISTEMA", AV15SISTEMA);
         }
         else
         {
            AV15SISTEMA = cgiGet( sPrefix+"AV15SISTEMA_PARM") ;
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
         PA1G2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS1G2( ) ;
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
         WS1G2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV19USUARIO_PARM", StringUtil.RTrim( AV19USUARIO));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV19USUARIO)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV19USUARIO_CTRL", StringUtil.RTrim( sCtrlAV19USUARIO));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV15SISTEMA_PARM", StringUtil.RTrim( AV15SISTEMA));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV15SISTEMA)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV15SISTEMA_CTRL", StringUtil.RTrim( sCtrlAV15SISTEMA));
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
         WE1G2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19293411");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("htbus003_b.js", "?19293411");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_102( )
      {
         WB1G0( ) ;
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
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
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
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( ((int)(nGXsfl_10_idx) % (2)) == 0 )
            {
               subGrid1_Backcolor = (int)(0xE5E5E5) ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even" ;
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
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
         /* Check box */
         TempTags = " " + ((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 11,'"+sPrefix+"',false,'"+sGXsfl_10_idx+"',10)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSeleccion_Internalname,StringUtil.Str( (decimal)(AV14seleccion), 1, 0),(String)"",(short)-1,(short)1,(String)"1",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(11, this, 1, 0);gx.evt.onchange(this);\" " : " ")+((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(11);\"" : " ")});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Static Bitmap Variable */
         ClassString = "Image" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDeltalles_Internalname,(String)"",(String)AV6deltalles,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Ver Detallles",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavDeltalles_Link,(String)edtavDeltalles_Linktarget,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 13,'"+sPrefix+"',false,'"+sGXsfl_10_idx+"',10)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGnumeroidentificador_Internalname,StringUtil.RTrim( AV22gNumeroIdentificador),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)80,(short)-1,(int)edtavGnumeroidentificador_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV22gNumeroIdentificador, "")),TempTags+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(13);\"" : " "),(short)0,(String)edtavGnumeroidentificador_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_Id_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Descripcion_Internalname,StringUtil.RTrim( A12TTBUS_Descripcion),(String)"",(short)200,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")),(String)"",(short)0,(String)edtTTBUS_Descripcion_Jsonclick,(String)"",(short)10,(short)1,(short)0,(bool)true,(String)"left"});
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
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodPosicion_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A37TTBUS_CodPosicion), "ZZ9"),(String)"",(short)0,(String)edtTTBUS_CodPosicion_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesPosicion_Internalname,StringUtil.RTrim( A38TTBUS_DesPosicion),(String)"",(short)130,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesPosicion_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavTtbus7_codresp_Enabled!=0)&&(edtavTtbus7_codresp_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 19,'"+sPrefix+"',false,'"+sGXsfl_10_idx+"',10)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTtbus7_codresp_Internalname,StringUtil.RTrim( AV18TTBUS7_CodResp),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)0,(int)edtavTtbus7_codresp_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV18TTBUS7_CodResp, "@!")),TempTags+((edtavTtbus7_codresp_Enabled!=0)&&(edtavTtbus7_codresp_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavTtbus7_codresp_Enabled!=0)&&(edtavTtbus7_codresp_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(19);\"" : " "),(short)0,(String)edtavTtbus7_codresp_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavTtbus7_desresp_Enabled!=0)&&(edtavTtbus7_desresp_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 20,'"+sPrefix+"',false,'"+sGXsfl_10_idx+"',10)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTtbus7_desresp_Internalname,StringUtil.RTrim( AV5TTBUS7_DesResp),(String)"",(short)150,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavTtbus7_desresp_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV5TTBUS7_DesResp, "@!")),TempTags+((edtavTtbus7_desresp_Enabled!=0)&&(edtavTtbus7_desresp_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavTtbus7_desresp_Enabled!=0)&&(edtavTtbus7_desresp_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(20);\"" : " "),(short)0,(String)edtavTtbus7_desresp_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_UsuarioBaja_Internalname,StringUtil.RTrim( A195TTBUS_UsuarioBaja),(String)"",(short)150,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A195TTBUS_UsuarioBaja, "XXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_UsuarioBaja_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         ClassString = "Attribute" ;
         StyleString = "" ;
         if ( ( nGXsfl_10_idx == 1 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "TTBUS_ESTADO_" + sGXsfl_10_idx ;
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
         Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTTBUS_Estado,(String)cmbTTBUS_Estado_Internalname,StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)130,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbTTBUS_Estado_Jsonclick,(String)"",(String)"",(bool)true});
         cmbTTBUS_Estado.CurrentValue = StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbTTBUS_Estado_Internalname, "Values", (String)(cmbTTBUS_Estado.ToJavascriptSource()));
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaBaja_Internalname,context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaBaja_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_MotivoBaja_Internalname,StringUtil.RTrim( A43TTBUS_MotivoBaja),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A43TTBUS_MotivoBaja, "@!")),(String)"",(short)0,(String)edtTTBUS_MotivoBaja_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavVer_movimientos_Enabled!=0)&&(edtavVer_movimientos_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 25,'"+sPrefix+"',false,'"+sGXsfl_10_idx+"',10)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavVer_movimientos_Internalname,StringUtil.RTrim( AV20ver_movimientos),"Haga clic aquí para ver los movimientos de este bien de uso.",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(int)edtavVer_movimientos_Enabled,(short)0,(short)0,(short)0,(String)edtavVer_movimientos_Link,(String)edtavVer_movimientos_Linktarget,(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV20ver_movimientos, "XXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavVer_movimientos_Enabled!=0)&&(edtavVer_movimientos_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavVer_movimientos_Enabled!=0)&&(edtavVer_movimientos_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(25);\"" : " "),(short)0,(String)edtavVer_movimientos_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavListar_movimirneotos_Enabled!=0)&&(edtavListar_movimirneotos_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 26,'"+sPrefix+"',false,'"+sGXsfl_10_idx+"',10)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavListar_movimirneotos_Internalname,StringUtil.RTrim( AV21listar_movimirneotos),"Haga clic aquí para listar los movimientos de este bien de uso.",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(int)edtavListar_movimirneotos_Enabled,(short)0,(short)0,(short)0,(String)edtavListar_movimirneotos_Link,(String)edtavListar_movimirneotos_Linktarget,(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV21listar_movimirneotos, "XXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavListar_movimirneotos_Enabled!=0)&&(edtavListar_movimirneotos_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavListar_movimirneotos_Enabled!=0)&&(edtavListar_movimirneotos_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(26);\"" : " "),(short)0,(String)edtavListar_movimirneotos_Jsonclick,(String)"",(short)10,(short)1,(short)1,(bool)true,(String)"left"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_10_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_10_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_10_idx+1)) ;
         sGXsfl_10_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)), 4, "0") ;
         chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_10_idx ;
         edtavDeltalles_Internalname = sPrefix+"vDELTALLES_"+sGXsfl_10_idx ;
         edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_10_idx ;
         edtTTBUS_Id_Internalname = sPrefix+"TTBUS_ID_"+sGXsfl_10_idx ;
         edtTTBUS_Descripcion_Internalname = sPrefix+"TTBUS_DESCRIPCION_"+sGXsfl_10_idx ;
         chkTTBUS_Alquilado_Internalname = sPrefix+"TTBUS_ALQUILADO_"+sGXsfl_10_idx ;
         edtTTBUS_CodPosicion_Internalname = sPrefix+"TTBUS_CODPOSICION_"+sGXsfl_10_idx ;
         edtTTBUS_DesPosicion_Internalname = sPrefix+"TTBUS_DESPOSICION_"+sGXsfl_10_idx ;
         edtavTtbus7_codresp_Internalname = sPrefix+"vTTBUS7_CODRESP_"+sGXsfl_10_idx ;
         edtavTtbus7_desresp_Internalname = sPrefix+"vTTBUS7_DESRESP_"+sGXsfl_10_idx ;
         edtTTBUS_UsuarioBaja_Internalname = sPrefix+"TTBUS_USUARIOBAJA_"+sGXsfl_10_idx ;
         cmbTTBUS_Estado_Internalname = sPrefix+"TTBUS_ESTADO_"+sGXsfl_10_idx ;
         edtTTBUS_FechaBaja_Internalname = sPrefix+"TTBUS_FECHABAJA_"+sGXsfl_10_idx ;
         edtTTBUS_MotivoBaja_Internalname = sPrefix+"TTBUS_MOTIVOBAJA_"+sGXsfl_10_idx ;
         edtavVer_movimientos_Internalname = sPrefix+"vVER_MOVIMIENTOS_"+sGXsfl_10_idx ;
         edtavListar_movimirneotos_Internalname = sPrefix+"vLISTAR_MOVIMIRNEOTOS_"+sGXsfl_10_idx ;
         /* End function sendrow_102 */
      }

      protected void init_default_properties( )
      {
         bttButton2_Internalname = sPrefix+"BUTTON2" ;
         bttButton3_Internalname = sPrefix+"BUTTON3" ;
         bttButton1_Internalname = sPrefix+"BUTTON1" ;
         tblTable1_Internalname = sPrefix+"TABLE1" ;
         Form.Internalname = sPrefix+"FORM" ;
         subGrid1_Internalname = sPrefix+"GRID1" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavListar_movimirneotos_Jsonclick = "" ;
         edtavListar_movimirneotos_Visible = -1 ;
         edtavVer_movimientos_Jsonclick = "" ;
         edtavVer_movimientos_Visible = -1 ;
         edtTTBUS_MotivoBaja_Jsonclick = "" ;
         edtTTBUS_FechaBaja_Jsonclick = "" ;
         cmbTTBUS_Estado_Jsonclick = "" ;
         edtTTBUS_UsuarioBaja_Jsonclick = "" ;
         edtavTtbus7_desresp_Jsonclick = "" ;
         edtavTtbus7_desresp_Visible = -1 ;
         edtavTtbus7_codresp_Jsonclick = "" ;
         edtavTtbus7_codresp_Visible = 0 ;
         edtTTBUS_DesPosicion_Jsonclick = "" ;
         edtTTBUS_CodPosicion_Jsonclick = "" ;
         edtTTBUS_Descripcion_Jsonclick = "" ;
         edtTTBUS_Id_Jsonclick = "" ;
         edtavGnumeroidentificador_Jsonclick = "" ;
         edtavGnumeroidentificador_Visible = -1 ;
         chkavSeleccion.Visible = -1 ;
         chkavSeleccion.Enabled = 1 ;
         edtavListar_movimirneotos_Enabled = 1 ;
         edtavVer_movimientos_Enabled = 1 ;
         edtavTtbus7_desresp_Enabled = 1 ;
         edtavTtbus7_codresp_Enabled = 1 ;
         edtavGnumeroidentificador_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         edtavListar_movimirneotos_Linktarget = "" ;
         edtavListar_movimirneotos_Link = "" ;
         edtavVer_movimientos_Linktarget = "" ;
         edtavVer_movimientos_Link = "" ;
         edtavDeltalles_Linktarget = "" ;
         edtavDeltalles_Link = "" ;
         chkTTBUS_Alquilado.Caption = "" ;
         chkavSeleccion.Caption = "" ;
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
         wcpOAV19USUARIO = "" ;
         wcpOAV15SISTEMA = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         A12TTBUS_Descripcion = "" ;
         edtavGnumeroidentificador_Internalname = "" ;
         edtavTtbus7_codresp_Internalname = "" ;
         edtavTtbus7_desresp_Internalname = "" ;
         edtavVer_movimientos_Internalname = "" ;
         edtavListar_movimirneotos_Internalname = "" ;
         GXCCtl = "" ;
         chkavSeleccion_Internalname = "" ;
         chkTTBUS_Alquilado_Internalname = "" ;
         A36TTBUS7_DesResp = "" ;
         A35TTBUS7_CodResp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavDeltalles_Internalname = "" ;
         edtTTBUS_Id_Internalname = "" ;
         edtTTBUS_Descripcion_Internalname = "" ;
         edtTTBUS_CodPosicion_Internalname = "" ;
         edtTTBUS_DesPosicion_Internalname = "" ;
         edtTTBUS_UsuarioBaja_Internalname = "" ;
         cmbTTBUS_Estado_Internalname = "" ;
         edtTTBUS_FechaBaja_Internalname = "" ;
         edtTTBUS_MotivoBaja_Internalname = "" ;
         AV6deltalles = "" ;
         AV22gNumeroIdentificador = "" ;
         A38TTBUS_DesPosicion = "" ;
         AV18TTBUS7_CodResp = "" ;
         AV5TTBUS7_DesResp = "" ;
         A195TTBUS_UsuarioBaja = "" ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         A43TTBUS_MotivoBaja = "" ;
         AV20ver_movimientos = "" ;
         AV21listar_movimirneotos = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l12TTBUS_Descripcion = "" ;
         H001G2_A12TTBUS_Descripcion = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         H001G3_A43TTBUS_MotivoBaja = new String[] {""} ;
         H001G3_n43TTBUS_MotivoBaja = new bool[] {false} ;
         H001G3_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         H001G3_n16TTBUS_FechaBaja = new bool[] {false} ;
         H001G3_A23TTBUS_Estado = new short[1] ;
         H001G3_A195TTBUS_UsuarioBaja = new String[] {""} ;
         H001G3_n195TTBUS_UsuarioBaja = new bool[] {false} ;
         H001G3_A38TTBUS_DesPosicion = new String[] {""} ;
         H001G3_A37TTBUS_CodPosicion = new short[1] ;
         H001G3_A29TTBUS_Alquilado = new short[1] ;
         H001G3_A12TTBUS_Descripcion = new String[] {""} ;
         H001G3_A11TTBUS_Id = new int[1] ;
         H001G4_A33TTBUS7_Pos = new short[1] ;
         H001G4_A35TTBUS7_CodResp = new String[] {""} ;
         H001G4_A36TTBUS7_DesResp = new String[] {""} ;
         H001G4_n36TTBUS7_DesResp = new bool[] {false} ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char9 = "" ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         GXt_char14 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char15 = "" ;
         TempTags = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV19USUARIO = "" ;
         sCtrlAV15SISTEMA = "" ;
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char16 = "" ;
         GXt_char17 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus003_b__default(),
            new Object[][] {
                new Object[] {
               H001G2_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001G3_A43TTBUS_MotivoBaja, H001G3_n43TTBUS_MotivoBaja, H001G3_A16TTBUS_FechaBaja, H001G3_n16TTBUS_FechaBaja, H001G3_A23TTBUS_Estado, H001G3_A195TTBUS_UsuarioBaja, H001G3_n195TTBUS_UsuarioBaja, H001G3_A38TTBUS_DesPosicion, H001G3_A37TTBUS_CodPosicion, H001G3_A29TTBUS_Alquilado,
               H001G3_A12TTBUS_Descripcion, H001G3_A11TTBUS_Id
               }
               , new Object[] {
               H001G4_A33TTBUS7_Pos, H001G4_A35TTBUS7_CodResp, H001G4_A36TTBUS7_DesResp, H001G4_n36TTBUS7_DesResp
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavGnumeroidentificador_Enabled = 0 ;
         edtavTtbus7_codresp_Enabled = 0 ;
         edtavTtbus7_desresp_Enabled = 0 ;
         edtavVer_movimientos_Enabled = 0 ;
         edtavListar_movimirneotos_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_Grid1 ;
      private short nGXsfl_10_idx=1 ;
      private short A23TTBUS_Estado ;
      private short A33TTBUS7_Pos ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short AV14seleccion ;
      private short A29TTBUS_Alquilado ;
      private short A37TTBUS_CodPosicion ;
      private short nDonePA ;
      private short AV23TTBUS_CodPosicion ;
      private short nGXsfl_10_fel_idx=1 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int edtavGnumeroidentificador_Enabled ;
      private int edtavTtbus7_codresp_Enabled ;
      private int edtavTtbus7_desresp_Enabled ;
      private int edtavVer_movimientos_Enabled ;
      private int edtavListar_movimirneotos_Enabled ;
      private int A11TTBUS_Id ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavGnumeroidentificador_Visible ;
      private int edtavTtbus7_codresp_Visible ;
      private int edtavTtbus7_desresp_Visible ;
      private int edtavVer_movimientos_Visible ;
      private int edtavListar_movimirneotos_Visible ;
      private String AV19USUARIO ;
      private String AV15SISTEMA ;
      private String wcpOAV19USUARIO ;
      private String wcpOAV15SISTEMA ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_10_idx="0001" ;
      private String edtavGnumeroidentificador_Internalname ;
      private String edtavTtbus7_codresp_Internalname ;
      private String edtavTtbus7_desresp_Internalname ;
      private String edtavVer_movimientos_Internalname ;
      private String edtavListar_movimirneotos_Internalname ;
      private String GXCCtl ;
      private String chkavSeleccion_Internalname ;
      private String chkTTBUS_Alquilado_Internalname ;
      private String A36TTBUS7_DesResp ;
      private String A35TTBUS7_CodResp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDeltalles_Internalname ;
      private String edtTTBUS_Id_Internalname ;
      private String edtTTBUS_Descripcion_Internalname ;
      private String edtTTBUS_CodPosicion_Internalname ;
      private String edtTTBUS_DesPosicion_Internalname ;
      private String edtTTBUS_UsuarioBaja_Internalname ;
      private String cmbTTBUS_Estado_Internalname ;
      private String edtTTBUS_FechaBaja_Internalname ;
      private String edtTTBUS_MotivoBaja_Internalname ;
      private String A38TTBUS_DesPosicion ;
      private String AV18TTBUS7_CodResp ;
      private String AV5TTBUS7_DesResp ;
      private String A195TTBUS_UsuarioBaja ;
      private String AV20ver_movimientos ;
      private String AV21listar_movimirneotos ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavDeltalles_Link ;
      private String edtavDeltalles_Linktarget ;
      private String edtavVer_movimientos_Link ;
      private String edtavVer_movimientos_Linktarget ;
      private String edtavListar_movimirneotos_Link ;
      private String edtavListar_movimirneotos_Linktarget ;
      private String sGXsfl_10_fel_idx="0001" ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char9 ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String GXt_char13 ;
      private String GXt_char14 ;
      private String GXt_char15 ;
      private String TempTags ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String sCtrlAV19USUARIO ;
      private String sCtrlAV15SISTEMA ;
      private String ROClassString ;
      private String edtavGnumeroidentificador_Jsonclick ;
      private String edtTTBUS_Id_Jsonclick ;
      private String edtTTBUS_Descripcion_Jsonclick ;
      private String edtTTBUS_CodPosicion_Jsonclick ;
      private String edtTTBUS_DesPosicion_Jsonclick ;
      private String edtavTtbus7_codresp_Jsonclick ;
      private String edtavTtbus7_desresp_Jsonclick ;
      private String edtTTBUS_UsuarioBaja_Jsonclick ;
      private String cmbTTBUS_Estado_Jsonclick ;
      private String edtTTBUS_FechaBaja_Jsonclick ;
      private String edtTTBUS_MotivoBaja_Jsonclick ;
      private String edtavVer_movimientos_Jsonclick ;
      private String GXt_char16 ;
      private String edtavListar_movimirneotos_Jsonclick ;
      private String GXt_char17 ;
      private DateTime A16TTBUS_FechaBaja ;
      private bool entryPointCalled ;
      private bool n36TTBUS7_DesResp ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n195TTBUS_UsuarioBaja ;
      private bool n16TTBUS_FechaBaja ;
      private bool n43TTBUS_MotivoBaja ;
      private bool returnInSub ;
      private String A12TTBUS_Descripcion ;
      private String AV22gNumeroIdentificador ;
      private String A43TTBUS_MotivoBaja ;
      private String l12TTBUS_Descripcion ;
      private String AV6deltalles ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private String aP1_SISTEMA ;
      private GXCheckbox chkavSeleccion ;
      private GXCheckbox chkTTBUS_Alquilado ;
      private GXCombobox cmbTTBUS_Estado ;
      private IDataStoreProvider pr_default ;
      private String[] H001G2_A12TTBUS_Descripcion ;
      private String[] H001G3_A43TTBUS_MotivoBaja ;
      private bool[] H001G3_n43TTBUS_MotivoBaja ;
      private DateTime[] H001G3_A16TTBUS_FechaBaja ;
      private bool[] H001G3_n16TTBUS_FechaBaja ;
      private short[] H001G3_A23TTBUS_Estado ;
      private String[] H001G3_A195TTBUS_UsuarioBaja ;
      private bool[] H001G3_n195TTBUS_UsuarioBaja ;
      private String[] H001G3_A38TTBUS_DesPosicion ;
      private short[] H001G3_A37TTBUS_CodPosicion ;
      private short[] H001G3_A29TTBUS_Alquilado ;
      private String[] H001G3_A12TTBUS_Descripcion ;
      private int[] H001G3_A11TTBUS_Id ;
      private short[] H001G4_A33TTBUS7_Pos ;
      private String[] H001G4_A35TTBUS7_CodResp ;
      private String[] H001G4_A36TTBUS7_DesResp ;
      private bool[] H001G4_n36TTBUS7_DesResp ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class htbus003_b__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001G2 ;
          prmH001G2 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH001G3 ;
          prmH001G3 = new Object[] {
          } ;
          Object[] prmH001G4 ;
          prmH001G4 = new Object[] {
          new Object[] {"@AV23TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001G2", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001G2,0,0,true,false )
             ,new CursorDef("H001G3", "SELECT [TTBUS_MotivoBaja], [TTBUS_FechaBaja], [TTBUS_Estado], [TTBUS_UsuarioBaja], [TTBUS_DesPosicion], [TTBUS_CodPosicion], [TTBUS_Alquilado], [TTBUS_Descripcion], [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Estado] = 3 ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001G3,100,0,true,false )
             ,new CursorDef("H001G4", "SELECT T1.[TTBUS7_Pos], T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @AV23TTBUS_CodPosicion ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001G4,1,0,false,true )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((String[]) buf[5])[0] = rslt.getString(4, 15) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 50) ;
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(8) ;
                ((int[]) buf[11])[0] = rslt.getInt(9) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
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
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
