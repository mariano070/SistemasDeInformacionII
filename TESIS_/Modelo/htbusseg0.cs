/*
               File: HTBUSSEG0
        Description: ABM de Usuarios
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:8.34
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
   public class htbusseg0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbusseg0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbusseg0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_pUSU_COD ,
                           ref String aP1_Modo ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV21pUSU_COD = aP0_pUSU_COD;
         this.AV20Modo = aP1_Modo;
         this.AV18SISTEMA = aP2_SISTEMA;
         this.AV19USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_pUSU_COD=this.AV21pUSU_COD;
         aP1_Modo=this.AV20Modo;
         aP2_SISTEMA=this.AV18SISTEMA;
         aP3_USUARIO=this.AV19USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavAdministrador = new GXCheckbox();
         chkavResponsable = new GXCheckbox();
         chkavPermiso = new GXCheckbox();
         chkavRespaux = new GXCheckbox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_50_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_50_idx = GetNextPar( ) ;
               chkavRespaux.Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRespaux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRespaux.Enabled), 5, 0)));
               chkavPermiso.Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavPermiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavPermiso.Enabled), 5, 0)));
               chkavResponsable.Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResponsable.Enabled), 5, 0)));
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
               edtavW53pos_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavW53pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53pos_Enabled), 5, 0)));
               edtavW53des_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavW53des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53des_Enabled), 5, 0)));
               edtavUsu_resp_cod_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_resp_cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_resp_cod_Enabled), 5, 0)));
               edtavUsu_resp_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_resp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_resp_Enabled), 5, 0)));
               chkavAdministrador.Name = "vADMINISTRADOR" ;
               chkavAdministrador.WebTags = "" ;
               chkavAdministrador.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAdministrador_Internalname, "Caption", chkavAdministrador.Caption);
               chkavAdministrador.CheckedValue = "0" ;
               GXCCtl = "vRESPONSABLE_" + sGXsfl_50_idx ;
               chkavResponsable.Name = GXCCtl ;
               chkavResponsable.WebTags = "" ;
               chkavResponsable.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavResponsable_Internalname, "Caption", chkavResponsable.Caption);
               chkavResponsable.CheckedValue = "0" ;
               GXCCtl = "vPERMISO_" + sGXsfl_50_idx ;
               chkavPermiso.Name = GXCCtl ;
               chkavPermiso.WebTags = "" ;
               chkavPermiso.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavPermiso_Internalname, "Caption", chkavPermiso.Caption);
               chkavPermiso.CheckedValue = "0" ;
               GXCCtl = "vRESPAUX_" + sGXsfl_50_idx ;
               chkavRespaux.Name = GXCCtl ;
               chkavRespaux.WebTags = "" ;
               chkavRespaux.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRespaux_Internalname, "Caption", chkavRespaux.Caption);
               chkavRespaux.CheckedValue = "0" ;
               chkavRespaux.Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRespaux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRespaux.Enabled), 5, 0)));
               chkavPermiso.Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavPermiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavPermiso.Enabled), 5, 0)));
               chkavResponsable.Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResponsable.Enabled), 5, 0)));
               A51TTBUS7_RespAux = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
               A39TTBUS7_CodUsuario = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
               A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               AV20Modo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
               A36TTBUS7_DesResp = GetNextPar( ) ;
               n36TTBUS7_DesResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               A35TTBUS7_CodResp = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A31W53POS = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               A32W53DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( A51TTBUS7_RespAux, A39TTBUS7_CodUsuario, A33TTBUS7_Pos, AV20Modo, A36TTBUS7_DesResp, A35TTBUS7_CodResp, A31W53POS, A32W53DES) ;
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
               AV21pUSU_COD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21pUSU_COD", AV21pUSU_COD);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV20Modo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                  AV18SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18SISTEMA", AV18SISTEMA);
                  AV19USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19USUARIO", AV19USUARIO);
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

      public override short ExecuteStartEvent( )
      {
         PA5B2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START5B2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbusseg0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV21pUSU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV20Modo)) + "," + UrlEncode(StringUtil.RTrim(AV18SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV19USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPUSU_COD", StringUtil.RTrim( AV21pUSU_COD));
         GxWebStd.gx_hidden_field( context, "vMODO", StringUtil.RTrim( AV20Modo));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV18SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV19USUARIO));
         GxWebStd.gx_hidden_field( context, "TTBUS7_RESPAUX", StringUtil.LTrim( StringUtil.NToC( (decimal)(A51TTBUS7_RespAux), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODUSUARIO", StringUtil.RTrim( A39TTBUS7_CodUsuario));
         GxWebStd.gx_hidden_field( context, "TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DESRESP", StringUtil.RTrim( A36TTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODRESP", StringUtil.RTrim( A35TTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "W53POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31W53POS), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "W53DES", StringUtil.RTrim( A32W53DES));
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
            WE5B2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT5B2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "HTBUSSEG0" ;
      }

      public override String GetPgmdesc( )
      {
         return "ABM de Usuarios" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbusseg0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV21pUSU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV20Modo)) + "," + UrlEncode(StringUtil.RTrim(AV18SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV19USUARIO)) ;
      }

      protected void WB5B0( )
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
            wb_table1_2_5B2( true) ;
         }
         else
         {
            wb_table1_2_5B2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_5B2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START5B2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "ABM de Usuarios", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP5B0( ) ;
      }

      protected void WS5B2( )
      {
         START5B2( ) ;
         EVT5B2( ) ;
      }

      protected void EVT5B2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: E115B2 */
                                    E115B2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CANCELAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E125B2 */
                              E125B2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'CANCELAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_50_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
                              edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_idx ;
                              edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_idx ;
                              edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_idx ;
                              edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_idx ;
                              chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_idx ;
                              chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_idx ;
                              chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_idx ;
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavW53pos_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vW53POS");
                                 GX_FocusControl = edtavW53pos_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV11W53POS = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                              }
                              else
                              {
                                 AV11W53POS = (short)(context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                              }
                              AV12W53DES = cgiGet( edtavW53des_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12W53DES", AV12W53DES);
                              AV28Usu_resp_cod = cgiGet( edtavUsu_resp_cod_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28Usu_resp_cod", AV28Usu_resp_cod);
                              AV27Usu_Resp = StringUtil.Upper( cgiGet( edtavUsu_resp_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27Usu_Resp", AV27Usu_Resp);
                              if ( ! context.localUtil.VCNumber( cgiGet( chkavResponsable_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vRESPONSABLE");
                                 GX_FocusControl = chkavResponsable_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV9Responsable = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
                              }
                              else
                              {
                                 AV9Responsable = (short)(((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
                              }
                              if ( ! context.localUtil.VCNumber( cgiGet( chkavPermiso_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vPERMISO");
                                 GX_FocusControl = chkavPermiso_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV14Permiso = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                              }
                              else
                              {
                                 AV14Permiso = (short)(((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                              }
                              if ( ! context.localUtil.VCNumber( cgiGet( chkavRespaux_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vRESPAUX");
                                 GX_FocusControl = chkavRespaux_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV15RespAux = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                              }
                              else
                              {
                                 AV15RespAux = (short)(((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                              }
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E135B2 */
                                    E135B2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E145B2 */
                                    E145B2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E115B2 */
                                          E115B2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'CANCELAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E125B2 */
                                    E125B2 ();
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

      protected void WE5B2( )
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

      protected void PA5B2( )
      {
         if ( nDonePA == 0 )
         {
            chkavAdministrador.Name = "vADMINISTRADOR" ;
            chkavAdministrador.WebTags = "" ;
            chkavAdministrador.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAdministrador_Internalname, "Caption", chkavAdministrador.Caption);
            chkavAdministrador.CheckedValue = "0" ;
            GXCCtl = "vRESPONSABLE_" + sGXsfl_50_idx ;
            chkavResponsable.Name = GXCCtl ;
            chkavResponsable.WebTags = "" ;
            chkavResponsable.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavResponsable_Internalname, "Caption", chkavResponsable.Caption);
            chkavResponsable.CheckedValue = "0" ;
            GXCCtl = "vPERMISO_" + sGXsfl_50_idx ;
            chkavPermiso.Name = GXCCtl ;
            chkavPermiso.WebTags = "" ;
            chkavPermiso.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavPermiso_Internalname, "Caption", chkavPermiso.Caption);
            chkavPermiso.CheckedValue = "0" ;
            GXCCtl = "vRESPAUX_" + sGXsfl_50_idx ;
            chkavRespaux.Name = GXCCtl ;
            chkavRespaux.WebTags = "" ;
            chkavRespaux.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRespaux_Internalname, "Caption", chkavRespaux.Caption);
            chkavRespaux.CheckedValue = "0" ;
            GX_FocusControl = edtavUsu_cod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_50_idx ,
                                       String sGXsfl_50_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_idx ;
         edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_idx ;
         edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_idx ;
         edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_idx ;
         chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_idx ;
         chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_idx ;
         chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_idx ;
         while ( nGXsfl_50_idx <= nRC_Grid1 )
         {
            sendrow_502( ) ;
            nGXsfl_50_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_50_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_50_idx+1)) ;
            sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
            edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_idx ;
            edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_idx ;
            edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_idx ;
            edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_idx ;
            chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_idx ;
            chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_idx ;
            chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( short A51TTBUS7_RespAux ,
                                        String A39TTBUS7_CodUsuario ,
                                        short A33TTBUS7_Pos ,
                                        String AV20Modo ,
                                        String A36TTBUS7_DesResp ,
                                        String A35TTBUS7_CodResp ,
                                        short A31W53POS ,
                                        String A32W53DES )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF5B2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF5B2( ) ;
         /* End function Refresh */
      }

      protected void RF5B2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 50 ;
         nGXsfl_50_idx = 1 ;
         sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
         edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_idx ;
         edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_idx ;
         edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_idx ;
         edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_idx ;
         chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_idx ;
         chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_idx ;
         chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_idx ;
            edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_idx ;
            edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_idx ;
            edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_idx ;
            chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_idx ;
            chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_idx ;
            chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_idx ;
            /* Execute user event: E145B2 */
            E145B2 ();
            wbEnd = 50 ;
            WB5B0( ) ;
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

      protected void STRUP5B0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavW53pos_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavW53pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53pos_Enabled), 5, 0)));
         edtavW53des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavW53des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53des_Enabled), 5, 0)));
         edtavUsu_resp_cod_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_resp_cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_resp_cod_Enabled), 5, 0)));
         edtavUsu_resp_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_resp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_resp_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E135B2 */
         E135B2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV5USU_COD = StringUtil.Upper( cgiGet( edtavUsu_cod_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
            AV6USU_DES = StringUtil.Upper( cgiGet( edtavUsu_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USU_DES", AV6USU_DES);
            AV7USU_CLA = cgiGet( edtavUsu_cla_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USU_CLA", AV7USU_CLA);
            AV29USU_INT = cgiGet( edtavUsu_int_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29USU_INT", AV29USU_INT);
            AV30USU_MAIW = cgiGet( edtavUsu_maiw_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30USU_MAIW", AV30USU_MAIW);
            if ( ! context.localUtil.VCNumber( cgiGet( chkavAdministrador_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavAdministrador_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavAdministrador_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vADMINISTRADOR");
               GX_FocusControl = chkavAdministrador_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8Administrador = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8Administrador", StringUtil.Str( (decimal)(AV8Administrador), 1, 0));
            }
            else
            {
               AV8Administrador = (short)(((StringUtil.StrCmp(cgiGet( chkavAdministrador_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8Administrador", StringUtil.Str( (decimal)(AV8Administrador), 1, 0));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV21pUSU_COD = cgiGet( "vPUSU_COD") ;
            AV20Modo = cgiGet( "vMODO") ;
            AV18SISTEMA = cgiGet( "vSISTEMA") ;
            AV19USUARIO = cgiGet( "vUSUARIO") ;
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
         /* Execute user event: E135B2 */
         E135B2 ();
         if (returnInSub) return;
      }

      protected void E135B2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV31Context) ;
         AV19USUARIO = AV31Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19USUARIO", AV19USUARIO);
         new pseg102(context ).execute( ref  AV19USUARIO) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19USUARIO", AV19USUARIO);
         /* Execute user subroutine: S112 */
         S112 ();
         if (returnInSub) return;
      }

      private void E145B2( )
      {
         /* Grid1_Load Routine */
         /* Using cursor H005B2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A31W53POS = H005B2_A31W53POS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
            A32W53DES = H005B2_A32W53DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
            AV11W53POS = A31W53POS ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
            AV12W53DES = A32W53DES ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12W53DES", AV12W53DES);
            AV28Usu_resp_cod = "" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28Usu_resp_cod", AV28Usu_resp_cod);
            AV27Usu_Resp = "" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27Usu_Resp", AV27Usu_Resp);
            /* Using cursor H005B3 */
            pr_default.execute(1, new Object[] {A31W53POS});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A33TTBUS7_Pos = H005B3_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A35TTBUS7_CodResp = H005B3_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A36TTBUS7_DesResp = H005B3_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H005B3_n36TTBUS7_DesResp[0] ;
               A36TTBUS7_DesResp = H005B3_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H005B3_n36TTBUS7_DesResp[0] ;
               AV28Usu_resp_cod = A35TTBUS7_CodResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28Usu_resp_cod", AV28Usu_resp_cod);
               AV27Usu_Resp = StringUtil.Trim( A36TTBUS7_DesResp) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27Usu_Resp", AV27Usu_Resp);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            if ( StringUtil.StrCmp(AV20Modo, "INS") != 0 )
            {
               AV22TTBUS7_Pos = A31W53POS ;
               /* Execute user subroutine: S123 */
               S123 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  returnInSub = true;
                  if (true) return;
               }
               if ( AV24resp == 1 )
               {
                  AV9Responsable = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
               }
               else
               {
                  AV9Responsable = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
               }
               if ( AV25perm == 1 )
               {
                  AV14Permiso = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                  if ( AV26resp_aux == 1 )
                  {
                     AV15RespAux = 1 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                  }
                  else
                  {
                     AV15RespAux = 0 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                  }
               }
               else
               {
                  AV14Permiso = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                  AV15RespAux = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
               }
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 50 ;
            }
            sendrow_502( ) ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      public void GXEnter( )
      {
         /* Execute user event: E115B2 */
         E115B2 ();
         if (returnInSub) return;
      }

      protected void E115B2( )
      {
         /* Enter Routine */
         if ( StringUtil.StrCmp(AV20Modo, "DSP") != 0 )
         {
            /* Execute user subroutine: S132 */
            S132 ();
            if (returnInSub) return;
            if ( AV16ok == 0 )
            {
               GX_msglist.addItem(StringUtil.Trim( AV17error));
            }
            else
            {
               if ( StringUtil.StrCmp(AV20Modo, "DLT") == 0 )
               {
                  /* Start For Each Line in Grid1 */
                  nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
                  nGXsfl_50_fel_idx = 0 ;
                  while ( nGXsfl_50_fel_idx < nRC_Grid1 )
                  {
                     nGXsfl_50_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_50_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_50_fel_idx+1)) ;
                     sGXsfl_50_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_fel_idx), 4, 0)), 4, "0") ;
                     edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_fel_idx ;
                     edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_fel_idx ;
                     edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_fel_idx ;
                     edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_fel_idx ;
                     chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_fel_idx ;
                     chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_fel_idx ;
                     chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_fel_idx ;
                     if ( ! context.localUtil.VCNumber( cgiGet( edtavW53pos_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vW53POS");
                        GX_FocusControl = edtavW53pos_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                        wbErr = true ;
                        AV11W53POS = 0 ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                     }
                     else
                     {
                        AV11W53POS = (short)(context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".")) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                     }
                     AV12W53DES = cgiGet( edtavW53des_Internalname) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12W53DES", AV12W53DES);
                     AV28Usu_resp_cod = cgiGet( edtavUsu_resp_cod_Internalname) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28Usu_resp_cod", AV28Usu_resp_cod);
                     AV27Usu_Resp = StringUtil.Upper( cgiGet( edtavUsu_resp_Internalname)) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27Usu_Resp", AV27Usu_Resp);
                     if ( ! context.localUtil.VCNumber( cgiGet( chkavResponsable_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vRESPONSABLE");
                        GX_FocusControl = chkavResponsable_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                        wbErr = true ;
                        AV9Responsable = 0 ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
                     }
                     else
                     {
                        AV9Responsable = (short)(((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0)) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
                     }
                     if ( ! context.localUtil.VCNumber( cgiGet( chkavPermiso_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vPERMISO");
                        GX_FocusControl = chkavPermiso_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                        wbErr = true ;
                        AV14Permiso = 0 ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                     }
                     else
                     {
                        AV14Permiso = (short)(((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0)) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                     }
                     if ( ! context.localUtil.VCNumber( cgiGet( chkavRespaux_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vRESPAUX");
                        GX_FocusControl = chkavRespaux_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                        wbErr = true ;
                        AV15RespAux = 0 ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                     }
                     else
                     {
                        AV15RespAux = (short)(((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0)) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                     }
                     new ptbusseg4(context ).execute( ref  AV11W53POS, ref  AV5USU_COD, ref  AV15RespAux, ref  AV14Permiso, ref  AV20Modo) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                     new ptbusseg3(context ).execute( ref  AV11W53POS, ref  AV5USU_COD, ref  AV9Responsable, ref  AV20Modo) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                     /* End For Each Line */
                  }
                  if ( nGXsfl_50_fel_idx == 0 )
                  {
                     nGXsfl_50_idx = 1 ;
                     sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
                     edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_idx ;
                     edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_idx ;
                     edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_idx ;
                     edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_idx ;
                     chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_idx ;
                     chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_idx ;
                     chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_idx ;
                  }
                  nGXsfl_50_fel_idx = 1 ;
                  new ptbusseg2(context ).execute( ref  AV5USU_COD, ref  AV8Administrador, ref  AV20Modo) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8Administrador", StringUtil.Str( (decimal)(AV8Administrador), 1, 0));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                  new ptbusseg5(context ).execute( ref  AV5USU_COD, ref  AV20Modo) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                  new ptbusseg1(context ).execute( ref  AV5USU_COD, ref  AV6USU_DES, ref  AV7USU_CLA, ref  AV29USU_INT, ref  AV30USU_MAIW, ref  AV20Modo) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USU_DES", AV6USU_DES);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USU_CLA", AV7USU_CLA);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29USU_INT", AV29USU_INT);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30USU_MAIW", AV30USU_MAIW);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                  context.setWebReturnParms(new Object[] {(String)AV21pUSU_COD,(String)AV20Modo,(String)AV18SISTEMA,(String)AV19USUARIO});
                  context.nUserReturn = 1 ;
                  returnInSub = true;
                  if (true) return;
               }
               else
               {
                  new ptbusseg1(context ).execute( ref  AV5USU_COD, ref  AV6USU_DES, ref  AV7USU_CLA, ref  AV29USU_INT, ref  AV30USU_MAIW, ref  AV20Modo) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USU_DES", AV6USU_DES);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USU_CLA", AV7USU_CLA);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29USU_INT", AV29USU_INT);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30USU_MAIW", AV30USU_MAIW);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                  new ptbusseg2(context ).execute( ref  AV5USU_COD, ref  AV8Administrador, ref  AV20Modo) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8Administrador", StringUtil.Str( (decimal)(AV8Administrador), 1, 0));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                  /* Start For Each Line in Grid1 */
                  nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
                  nGXsfl_50_fel_idx = 0 ;
                  while ( nGXsfl_50_fel_idx < nRC_Grid1 )
                  {
                     nGXsfl_50_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_50_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_50_fel_idx+1)) ;
                     sGXsfl_50_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_fel_idx), 4, 0)), 4, "0") ;
                     edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_fel_idx ;
                     edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_fel_idx ;
                     edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_fel_idx ;
                     edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_fel_idx ;
                     chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_fel_idx ;
                     chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_fel_idx ;
                     chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_fel_idx ;
                     if ( ! context.localUtil.VCNumber( cgiGet( edtavW53pos_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vW53POS");
                        GX_FocusControl = edtavW53pos_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                        wbErr = true ;
                        AV11W53POS = 0 ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                     }
                     else
                     {
                        AV11W53POS = (short)(context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".")) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                     }
                     AV12W53DES = cgiGet( edtavW53des_Internalname) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12W53DES", AV12W53DES);
                     AV28Usu_resp_cod = cgiGet( edtavUsu_resp_cod_Internalname) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28Usu_resp_cod", AV28Usu_resp_cod);
                     AV27Usu_Resp = StringUtil.Upper( cgiGet( edtavUsu_resp_Internalname)) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27Usu_Resp", AV27Usu_Resp);
                     if ( ! context.localUtil.VCNumber( cgiGet( chkavResponsable_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vRESPONSABLE");
                        GX_FocusControl = chkavResponsable_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                        wbErr = true ;
                        AV9Responsable = 0 ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
                     }
                     else
                     {
                        AV9Responsable = (short)(((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0)) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
                     }
                     if ( ! context.localUtil.VCNumber( cgiGet( chkavPermiso_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vPERMISO");
                        GX_FocusControl = chkavPermiso_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                        wbErr = true ;
                        AV14Permiso = 0 ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                     }
                     else
                     {
                        AV14Permiso = (short)(((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0)) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                     }
                     if ( ! context.localUtil.VCNumber( cgiGet( chkavRespaux_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vRESPAUX");
                        GX_FocusControl = chkavRespaux_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                        wbErr = true ;
                        AV15RespAux = 0 ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                     }
                     else
                     {
                        AV15RespAux = (short)(((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0)) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                     }
                     new ptbusseg3(context ).execute( ref  AV11W53POS, ref  AV5USU_COD, ref  AV9Responsable, ref  AV20Modo) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                     new ptbusseg4(context ).execute( ref  AV11W53POS, ref  AV5USU_COD, ref  AV15RespAux, ref  AV14Permiso, ref  AV20Modo) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                     /* End For Each Line */
                  }
                  if ( nGXsfl_50_fel_idx == 0 )
                  {
                     nGXsfl_50_idx = 1 ;
                     sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
                     edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_idx ;
                     edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_idx ;
                     edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_idx ;
                     edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_idx ;
                     chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_idx ;
                     chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_idx ;
                     chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_idx ;
                  }
                  nGXsfl_50_fel_idx = 1 ;
                  new ptbusseg5(context ).execute( ref  AV5USU_COD, ref  AV20Modo) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
                  context.setWebReturnParms(new Object[] {(String)AV21pUSU_COD,(String)AV20Modo,(String)AV18SISTEMA,(String)AV19USUARIO});
                  context.nUserReturn = 1 ;
                  returnInSub = true;
                  if (true) return;
               }
            }
         }
         else
         {
            context.setWebReturnParms(new Object[] {(String)AV21pUSU_COD,(String)AV20Modo,(String)AV18SISTEMA,(String)AV19USUARIO});
            context.nUserReturn = 1 ;
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E125B2( )
      {
         /* 'Cancelar' Routine */
         context.setWebReturnParms(new Object[] {(String)AV21pUSU_COD,(String)AV20Modo,(String)AV18SISTEMA,(String)AV19USUARIO});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void S132( )
      {
         /* 'VALIDACIONES' Routine */
         AV16ok = 1 ;
         AV17error = "" ;
         if ( StringUtil.StrCmp(StringUtil.Trim( AV5USU_COD), "") == 0 )
         {
            AV17error = "DEBE INGRESAR UN USUARIO." ;
            AV16ok = 0 ;
         }
         if ( AV16ok == 1 )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( AV6USU_DES), "") == 0 )
            {
               AV17error = "DEBE INGRESAR UNA DESCRIPCIÓN DE USUARIO." ;
               AV16ok = 0 ;
            }
         }
         if ( AV16ok == 1 )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( AV7USU_CLA), "") == 0 )
            {
               AV17error = "DEBE INGRESAR UNA CONTRASEÑA." ;
               AV16ok = 0 ;
            }
         }
         if ( AV16ok == 1 )
         {
            /* Start For Each Line in Grid1 */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            nGXsfl_50_fel_idx = 0 ;
            while ( nGXsfl_50_fel_idx < nRC_Grid1 )
            {
               nGXsfl_50_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_50_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_50_fel_idx+1)) ;
               sGXsfl_50_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_fel_idx), 4, 0)), 4, "0") ;
               edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_fel_idx ;
               edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_fel_idx ;
               edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_fel_idx ;
               edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_fel_idx ;
               chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_fel_idx ;
               chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_fel_idx ;
               chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_fel_idx ;
               if ( ! context.localUtil.VCNumber( cgiGet( edtavW53pos_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vW53POS");
                  GX_FocusControl = edtavW53pos_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV11W53POS = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
               }
               else
               {
                  AV11W53POS = (short)(context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11W53POS), 3, 0)));
               }
               AV12W53DES = cgiGet( edtavW53des_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12W53DES", AV12W53DES);
               AV28Usu_resp_cod = cgiGet( edtavUsu_resp_cod_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28Usu_resp_cod", AV28Usu_resp_cod);
               AV27Usu_Resp = StringUtil.Upper( cgiGet( edtavUsu_resp_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27Usu_Resp", AV27Usu_Resp);
               if ( ! context.localUtil.VCNumber( cgiGet( chkavResponsable_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vRESPONSABLE");
                  GX_FocusControl = chkavResponsable_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV9Responsable = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
               }
               else
               {
                  AV9Responsable = (short)(((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Responsable", StringUtil.Str( (decimal)(AV9Responsable), 1, 0));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( chkavPermiso_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vPERMISO");
                  GX_FocusControl = chkavPermiso_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV14Permiso = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
               }
               else
               {
                  AV14Permiso = (short)(((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Permiso", StringUtil.Str( (decimal)(AV14Permiso), 1, 0));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( chkavRespaux_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vRESPAUX");
                  GX_FocusControl = chkavRespaux_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV15RespAux = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
               }
               else
               {
                  AV15RespAux = (short)(((StringUtil.StrCmp(cgiGet( chkavRespaux_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15RespAux", StringUtil.Str( (decimal)(AV15RespAux), 1, 0));
               }
               if ( AV9Responsable == 1 )
               {
                  if ( ( ( StringUtil.StrCmp(AV28Usu_resp_cod, AV5USU_COD) != 0 ) ) && ( ( StringUtil.StrCmp(StringUtil.Trim( AV28Usu_resp_cod), "") != 0 ) ) )
                  {
                     AV16ok = 0 ;
                     AV17error = "LA POSICIÓN \"" + StringUtil.Trim( AV12W53DES) + "\" YA TIENE UN RESPONSABLE." ;
                  }
               }
               if ( AV16ok == 0 )
               {
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               else
               {
                  if ( ( AV14Permiso == 1 ) && ( StringUtil.StrCmp(StringUtil.Trim( AV28Usu_resp_cod), "") == 0 ) )
                  {
                     AV16ok = 0 ;
                     AV17error = "NO SE PUEDE ASIGNAR PERMISOS A LA POSICIÓN \"" + StringUtil.Trim( AV12W53DES) + "\" PORQUE NO TIENE UN RESPONSABLE CARGADO." ;
                  }
               }
               if ( AV16ok == 0 )
               {
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               else
               {
                  if ( ( AV15RespAux == 1 ) && ( AV14Permiso == 0 ) )
                  {
                     AV16ok = 0 ;
                     AV17error = "PARA ASIGNAR UN RESPONSABLE AUXILIAR A LA POSICIÓN \"" + StringUtil.Trim( AV12W53DES) + "\" TAMBIÉN HAY QUE ASIGNARLE UN PERMISO." ;
                  }
               }
               if ( AV16ok == 0 )
               {
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               if ( AV9Responsable == 0 )
               {
                  AV32encuentra_permisos = 0 ;
                  /* Using cursor H005B4 */
                  pr_default.execute(2, new Object[] {AV11W53POS, AV5USU_COD});
                  while ( (pr_default.getStatus(2) != 101) )
                  {
                     A33TTBUS7_Pos = H005B4_A33TTBUS7_Pos[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                     A35TTBUS7_CodResp = H005B4_A35TTBUS7_CodResp[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                     AV32encuentra_permisos = 1 ;
                     pr_default.readNext(2);
                  }
                  pr_default.close(2);
                  if ( AV32encuentra_permisos == 1 )
                  {
                     AV33usuarios_permisos = "" ;
                     /* Using cursor H005B5 */
                     pr_default.execute(3, new Object[] {AV11W53POS});
                     while ( (pr_default.getStatus(3) != 101) )
                     {
                        A33TTBUS7_Pos = H005B5_A33TTBUS7_Pos[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                        A199TTBUS7_DesUsuario = H005B5_A199TTBUS7_DesUsuario[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
                        n199TTBUS7_DesUsuario = H005B5_n199TTBUS7_DesUsuario[0] ;
                        A39TTBUS7_CodUsuario = H005B5_A39TTBUS7_CodUsuario[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
                        A199TTBUS7_DesUsuario = H005B5_A199TTBUS7_DesUsuario[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
                        n199TTBUS7_DesUsuario = H005B5_n199TTBUS7_DesUsuario[0] ;
                        AV16ok = 0 ;
                        AV33usuarios_permisos = AV33usuarios_permisos + StringUtil.Trim( A199TTBUS7_DesUsuario) + " - " ;
                        pr_default.readNext(3);
                     }
                     pr_default.close(3);
                     if ( AV16ok == 0 )
                     {
                        AV17error = "NO PUEDE QUITAR ESTE USUARIO COMO RESPONSABLE DE LA POSICIÓN \"" + StringUtil.Trim( AV12W53DES) + "\" PORQUE LA MISMA TIENE PERMISOS ASOCIADOS. PARA REALIZAR ESTA OPERACIÓN PRIMERO DEBE BORRAR DICHOS PERMISOS. VER USUARIOS: " + AV33usuarios_permisos + "." ;
                     }
                  }
               }
               if ( AV16ok == 0 )
               {
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               /* End For Each Line */
            }
            if ( nGXsfl_50_fel_idx == 0 )
            {
               nGXsfl_50_idx = 1 ;
               sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
               edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_idx ;
               edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_idx ;
               edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_idx ;
               edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_idx ;
               chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_idx ;
               chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_idx ;
               chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_idx ;
            }
            nGXsfl_50_fel_idx = 1 ;
         }
      }

      protected void S112( )
      {
         /* 'CARGA WEB PANEL' Routine */
         if ( StringUtil.StrCmp(AV20Modo, "INS") == 0 )
         {
            edtavUsu_cod_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_cod_Enabled), 5, 0)));
            edtavUsu_des_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_des_Enabled), 5, 0)));
            edtavUsu_cla_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_cla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_cla_Enabled), 5, 0)));
            edtavUsu_int_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_int_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_int_Enabled), 5, 0)));
            edtavUsu_maiw_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_maiw_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_maiw_Enabled), 5, 0)));
            chkavAdministrador.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAdministrador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavAdministrador.Enabled), 5, 0)));
            chkavResponsable.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResponsable.Enabled), 5, 0)));
            chkavPermiso.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavPermiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavPermiso.Enabled), 5, 0)));
            chkavRespaux.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRespaux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRespaux.Enabled), 5, 0)));
         }
         else if ( StringUtil.StrCmp(AV20Modo, "DLT") == 0 )
         {
            edtavUsu_cod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_cod_Enabled), 5, 0)));
            edtavUsu_des_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_des_Enabled), 5, 0)));
            edtavUsu_cla_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_cla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_cla_Enabled), 5, 0)));
            edtavUsu_int_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_int_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_int_Enabled), 5, 0)));
            edtavUsu_maiw_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_maiw_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_maiw_Enabled), 5, 0)));
            chkavAdministrador.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAdministrador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavAdministrador.Enabled), 5, 0)));
            chkavResponsable.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResponsable.Enabled), 5, 0)));
            chkavPermiso.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavPermiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavPermiso.Enabled), 5, 0)));
            chkavRespaux.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRespaux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRespaux.Enabled), 5, 0)));
            /* Execute user subroutine: S142 */
            S142 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(AV20Modo, "UPD") == 0 )
         {
            edtavUsu_cod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_cod_Enabled), 5, 0)));
            edtavUsu_des_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_des_Enabled), 5, 0)));
            edtavUsu_cla_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_cla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_cla_Enabled), 5, 0)));
            edtavUsu_int_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_int_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_int_Enabled), 5, 0)));
            edtavUsu_maiw_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_maiw_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_maiw_Enabled), 5, 0)));
            chkavAdministrador.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAdministrador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavAdministrador.Enabled), 5, 0)));
            chkavResponsable.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResponsable.Enabled), 5, 0)));
            chkavPermiso.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavPermiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavPermiso.Enabled), 5, 0)));
            chkavRespaux.Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRespaux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRespaux.Enabled), 5, 0)));
            /* Execute user subroutine: S142 */
            S142 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(AV20Modo, "DSP") == 0 )
         {
            edtavUsu_cod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_cod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_cod_Enabled), 5, 0)));
            edtavUsu_des_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_des_Enabled), 5, 0)));
            edtavUsu_cla_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_cla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_cla_Enabled), 5, 0)));
            edtavUsu_int_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_int_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_int_Enabled), 5, 0)));
            edtavUsu_maiw_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_maiw_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_maiw_Enabled), 5, 0)));
            chkavAdministrador.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavAdministrador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavAdministrador.Enabled), 5, 0)));
            chkavResponsable.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResponsable.Enabled), 5, 0)));
            chkavPermiso.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavPermiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavPermiso.Enabled), 5, 0)));
            chkavRespaux.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavRespaux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavRespaux.Enabled), 5, 0)));
            /* Execute user subroutine: S142 */
            S142 ();
            if (returnInSub) return;
         }
      }

      protected void S142( )
      {
         /* 'BUSCA DATOS USUARIO CAB' Routine */
         /* Using cursor H005B6 */
         pr_default.execute(4, new Object[] {AV21pUSU_COD});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A6USU_COD = H005B6_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H005B6_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = H005B6_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            A180USU_INT = H005B6_A180USU_INT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180USU_INT", A180USU_INT);
            n180USU_INT = H005B6_n180USU_INT[0] ;
            A249USU_MAIW = H005B6_A249USU_MAIW[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A249USU_MAIW", A249USU_MAIW);
            n249USU_MAIW = H005B6_n249USU_MAIW[0] ;
            AV5USU_COD = StringUtil.Trim( A6USU_COD) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USU_COD", AV5USU_COD);
            AV6USU_DES = StringUtil.Trim( A7USU_DES) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USU_DES", AV6USU_DES);
            AV7USU_CLA = StringUtil.Trim( A155USU_CLA) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7USU_CLA", AV7USU_CLA);
            AV29USU_INT = StringUtil.Trim( A180USU_INT) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29USU_INT", AV29USU_INT);
            AV30USU_MAIW = StringUtil.Trim( A249USU_MAIW) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30USU_MAIW", AV30USU_MAIW);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(4);
         AV44GXLvl259 = 0 ;
         /* Using cursor H005B7 */
         pr_default.execute(5, new Object[] {AV21pUSU_COD});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A40TTBUS8_CodUsuario = H005B7_A40TTBUS8_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
            AV44GXLvl259 = 1 ;
            AV8Administrador = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8Administrador", StringUtil.Str( (decimal)(AV8Administrador), 1, 0));
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(5);
         if ( AV44GXLvl259 == 0 )
         {
            AV8Administrador = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8Administrador", StringUtil.Str( (decimal)(AV8Administrador), 1, 0));
         }
      }

      protected void S123( )
      {
         /* 'BUSCA DATOS USUARIO DET' Routine */
         AV24resp = 0 ;
         /* Using cursor H005B8 */
         pr_default.execute(6, new Object[] {AV22TTBUS7_Pos, AV21pUSU_COD});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A35TTBUS7_CodResp = H005B8_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            A33TTBUS7_Pos = H005B8_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            AV24resp = 1 ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(6);
         AV25perm = 0 ;
         AV26resp_aux = 0 ;
         /* Using cursor H005B9 */
         pr_default.execute(7, new Object[] {AV22TTBUS7_Pos, AV21pUSU_COD});
         while ( (pr_default.getStatus(7) != 101) )
         {
            A39TTBUS7_CodUsuario = H005B9_A39TTBUS7_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
            A33TTBUS7_Pos = H005B9_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            A51TTBUS7_RespAux = H005B9_A51TTBUS7_RespAux[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
            AV25perm = 1 ;
            if ( A51TTBUS7_RespAux == 1 )
            {
               AV26resp_aux = 1 ;
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(7);
      }

      protected void wb_table1_2_5B2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            wb_table2_5_5B2( true) ;
         }
         else
         {
            wb_table2_5_5B2( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_5B2e( bool wbgen )
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
            wb_table3_14_5B2( true) ;
         }
         else
         {
            wb_table3_14_5B2( false) ;
         }
         return  ;
      }

      protected void wb_table3_14_5B2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<hr style=\"WIDTH: 874px; HEIGHT: 2px\" class=\"HRDefault\">") ;
            context.WriteHtmlText( "&nbsp;") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata2_Internalname+"\""+" style=\"-moz-border-radius:3pt;width:82px;height:37px;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Posiciones"+"</legend>") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cód. Pos.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Usu_resp_cod") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Usuario Responsable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Permiso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable Auxiliar") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11W53POS), 3, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavW53pos_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV12W53DES));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavW53des_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV28Usu_resp_cod));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUsu_resp_cod_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV27Usu_Resp));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUsu_resp_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9Responsable), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavResponsable.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14Permiso), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavPermiso.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15RespAux), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavRespaux.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
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
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"height:24px\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "EENTER.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(50), 3, 0)+","+"null"+");", "", "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton2_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton2_Jsonclick, "E\\'CANCELAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(50), 3, 0)+","+"null"+");", "", "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_5B2e( true) ;
         }
         else
         {
            wb_table1_2_5B2e( false) ;
         }
      }

      protected void wb_table3_14_5B2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Usuario:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_cod_Internalname, StringUtil.RTrim( AV5USU_COD), "", 16, "chr", 1, "row", 16, 1, edtavUsu_cod_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV5USU_COD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(19);\"", 0, edtavUsu_cod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Descripción:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_des_Internalname, StringUtil.RTrim( AV6USU_DES), "", 50, "chr", 1, "row", 50, 1, edtavUsu_des_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6USU_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(24);\"", 0, edtavUsu_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Contraseña:", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_cla_Internalname, StringUtil.RTrim( AV7USU_CLA), "", 20, "chr", 1, "row", 20, 1, edtavUsu_cla_Enabled, 1, -1, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", 0, edtavUsu_cla_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, 1, 1, 0, "Teléfono Interno:", "", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_int_Internalname, StringUtil.RTrim( AV29USU_INT), "", 10, "chr", 1, "row", 10, 1, edtavUsu_int_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV29USU_INT, "XXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", 0, edtavUsu_int_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, 1, 1, 0, "Correo electrónico:", "", "", "", 0, lblTextblock8_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtavUsu_maiw_Internalname, StringUtil.RTrim( AV30USU_MAIW), 1, edtavUsu_maiw_Enabled, 1, 80, "chr", 4, "row", StyleString, ClassString, "256", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", -1, 0, "", "", true, "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Administrador:", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_HTBUSSEG0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_50_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkavAdministrador_Internalname, StringUtil.Str( (decimal)(AV8Administrador), 1, 0), "", 1, chkavAdministrador.Enabled, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(44, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_14_5B2e( true) ;
         }
         else
         {
            wb_table3_14_5B2e( false) ;
         }
      }

      protected void wb_table2_5_5B2( bool wbgen )
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
            wb_table2_5_5B2e( true) ;
         }
         else
         {
            wb_table2_5_5B2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV21pUSU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21pUSU_COD", AV21pUSU_COD);
         AV20Modo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Modo", AV20Modo);
         AV18SISTEMA = (String)getParm(obj,2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18SISTEMA", AV18SISTEMA);
         AV19USUARIO = (String)getParm(obj,3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19USUARIO", AV19USUARIO);
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
         PA5B2( ) ;
         WS5B2( ) ;
         WE5B2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1147937");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbusseg0.js", "?1147937");
         /* End function include_jscripts */
      }

      protected void sendrow_502( )
      {
         WB5B0( ) ;
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
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( ">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavW53pos_Enabled!=0)&&(edtavW53pos_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 51,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavW53pos_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11W53POS), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(int)edtavW53pos_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV11W53POS), "ZZ9"),TempTags+((edtavW53pos_Enabled!=0)&&(edtavW53pos_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavW53pos_Enabled!=0)&&(edtavW53pos_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(51);\"" : " "),(short)0,(String)edtavW53pos_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavW53des_Enabled!=0)&&(edtavW53des_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 52,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavW53des_Internalname,StringUtil.RTrim( AV12W53DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavW53des_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV12W53DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavW53des_Enabled!=0)&&(edtavW53des_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavW53des_Enabled!=0)&&(edtavW53des_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(52);\"" : " "),(short)0,(String)edtavW53des_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavUsu_resp_cod_Enabled!=0)&&(edtavUsu_resp_cod_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 53,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUsu_resp_cod_Internalname,StringUtil.RTrim( AV28Usu_resp_cod),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)0,(int)edtavUsu_resp_cod_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV28Usu_resp_cod, "XXXXXXXXXXXXXXXX")),TempTags+((edtavUsu_resp_cod_Enabled!=0)&&(edtavUsu_resp_cod_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavUsu_resp_cod_Enabled!=0)&&(edtavUsu_resp_cod_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(53);\"" : " "),(short)0,(String)edtavUsu_resp_cod_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavUsu_resp_Enabled!=0)&&(edtavUsu_resp_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 54,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUsu_resp_Internalname,StringUtil.RTrim( AV27Usu_Resp),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavUsu_resp_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV27Usu_Resp, "@!")),TempTags+((edtavUsu_resp_Enabled!=0)&&(edtavUsu_resp_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavUsu_resp_Enabled!=0)&&(edtavUsu_resp_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(54);\"" : " "),(short)0,(String)edtavUsu_resp_Jsonclick,(String)"",(short)50,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavResponsable.Enabled!=0)&&(chkavResponsable.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 55,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavResponsable_Internalname,StringUtil.Str( (decimal)(AV9Responsable), 1, 0),(String)"",(short)-1,chkavResponsable.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavResponsable.Enabled!=0)&&(chkavResponsable.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(55, this, 1, 0);gx.evt.onchange(this);\" " : " ")+((chkavResponsable.Enabled!=0)&&(chkavResponsable.Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(55);\"" : " ")});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavPermiso.Enabled!=0)&&(chkavPermiso.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 56,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavPermiso_Internalname,StringUtil.Str( (decimal)(AV14Permiso), 1, 0),(String)"",(short)-1,chkavPermiso.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavPermiso.Enabled!=0)&&(chkavPermiso.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(56, this, 1, 0);gx.evt.onchange(this);\" " : " ")+((chkavPermiso.Enabled!=0)&&(chkavPermiso.Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(56);\"" : " ")});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavRespaux.Enabled!=0)&&(chkavRespaux.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 57,'',false,'"+sGXsfl_50_idx+"',50)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavRespaux_Internalname,StringUtil.Str( (decimal)(AV15RespAux), 1, 0),(String)"",(short)-1,chkavRespaux.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavRespaux.Enabled!=0)&&(chkavRespaux.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(57, this, 1, 0);gx.evt.onchange(this);\" " : " ")+((chkavRespaux.Enabled!=0)&&(chkavRespaux.Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(57);\"" : " ")});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_50_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_50_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_50_idx+1)) ;
         sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
         edtavW53pos_Internalname = "vW53POS_"+sGXsfl_50_idx ;
         edtavW53des_Internalname = "vW53DES_"+sGXsfl_50_idx ;
         edtavUsu_resp_cod_Internalname = "vUSU_RESP_COD_"+sGXsfl_50_idx ;
         edtavUsu_resp_Internalname = "vUSU_RESP_"+sGXsfl_50_idx ;
         chkavResponsable_Internalname = "vRESPONSABLE_"+sGXsfl_50_idx ;
         chkavPermiso_Internalname = "vPERMISO_"+sGXsfl_50_idx ;
         chkavRespaux_Internalname = "vRESPAUX_"+sGXsfl_50_idx ;
         /* End function sendrow_502 */
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
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtavUsu_int_Internalname = "vUSU_INT" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtavUsu_maiw_Internalname = "vUSU_MAIW" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         chkavAdministrador_Internalname = "vADMINISTRADOR" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         grpGroupdata2_Internalname = "GROUPDATA2" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         chkavRespaux.Visible = -1 ;
         chkavPermiso.Visible = -1 ;
         chkavResponsable.Visible = -1 ;
         edtavUsu_resp_Jsonclick = "" ;
         edtavUsu_resp_Visible = -1 ;
         edtavUsu_resp_cod_Jsonclick = "" ;
         edtavUsu_resp_cod_Visible = 0 ;
         edtavW53des_Jsonclick = "" ;
         edtavW53des_Visible = -1 ;
         edtavW53pos_Jsonclick = "" ;
         edtavW53pos_Visible = -1 ;
         edtavUsu_int_Jsonclick = "" ;
         edtavUsu_cla_Jsonclick = "" ;
         edtavUsu_des_Jsonclick = "" ;
         edtavUsu_cod_Jsonclick = "" ;
         edtavUsu_resp_Enabled = 1 ;
         edtavUsu_resp_cod_Enabled = 1 ;
         edtavW53des_Enabled = 1 ;
         edtavW53pos_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         chkavAdministrador.Enabled = 1 ;
         edtavUsu_maiw_Enabled = 1 ;
         edtavUsu_int_Enabled = 1 ;
         edtavUsu_cla_Enabled = 1 ;
         edtavUsu_des_Enabled = 1 ;
         edtavUsu_cod_Enabled = 1 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "ABM de Usuarios" ;
         chkavRespaux.Caption = "" ;
         chkavPermiso.Caption = "" ;
         chkavResponsable.Caption = "" ;
         chkavAdministrador.Caption = "" ;
         chkavResponsable.Enabled = 1 ;
         chkavPermiso.Enabled = 1 ;
         chkavRespaux.Enabled = 1 ;
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
         wcpOAV21pUSU_COD = "" ;
         wcpOAV20Modo = "" ;
         wcpOAV18SISTEMA = "" ;
         wcpOAV19USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         chkavRespaux_Internalname = "" ;
         chkavPermiso_Internalname = "" ;
         chkavResponsable_Internalname = "" ;
         edtavW53pos_Internalname = "" ;
         edtavW53des_Internalname = "" ;
         edtavUsu_resp_cod_Internalname = "" ;
         edtavUsu_resp_Internalname = "" ;
         GXCCtl = "" ;
         A39TTBUS7_CodUsuario = "" ;
         A36TTBUS7_DesResp = "" ;
         A35TTBUS7_CodResp = "" ;
         A32W53DES = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV12W53DES = "" ;
         AV28Usu_resp_cod = "" ;
         AV27Usu_Resp = "" ;
         Grid1Container = new GXWebGrid( context);
         AV5USU_COD = "" ;
         AV6USU_DES = "" ;
         AV7USU_CLA = "" ;
         AV29USU_INT = "" ;
         AV30USU_MAIW = "" ;
         AV31Context = new SdtContext(context);
         scmdbuf = "" ;
         H005B2_A31W53POS = new short[1] ;
         H005B2_A32W53DES = new String[] {""} ;
         H005B3_A33TTBUS7_Pos = new short[1] ;
         H005B3_A35TTBUS7_CodResp = new String[] {""} ;
         H005B3_A36TTBUS7_DesResp = new String[] {""} ;
         H005B3_n36TTBUS7_DesResp = new bool[] {false} ;
         AV17error = "" ;
         H005B4_A33TTBUS7_Pos = new short[1] ;
         H005B4_A35TTBUS7_CodResp = new String[] {""} ;
         AV33usuarios_permisos = "" ;
         H005B5_A33TTBUS7_Pos = new short[1] ;
         H005B5_A199TTBUS7_DesUsuario = new String[] {""} ;
         H005B5_n199TTBUS7_DesUsuario = new bool[] {false} ;
         H005B5_A39TTBUS7_CodUsuario = new String[] {""} ;
         A199TTBUS7_DesUsuario = "" ;
         H005B6_A6USU_COD = new String[] {""} ;
         H005B6_A7USU_DES = new String[] {""} ;
         H005B6_A155USU_CLA = new String[] {""} ;
         H005B6_A180USU_INT = new String[] {""} ;
         H005B6_n180USU_INT = new bool[] {false} ;
         H005B6_A249USU_MAIW = new String[] {""} ;
         H005B6_n249USU_MAIW = new bool[] {false} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         A155USU_CLA = "" ;
         A180USU_INT = "" ;
         A249USU_MAIW = "" ;
         H005B7_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         H005B8_A35TTBUS7_CodResp = new String[] {""} ;
         H005B8_A33TTBUS7_Pos = new short[1] ;
         H005B9_A39TTBUS7_CodUsuario = new String[] {""} ;
         H005B9_A33TTBUS7_Pos = new short[1] ;
         H005B9_A51TTBUS7_RespAux = new short[1] ;
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
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbusseg0__default(),
            new Object[][] {
                new Object[] {
               H005B2_A31W53POS, H005B2_A32W53DES
               }
               , new Object[] {
               H005B3_A33TTBUS7_Pos, H005B3_A35TTBUS7_CodResp, H005B3_A36TTBUS7_DesResp, H005B3_n36TTBUS7_DesResp
               }
               , new Object[] {
               H005B4_A33TTBUS7_Pos, H005B4_A35TTBUS7_CodResp
               }
               , new Object[] {
               H005B5_A33TTBUS7_Pos, H005B5_A199TTBUS7_DesUsuario, H005B5_n199TTBUS7_DesUsuario, H005B5_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               H005B6_A6USU_COD, H005B6_A7USU_DES, H005B6_A155USU_CLA, H005B6_A180USU_INT, H005B6_n180USU_INT, H005B6_A249USU_MAIW, H005B6_n249USU_MAIW
               }
               , new Object[] {
               H005B7_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               H005B8_A35TTBUS7_CodResp, H005B8_A33TTBUS7_Pos
               }
               , new Object[] {
               H005B9_A39TTBUS7_CodUsuario, H005B9_A33TTBUS7_Pos, H005B9_A51TTBUS7_RespAux
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavW53pos_Enabled = 0 ;
         edtavW53des_Enabled = 0 ;
         edtavUsu_resp_cod_Enabled = 0 ;
         edtavUsu_resp_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_50_idx=1 ;
      private short A51TTBUS7_RespAux ;
      private short A33TTBUS7_Pos ;
      private short A31W53POS ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short AV11W53POS ;
      private short AV9Responsable ;
      private short AV14Permiso ;
      private short AV15RespAux ;
      private short nDonePA ;
      private short AV8Administrador ;
      private short AV22TTBUS7_Pos ;
      private short AV24resp ;
      private short AV25perm ;
      private short AV26resp_aux ;
      private short AV16ok ;
      private short nGXsfl_50_fel_idx=1 ;
      private short AV32encuentra_permisos ;
      private short AV44GXLvl259 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int edtavW53pos_Enabled ;
      private int edtavW53des_Enabled ;
      private int edtavUsu_resp_cod_Enabled ;
      private int edtavUsu_resp_Enabled ;
      private int subGrid1_Islastpage ;
      private int edtavUsu_cod_Enabled ;
      private int edtavUsu_des_Enabled ;
      private int edtavUsu_cla_Enabled ;
      private int edtavUsu_int_Enabled ;
      private int edtavUsu_maiw_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavW53pos_Visible ;
      private int edtavW53des_Visible ;
      private int edtavUsu_resp_cod_Visible ;
      private int edtavUsu_resp_Visible ;
      private String AV21pUSU_COD ;
      private String AV20Modo ;
      private String AV18SISTEMA ;
      private String AV19USUARIO ;
      private String wcpOAV21pUSU_COD ;
      private String wcpOAV20Modo ;
      private String wcpOAV18SISTEMA ;
      private String wcpOAV19USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_50_idx="0001" ;
      private String chkavRespaux_Internalname ;
      private String chkavPermiso_Internalname ;
      private String chkavResponsable_Internalname ;
      private String edtavW53pos_Internalname ;
      private String edtavW53des_Internalname ;
      private String edtavUsu_resp_cod_Internalname ;
      private String edtavUsu_resp_Internalname ;
      private String chkavAdministrador_Internalname ;
      private String GXCCtl ;
      private String A39TTBUS7_CodUsuario ;
      private String A36TTBUS7_DesResp ;
      private String A35TTBUS7_CodResp ;
      private String A32W53DES ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV12W53DES ;
      private String AV28Usu_resp_cod ;
      private String AV27Usu_Resp ;
      private String edtavUsu_cod_Internalname ;
      private String AV5USU_COD ;
      private String AV6USU_DES ;
      private String edtavUsu_des_Internalname ;
      private String AV7USU_CLA ;
      private String edtavUsu_cla_Internalname ;
      private String AV29USU_INT ;
      private String edtavUsu_int_Internalname ;
      private String edtavUsu_maiw_Internalname ;
      private String scmdbuf ;
      private String AV17error ;
      private String sGXsfl_50_fel_idx="0001" ;
      private String A199TTBUS7_DesUsuario ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String A155USU_CLA ;
      private String A180USU_INT ;
      private String A40TTBUS8_CodUsuario ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String grpGroupdata2_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
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
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtavUsu_int_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String ROClassString ;
      private String edtavW53pos_Jsonclick ;
      private String edtavW53des_Jsonclick ;
      private String edtavUsu_resp_cod_Jsonclick ;
      private String edtavUsu_resp_Jsonclick ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool n36TTBUS7_DesResp ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool n199TTBUS7_DesUsuario ;
      private bool n180USU_INT ;
      private bool n249USU_MAIW ;
      private String AV30USU_MAIW ;
      private String AV33usuarios_permisos ;
      private String A249USU_MAIW ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_pUSU_COD ;
      private String aP1_Modo ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private GXCheckbox chkavAdministrador ;
      private GXCheckbox chkavResponsable ;
      private GXCheckbox chkavPermiso ;
      private GXCheckbox chkavRespaux ;
      private IDataStoreProvider pr_default ;
      private short[] H005B2_A31W53POS ;
      private String[] H005B2_A32W53DES ;
      private short[] H005B3_A33TTBUS7_Pos ;
      private String[] H005B3_A35TTBUS7_CodResp ;
      private String[] H005B3_A36TTBUS7_DesResp ;
      private bool[] H005B3_n36TTBUS7_DesResp ;
      private short[] H005B4_A33TTBUS7_Pos ;
      private String[] H005B4_A35TTBUS7_CodResp ;
      private short[] H005B5_A33TTBUS7_Pos ;
      private String[] H005B5_A199TTBUS7_DesUsuario ;
      private bool[] H005B5_n199TTBUS7_DesUsuario ;
      private String[] H005B5_A39TTBUS7_CodUsuario ;
      private String[] H005B6_A6USU_COD ;
      private String[] H005B6_A7USU_DES ;
      private String[] H005B6_A155USU_CLA ;
      private String[] H005B6_A180USU_INT ;
      private bool[] H005B6_n180USU_INT ;
      private String[] H005B6_A249USU_MAIW ;
      private bool[] H005B6_n249USU_MAIW ;
      private String[] H005B7_A40TTBUS8_CodUsuario ;
      private String[] H005B8_A35TTBUS7_CodResp ;
      private short[] H005B8_A33TTBUS7_Pos ;
      private String[] H005B9_A39TTBUS7_CodUsuario ;
      private short[] H005B9_A33TTBUS7_Pos ;
      private short[] H005B9_A51TTBUS7_RespAux ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtContext AV31Context ;
   }

   public class htbusseg0__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH005B2 ;
          prmH005B2 = new Object[] {
          } ;
          Object[] prmH005B3 ;
          prmH005B3 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH005B4 ;
          prmH005B4 = new Object[] {
          new Object[] {"@AV11W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV5USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH005B5 ;
          prmH005B5 = new Object[] {
          new Object[] {"@AV11W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH005B6 ;
          prmH005B6 = new Object[] {
          new Object[] {"@AV21pUSU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH005B7 ;
          prmH005B7 = new Object[] {
          new Object[] {"@AV21pUSU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH005B8 ;
          prmH005B8 = new Object[] {
          new Object[] {"@AV22TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV21pUSU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH005B9 ;
          prmH005B9 = new Object[] {
          new Object[] {"@AV22TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV21pUSU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005B2", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B2,100,0,true,false )
             ,new CursorDef("H005B3", "SELECT T1.[TTBUS7_Pos], T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @W53POS ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B3,1,0,false,true )
             ,new CursorDef("H005B4", "SELECT [TTBUS7_Pos], [TTBUS7_CodResp] AS TTBUS7_CodResp FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV11W53POS and [TTBUS7_CodResp] = @AV5USU_COD ORDER BY [TTBUS7_Pos], [TTBUS7_CodResp] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B4,100,0,false,false )
             ,new CursorDef("H005B5", "SELECT T1.[TTBUS7_Pos], T2.[USU_DES] AS TTBUS7_DesUsuario, T1.[TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM ([TTBUS007Permisos] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodUsuario]) WHERE T1.[TTBUS7_Pos] = @AV11W53POS ORDER BY T1.[TTBUS7_Pos], T1.[TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B5,100,0,false,false )
             ,new CursorDef("H005B6", "SELECT [USU_COD], [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV21pUSU_COD ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B6,1,0,false,true )
             ,new CursorDef("H005B7", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV21pUSU_COD ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B7,1,0,false,true )
             ,new CursorDef("H005B8", "SELECT [TTBUS7_CodResp] AS TTBUS7_CodResp, [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE ([TTBUS7_Pos] = @AV22TTBUS7_Pos) AND ([TTBUS7_CodResp] = @AV21pUSU_COD) ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B8,1,0,false,true )
             ,new CursorDef("H005B9", "SELECT [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario, [TTBUS7_Pos], [TTBUS7_RespAux] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV22TTBUS7_Pos and [TTBUS7_CodUsuario] = @AV21pUSU_COD ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B9,1,0,false,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 16) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 10) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
