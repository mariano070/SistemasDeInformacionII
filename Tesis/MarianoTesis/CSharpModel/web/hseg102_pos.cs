/*
               File: HSEG102_POS
        Description: Posiciones de Usuario
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:56.19
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
   public class hseg102_pos : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public hseg102_pos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg102_pos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USU_COD ,
                           ref String aP1_SISTEMA ,
                           ref String aP2_USUARIO )
      {
         this.AV7USU_COD = aP0_USU_COD;
         this.AV8SISTEMA = aP1_SISTEMA;
         this.AV9USUARIO = aP2_USUARIO;
         executePrivate();
         aP0_USU_COD=this.AV7USU_COD;
         aP1_SISTEMA=this.AV8SISTEMA;
         aP2_USUARIO=this.AV9USUARIO;
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
         chkavResponsable = new GXCheckbox();
         chkavPermiso = new GXCheckbox();
         chkavResp_aux = new GXCheckbox();
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
                  AV7USU_COD = GetNextPar( ) ;
                  AV8SISTEMA = GetNextPar( ) ;
                  AV9USUARIO = GetNextPar( ) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV7USU_COD,(String)AV8SISTEMA,(String)AV9USUARIO});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
                  nGXsfl_5_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  sGXsfl_5_idx = GetNextPar( ) ;
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxnrGrid1_newrow( nRC_Grid1, nGXsfl_5_idx, sGXsfl_5_idx, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
               {
                  /* GeneXus formulas. */
                  context.Gx_err = 0 ;
                  edtavW53pos_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavW53pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53pos_Enabled), 5, 0)));
                  edtavW53des_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavW53des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53des_Enabled), 5, 0)));
                  chkavResponsable.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResponsable.Enabled), 5, 0)));
                  chkavPermiso.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavPermiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavPermiso.Enabled), 5, 0)));
                  chkavResp_aux.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResp_aux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResp_aux.Enabled), 5, 0)));
                  GXCCtl = "vRESPONSABLE_" + sGXsfl_5_idx ;
                  chkavResponsable.Name = GXCCtl ;
                  chkavResponsable.WebTags = "" ;
                  chkavResponsable.Caption = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResponsable_Internalname, "Caption", chkavResponsable.Caption);
                  chkavResponsable.CheckedValue = "0" ;
                  GXCCtl = "vPERMISO_" + sGXsfl_5_idx ;
                  chkavPermiso.Name = GXCCtl ;
                  chkavPermiso.WebTags = "" ;
                  chkavPermiso.Caption = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavPermiso_Internalname, "Caption", chkavPermiso.Caption);
                  chkavPermiso.CheckedValue = "0" ;
                  GXCCtl = "vRESP_AUX_" + sGXsfl_5_idx ;
                  chkavResp_aux.Name = GXCCtl ;
                  chkavResp_aux.WebTags = "" ;
                  chkavResp_aux.Caption = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResp_aux_Internalname, "Caption", chkavResp_aux.Caption);
                  chkavResp_aux.CheckedValue = "0" ;
                  A31W53POS = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
                  A51TTBUS7_RespAux = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
                  A39TTBUS7_CodUsuario = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
                  A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A32W53DES = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32W53DES", A32W53DES);
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxgrGrid1_refresh( A31W53POS, A51TTBUS7_RespAux, A39TTBUS7_CodUsuario, A33TTBUS7_Pos, A32W53DES, sPrefix) ;
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
            PA5F2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavW53pos_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavW53pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53pos_Enabled), 5, 0)));
               edtavW53des_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavW53des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53des_Enabled), 5, 0)));
               chkavResponsable.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResponsable.Enabled), 5, 0)));
               chkavPermiso.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavPermiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavPermiso.Enabled), 5, 0)));
               chkavResp_aux.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResp_aux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResp_aux.Enabled), 5, 0)));
               WS5F2( ) ;
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
            context.WriteHtmlText( "Posiciones de Usuario") ;
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"\""+FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg102_pos.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV7USU_COD)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO))+"\" class=\""+"Form"+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            }
         }
      }

      protected void RenderHtmlCloseForm5F2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7USU_COD", StringUtil.RTrim( wcpOAV7USU_COD));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8SISTEMA", StringUtil.RTrim( wcpOAV8SISTEMA));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV9USUARIO", StringUtil.RTrim( wcpOAV9USUARIO));
         GxWebStd.gx_hidden_field( context, sPrefix+"W53POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31W53POS), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS7_RESPAUX", StringUtil.LTrim( StringUtil.NToC( (decimal)(A51TTBUS7_RespAux), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS7_CODUSUARIO", StringUtil.RTrim( A39TTBUS7_CodUsuario));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"W53DES", StringUtil.RTrim( A32W53DES));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("hseg102_pos.js", "?19285624");
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

      protected void WB5F0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "hseg102_pos.aspx");
            }
            wb_table1_2_5F2( true) ;
         }
         else
         {
            wb_table1_2_5F2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_5F2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START5F2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "Posiciones de Usuario", 0) ;
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
               STRUP5F0( ) ;
            }
         }
      }

      protected void WS5F2( )
      {
         START5F2( ) ;
         EVT5F2( ) ;
      }

      protected void EVT5F2( )
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
                                 STRUP5F0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
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
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
                              }
                              nGXsfl_5_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0") ;
                              edtavW53pos_Internalname = sPrefix+"vW53POS_"+sGXsfl_5_idx ;
                              edtavW53des_Internalname = sPrefix+"vW53DES_"+sGXsfl_5_idx ;
                              chkavResponsable_Internalname = sPrefix+"vRESPONSABLE_"+sGXsfl_5_idx ;
                              chkavPermiso_Internalname = sPrefix+"vPERMISO_"+sGXsfl_5_idx ;
                              chkavResp_aux_Internalname = sPrefix+"vRESP_AUX_"+sGXsfl_5_idx ;
                              AV6W53POS = (short)(context.localUtil.CToN( cgiGet( edtavW53pos_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6W53POS), 3, 0)));
                              AV5W53DES = cgiGet( edtavW53des_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5W53DES", AV5W53DES);
                              AV12Responsable = (short)(((StringUtil.StrCmp(cgiGet( chkavResponsable_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12Responsable", StringUtil.Str( (decimal)(AV12Responsable), 1, 0));
                              AV13Permiso = (short)(((StringUtil.StrCmp(cgiGet( chkavPermiso_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13Permiso", StringUtil.Str( (decimal)(AV13Permiso), 1, 0));
                              AV14Resp_Aux = (short)(((StringUtil.StrCmp(cgiGet( chkavResp_aux_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14Resp_Aux", StringUtil.Str( (decimal)(AV14Resp_Aux), 1, 0));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E115F2 */
                                          E115F2 ();
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
                                       STRUP5F0( ) ;
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

      protected void WE5F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5F2( ) ;
            }
         }
      }

      protected void PA5F2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            GXCCtl = "vRESPONSABLE_" + sGXsfl_5_idx ;
            chkavResponsable.Name = GXCCtl ;
            chkavResponsable.WebTags = "" ;
            chkavResponsable.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResponsable_Internalname, "Caption", chkavResponsable.Caption);
            chkavResponsable.CheckedValue = "0" ;
            GXCCtl = "vPERMISO_" + sGXsfl_5_idx ;
            chkavPermiso.Name = GXCCtl ;
            chkavPermiso.WebTags = "" ;
            chkavPermiso.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavPermiso_Internalname, "Caption", chkavPermiso.Caption);
            chkavPermiso.CheckedValue = "0" ;
            GXCCtl = "vRESP_AUX_" + sGXsfl_5_idx ;
            chkavResp_aux.Name = GXCCtl ;
            chkavResp_aux.WebTags = "" ;
            chkavResp_aux.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResp_aux_Internalname, "Caption", chkavResp_aux.Caption);
            chkavResp_aux.CheckedValue = "0" ;
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_5_idx ,
                                       String sGXsfl_5_idx ,
                                       String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavW53pos_Internalname = sPrefix+"vW53POS_"+sGXsfl_5_idx ;
         edtavW53des_Internalname = sPrefix+"vW53DES_"+sGXsfl_5_idx ;
         chkavResponsable_Internalname = sPrefix+"vRESPONSABLE_"+sGXsfl_5_idx ;
         chkavPermiso_Internalname = sPrefix+"vPERMISO_"+sGXsfl_5_idx ;
         chkavResp_aux_Internalname = sPrefix+"vRESP_AUX_"+sGXsfl_5_idx ;
         while ( nGXsfl_5_idx <= nRC_Grid1 )
         {
            sendrow_52( ) ;
            nGXsfl_5_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_5_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_5_idx+1)) ;
            sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0") ;
            edtavW53pos_Internalname = sPrefix+"vW53POS_"+sGXsfl_5_idx ;
            edtavW53des_Internalname = sPrefix+"vW53DES_"+sGXsfl_5_idx ;
            chkavResponsable_Internalname = sPrefix+"vRESPONSABLE_"+sGXsfl_5_idx ;
            chkavPermiso_Internalname = sPrefix+"vPERMISO_"+sGXsfl_5_idx ;
            chkavResp_aux_Internalname = sPrefix+"vRESP_AUX_"+sGXsfl_5_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( short A31W53POS ,
                                        short A51TTBUS7_RespAux ,
                                        String A39TTBUS7_CodUsuario ,
                                        short A33TTBUS7_Pos ,
                                        String A32W53DES ,
                                        String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF5F2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF5F2( ) ;
         /* End function Refresh */
      }

      protected void RF5F2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 5 ;
         nGXsfl_5_idx = 1 ;
         sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0") ;
         edtavW53pos_Internalname = sPrefix+"vW53POS_"+sGXsfl_5_idx ;
         edtavW53des_Internalname = sPrefix+"vW53DES_"+sGXsfl_5_idx ;
         chkavResponsable_Internalname = sPrefix+"vRESPONSABLE_"+sGXsfl_5_idx ;
         chkavPermiso_Internalname = sPrefix+"vPERMISO_"+sGXsfl_5_idx ;
         chkavResp_aux_Internalname = sPrefix+"vRESP_AUX_"+sGXsfl_5_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavW53pos_Internalname = sPrefix+"vW53POS_"+sGXsfl_5_idx ;
            edtavW53des_Internalname = sPrefix+"vW53DES_"+sGXsfl_5_idx ;
            chkavResponsable_Internalname = sPrefix+"vRESPONSABLE_"+sGXsfl_5_idx ;
            chkavPermiso_Internalname = sPrefix+"vPERMISO_"+sGXsfl_5_idx ;
            chkavResp_aux_Internalname = sPrefix+"vRESP_AUX_"+sGXsfl_5_idx ;
            /* Execute user event: E115F2 */
            E115F2 ();
            wbEnd = 5 ;
            WB5F0( ) ;
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

      protected void STRUP5F0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavW53pos_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavW53pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53pos_Enabled), 5, 0)));
         edtavW53des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavW53des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavW53des_Enabled), 5, 0)));
         chkavResponsable.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResponsable.Enabled), 5, 0)));
         chkavPermiso.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavPermiso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavPermiso.Enabled), 5, 0)));
         chkavResp_aux.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavResp_aux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavResp_aux.Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
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
            wcpOAV7USU_COD = cgiGet( sPrefix+"wcpOAV7USU_COD") ;
            wcpOAV8SISTEMA = cgiGet( sPrefix+"wcpOAV8SISTEMA") ;
            wcpOAV9USUARIO = cgiGet( sPrefix+"wcpOAV9USUARIO") ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      private void E115F2( )
      {
         /* Grid1_Load Routine */
         /* Using cursor H005F2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A31W53POS = H005F2_A31W53POS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
            A32W53DES = H005F2_A32W53DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32W53DES", A32W53DES);
            AV10band = 0 ;
            AV12Responsable = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12Responsable", StringUtil.Str( (decimal)(AV12Responsable), 1, 0));
            AV13Permiso = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13Permiso", StringUtil.Str( (decimal)(AV13Permiso), 1, 0));
            AV14Resp_Aux = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14Resp_Aux", StringUtil.Str( (decimal)(AV14Resp_Aux), 1, 0));
            /* Using cursor H005F3 */
            pr_default.execute(1, new Object[] {A31W53POS, AV7USU_COD});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A33TTBUS7_Pos = H005F3_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A35TTBUS7_CodResp = H005F3_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               AV12Responsable = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12Responsable", StringUtil.Str( (decimal)(AV12Responsable), 1, 0));
               AV10band = 1 ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            /* Using cursor H005F4 */
            pr_default.execute(2, new Object[] {A31W53POS, AV7USU_COD});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A33TTBUS7_Pos = H005F4_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A39TTBUS7_CodUsuario = H005F4_A39TTBUS7_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
               A51TTBUS7_RespAux = H005F4_A51TTBUS7_RespAux[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
               AV13Permiso = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13Permiso", StringUtil.Str( (decimal)(AV13Permiso), 1, 0));
               if ( A51TTBUS7_RespAux == 1 )
               {
                  AV14Resp_Aux = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14Resp_Aux", StringUtil.Str( (decimal)(AV14Resp_Aux), 1, 0));
               }
               AV10band = 1 ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            if ( AV10band == 1 )
            {
               AV6W53POS = A31W53POS ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6W53POS), 3, 0)));
               AV5W53DES = StringUtil.Trim( A32W53DES) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV5W53DES", AV5W53DES);
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 5 ;
               }
               sendrow_52( ) ;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void wb_table1_2_5F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(36), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(278), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cód. Pos.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
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
               Grid1Container.AddObjectProperty("CmpContext", sPrefix);
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6W53POS), 3, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavW53pos_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV5W53DES));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavW53des_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Responsable), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavResponsable.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Permiso), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavPermiso.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14Resp_Aux), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavResp_aux.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 5 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_5_idx-1) ;
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
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_5F2e( true) ;
         }
         else
         {
            wb_table1_2_5F2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7USU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7USU_COD", AV7USU_COD);
         AV8SISTEMA = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SISTEMA", AV8SISTEMA);
         AV9USUARIO = (String)getParm(obj,2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9USUARIO", AV9USUARIO);
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
         PA5F2( ) ;
         WS5F2( ) ;
         WE5F2( ) ;
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
         sCtrlAV7USU_COD = (String)((String)getParm(obj,0)) ;
         sCtrlAV8SISTEMA = (String)((String)getParm(obj,1)) ;
         sCtrlAV9USUARIO = (String)((String)getParm(obj,2)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA5F2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "hseg102_pos");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA5F2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV7USU_COD = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7USU_COD", AV7USU_COD);
            AV8SISTEMA = (String)getParm(obj,3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SISTEMA", AV8SISTEMA);
            AV9USUARIO = (String)getParm(obj,4) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9USUARIO", AV9USUARIO);
         }
         wcpOAV7USU_COD = cgiGet( sPrefix+"wcpOAV7USU_COD") ;
         wcpOAV8SISTEMA = cgiGet( sPrefix+"wcpOAV8SISTEMA") ;
         wcpOAV9USUARIO = cgiGet( sPrefix+"wcpOAV9USUARIO") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV7USU_COD, wcpOAV7USU_COD) != 0 ) || ( StringUtil.StrCmp(AV8SISTEMA, wcpOAV8SISTEMA) != 0 ) || ( StringUtil.StrCmp(AV9USUARIO, wcpOAV9USUARIO) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV7USU_COD = AV7USU_COD ;
         wcpOAV8SISTEMA = AV8SISTEMA ;
         wcpOAV9USUARIO = AV9USUARIO ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV7USU_COD = cgiGet( sPrefix+"AV7USU_COD_CTRL") ;
         if ( StringUtil.Len( sCtrlAV7USU_COD) > 0 )
         {
            AV7USU_COD = cgiGet( sCtrlAV7USU_COD) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7USU_COD", AV7USU_COD);
         }
         else
         {
            AV7USU_COD = cgiGet( sPrefix+"AV7USU_COD_PARM") ;
         }
         sCtrlAV8SISTEMA = cgiGet( sPrefix+"AV8SISTEMA_CTRL") ;
         if ( StringUtil.Len( sCtrlAV8SISTEMA) > 0 )
         {
            AV8SISTEMA = cgiGet( sCtrlAV8SISTEMA) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SISTEMA", AV8SISTEMA);
         }
         else
         {
            AV8SISTEMA = cgiGet( sPrefix+"AV8SISTEMA_PARM") ;
         }
         sCtrlAV9USUARIO = cgiGet( sPrefix+"AV9USUARIO_CTRL") ;
         if ( StringUtil.Len( sCtrlAV9USUARIO) > 0 )
         {
            AV9USUARIO = cgiGet( sCtrlAV9USUARIO) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9USUARIO", AV9USUARIO);
         }
         else
         {
            AV9USUARIO = cgiGet( sPrefix+"AV9USUARIO_PARM") ;
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
         PA5F2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS5F2( ) ;
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
         WS5F2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7USU_COD_PARM", StringUtil.RTrim( AV7USU_COD));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7USU_COD)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7USU_COD_CTRL", StringUtil.RTrim( sCtrlAV7USU_COD));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8SISTEMA_PARM", StringUtil.RTrim( AV8SISTEMA));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8SISTEMA)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8SISTEMA_CTRL", StringUtil.RTrim( sCtrlAV8SISTEMA));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV9USUARIO_PARM", StringUtil.RTrim( AV9USUARIO));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV9USUARIO)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV9USUARIO_CTRL", StringUtil.RTrim( sCtrlAV9USUARIO));
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
         WE5F2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19285649");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("hseg102_pos.js", "?19285650");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_52( )
      {
         WB5F0( ) ;
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
            if ( ((int)(nGXsfl_5_idx) % (2)) == 0 )
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
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavW53pos_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6W53POS), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(int)edtavW53pos_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV6W53POS), "ZZ9"),(String)"",(short)0,(String)edtavW53pos_Jsonclick,(String)"",(short)5,(short)1,(short)1,(bool)false,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavW53des_Internalname,StringUtil.RTrim( AV5W53DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavW53des_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV5W53DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtavW53des_Jsonclick,(String)"",(short)5,(short)1,(short)1,(bool)false,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Check box */
         ClassString = "Attribute" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavResponsable_Internalname,StringUtil.Str( (decimal)(AV12Responsable), 1, 0),(String)"",(short)-1,chkavResponsable.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)""});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Check box */
         ClassString = "Attribute" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavPermiso_Internalname,StringUtil.Str( (decimal)(AV13Permiso), 1, 0),(String)"",(short)-1,chkavPermiso.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)""});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Check box */
         ClassString = "Attribute" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavResp_aux_Internalname,StringUtil.Str( (decimal)(AV14Resp_Aux), 1, 0),(String)"",(short)-1,chkavResp_aux.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)""});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_5_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_5_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_5_idx+1)) ;
         sGXsfl_5_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_5_idx), 4, 0)), 4, "0") ;
         edtavW53pos_Internalname = sPrefix+"vW53POS_"+sGXsfl_5_idx ;
         edtavW53des_Internalname = sPrefix+"vW53DES_"+sGXsfl_5_idx ;
         chkavResponsable_Internalname = sPrefix+"vRESPONSABLE_"+sGXsfl_5_idx ;
         chkavPermiso_Internalname = sPrefix+"vPERMISO_"+sGXsfl_5_idx ;
         chkavResp_aux_Internalname = sPrefix+"vRESP_AUX_"+sGXsfl_5_idx ;
         /* End function sendrow_52 */
      }

      protected void init_default_properties( )
      {
         tblTable1_Internalname = sPrefix+"TABLE1" ;
         Form.Internalname = sPrefix+"FORM" ;
         subGrid1_Internalname = sPrefix+"GRID1" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavW53des_Jsonclick = "" ;
         edtavW53pos_Jsonclick = "" ;
         chkavResp_aux.Enabled = 0 ;
         chkavPermiso.Enabled = 0 ;
         chkavResponsable.Enabled = 0 ;
         edtavW53des_Enabled = 0 ;
         edtavW53pos_Enabled = 0 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         chkavResp_aux.Caption = "" ;
         chkavPermiso.Caption = "" ;
         chkavResponsable.Caption = "" ;
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
         wcpOAV7USU_COD = "" ;
         wcpOAV8SISTEMA = "" ;
         wcpOAV9USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         edtavW53pos_Internalname = "" ;
         edtavW53des_Internalname = "" ;
         chkavResponsable_Internalname = "" ;
         chkavPermiso_Internalname = "" ;
         chkavResp_aux_Internalname = "" ;
         GXCCtl = "" ;
         A39TTBUS7_CodUsuario = "" ;
         A32W53DES = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV5W53DES = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H005F2_A31W53POS = new short[1] ;
         H005F2_A32W53DES = new String[] {""} ;
         H005F3_A33TTBUS7_Pos = new short[1] ;
         H005F3_A35TTBUS7_CodResp = new String[] {""} ;
         A35TTBUS7_CodResp = "" ;
         H005F4_A33TTBUS7_Pos = new short[1] ;
         H005F4_A39TTBUS7_CodUsuario = new String[] {""} ;
         H005F4_A51TTBUS7_RespAux = new short[1] ;
         sStyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char8 = "" ;
         ClassString = "" ;
         StyleString = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV7USU_COD = "" ;
         sCtrlAV8SISTEMA = "" ;
         sCtrlAV9USUARIO = "" ;
         GXt_char9 = "" ;
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char10 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hseg102_pos__default(),
            new Object[][] {
                new Object[] {
               H005F2_A31W53POS, H005F2_A32W53DES
               }
               , new Object[] {
               H005F3_A33TTBUS7_Pos, H005F3_A35TTBUS7_CodResp
               }
               , new Object[] {
               H005F4_A33TTBUS7_Pos, H005F4_A39TTBUS7_CodUsuario, H005F4_A51TTBUS7_RespAux
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavW53pos_Enabled = 0 ;
         edtavW53des_Enabled = 0 ;
         chkavResponsable.Enabled = 0 ;
         chkavPermiso.Enabled = 0 ;
         chkavResp_aux.Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_Grid1 ;
      private short nGXsfl_5_idx=1 ;
      private short A31W53POS ;
      private short A51TTBUS7_RespAux ;
      private short A33TTBUS7_Pos ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short AV6W53POS ;
      private short AV12Responsable ;
      private short AV13Permiso ;
      private short AV14Resp_Aux ;
      private short nDonePA ;
      private short AV10band ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int edtavW53pos_Enabled ;
      private int edtavW53des_Enabled ;
      private int subGrid1_Islastpage ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String AV7USU_COD ;
      private String AV8SISTEMA ;
      private String AV9USUARIO ;
      private String wcpOAV7USU_COD ;
      private String wcpOAV8SISTEMA ;
      private String wcpOAV9USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_5_idx="0001" ;
      private String edtavW53pos_Internalname ;
      private String edtavW53des_Internalname ;
      private String chkavResponsable_Internalname ;
      private String chkavPermiso_Internalname ;
      private String chkavResp_aux_Internalname ;
      private String GXCCtl ;
      private String A39TTBUS7_CodUsuario ;
      private String A32W53DES ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV5W53DES ;
      private String scmdbuf ;
      private String A35TTBUS7_CodResp ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char8 ;
      private String ClassString ;
      private String StyleString ;
      private String sCtrlAV7USU_COD ;
      private String sCtrlAV8SISTEMA ;
      private String sCtrlAV9USUARIO ;
      private String GXt_char9 ;
      private String ROClassString ;
      private String edtavW53pos_Jsonclick ;
      private String edtavW53des_Jsonclick ;
      private String GXt_char10 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private String aP0_USU_COD ;
      private String aP1_SISTEMA ;
      private String aP2_USUARIO ;
      private GXCheckbox chkavResponsable ;
      private GXCheckbox chkavPermiso ;
      private GXCheckbox chkavResp_aux ;
      private IDataStoreProvider pr_default ;
      private short[] H005F2_A31W53POS ;
      private String[] H005F2_A32W53DES ;
      private short[] H005F3_A33TTBUS7_Pos ;
      private String[] H005F3_A35TTBUS7_CodResp ;
      private short[] H005F4_A33TTBUS7_Pos ;
      private String[] H005F4_A39TTBUS7_CodUsuario ;
      private short[] H005F4_A51TTBUS7_RespAux ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class hseg102_pos__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH005F2 ;
          prmH005F2 = new Object[] {
          } ;
          Object[] prmH005F3 ;
          prmH005F3 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH005F4 ;
          prmH005F4 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005F2", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005F2,100,0,true,false )
             ,new CursorDef("H005F3", "SELECT [TTBUS7_Pos], [TTBUS7_CodResp] FROM [TTBUS007] WITH (NOLOCK) WHERE ([TTBUS7_Pos] = @W53POS) AND ([TTBUS7_CodResp] = @AV7USU_COD) ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005F3,1,0,false,true )
             ,new CursorDef("H005F4", "SELECT [TTBUS7_Pos], [TTBUS7_CodUsuario], [TTBUS7_RespAux] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @W53POS and [TTBUS7_CodUsuario] = @AV7USU_COD ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005F4,1,0,false,true )
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
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
