/*
               File: HTBUS001b
        Description: Actualización de Bienes de Uso (Trazabilidad) - Bienes Dados de Baja
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 20:37:32.4
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
   public class htbus001b : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus001b( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus001b( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_SISTEMA ,
                           ref String aP1_USUARIO )
      {
         this.AV12SISTEMA = aP0_SISTEMA;
         this.AV19USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV12SISTEMA;
         aP1_USUARIO=this.AV19USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavFididentificador = new GXCombobox();
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
               GXSGATTBUS_DESCRIPCION1F0( A12TTBUS_Descripcion) ;
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
               nGXsfl_35_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_35_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_35_idx, sGXsfl_35_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               dynavFididentificador.Name = "vFIDIDENTIFICADOR" ;
               dynavFididentificador.WebTags = "" ;
               dynavFididentificador.removeAllItems();
               /* Using cursor H001F2 */
               pr_default.execute(0);
               while ( (pr_default.getStatus(0) != 101) )
               {
                  dynavFididentificador.addItem(StringUtil.Str( (decimal)(H001F2_A20TTBUS5_IdIdentificador[0]), 8, 0), H001F2_A21TTBUS5_DescIdentificador[0], 0);
                  pr_default.readNext(0);
               }
               pr_default.close(0);
               if ( ( dynavFididentificador.ItemCount > 0 ) && (0==AV29fIdIdentificador) )
               {
                  AV29fIdIdentificador = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29fIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29fIdIdentificador), 8, 0)));
               }
               cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
               cmbavTtbus7_pos.WebTags = "" ;
               if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV18TTBUS7_Pos) )
               {
                  AV18TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TTBUS7_Pos), 3, 0)));
               }
               GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_35_idx ;
               chkTTBUS_Alquilado.Name = GXCCtl ;
               chkTTBUS_Alquilado.WebTags = "" ;
               chkTTBUS_Alquilado.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
               chkTTBUS_Alquilado.CheckedValue = "0" ;
               GXCCtl = "TTBUS_ESTADO_" + sGXsfl_35_idx ;
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
               Grid1_PageSize35 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV29fIdIdentificador = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29fIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29fIdIdentificador), 8, 0)));
               AV30fNumeroIdentificador = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30fNumeroIdentificador", AV30fNumeroIdentificador);
               AV15TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS_Id), 8, 0)));
               AV18TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TTBUS7_Pos), 3, 0)));
               AV19USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19USUARIO", AV19USUARIO);
               AV12SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SISTEMA", AV12SISTEMA);
               AV10SEC_CRE = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize35, AV29fIdIdentificador, AV30fNumeroIdentificador, AV15TTBUS_Id, AV18TTBUS7_Pos, AV19USUARIO, AV12SISTEMA, AV10SEC_CRE) ;
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
               AV12SISTEMA = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SISTEMA", AV12SISTEMA);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
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
         PA1F2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1F2( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus001b.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV19USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vFIDIDENTIFICADOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29fIdIdentificador), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vFNUMEROIDENTIFICADOR", StringUtil.RTrim( AV30fNumeroIdentificador));
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TTBUS7_Pos), 3, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV19USUARIO));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV12SISTEMA));
         GxWebStd.gx_hidden_field( context, "vSEC_CRE", StringUtil.RTrim( AV10SEC_CRE));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         if ( ! ( WebComp_Wc_bajasconfirmarrechazar == null ) )
         {
            WebComp_Wc_bajasconfirmarrechazar.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE1F2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1F2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS001b" ;
      }

      public override String GetPgmdesc( )
      {
         return "Actualización de Bienes de Uso (Trazabilidad) - Bienes Dados de Baja" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus001b.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV19USUARIO)) ;
      }

      protected void WB1F0( )
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
            wb_table1_2_1F2( true) ;
         }
         else
         {
            wb_table1_2_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1F2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Actualización de Bienes de Uso (Trazabilidad) - Bienes Dados de Baja", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            OldWc_bajasconfirmarrechazar = cgiGet( "W0067") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bajasconfirmarrechazar_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bajasconfirmarrechazar)) )
            {
               WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bajasconfirmarrechazar, new Object[] {context} );
               WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
               WebComp_Wc_bajasconfirmarrechazar.Name = "OldWc_bajasconfirmarrechazar";
               WebComp_Wc_bajasconfirmarrechazar_Component = OldWc_bajasconfirmarrechazar ;
               WebComp_Wc_bajasconfirmarrechazar.componentrestorestate("W0067", "");
            }
         }
         wbErr = false ;
         STRUP1F0( ) ;
      }

      protected void WS1F2( )
      {
         START1F2( ) ;
         EVT1F2( ) ;
      }

      protected void EVT1F2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vFIDIDENTIFICADOR"), ",", ".") != Convert.ToDecimal( AV29fIdIdentificador )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vFNUMEROIDENTIFICADOR"), AV30fNumeroIdentificador) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_ID"), ",", ".") != Convert.ToDecimal( AV15TTBUS_Id )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV18TTBUS7_Pos )) )
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
                              /* Execute user event: E111F2 */
                              E111F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LISTAR MOVIMIENTOS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121F2 */
                              E121F2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 20), "'LISTAR MOVIMIENTOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'BUSCAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_35_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0") ;
                              edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_35_idx ;
                              edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_35_idx ;
                              edtavNumeroidentificador_Internalname = "vNUMEROIDENTIFICADOR_"+sGXsfl_35_idx ;
                              edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_35_idx ;
                              edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_35_idx ;
                              chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_35_idx ;
                              edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_35_idx ;
                              edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_35_idx ;
                              cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_35_idx ;
                              edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_35_idx ;
                              edtTTBUS_MotivoBaja_Internalname = "TTBUS_MOTIVOBAJA_"+sGXsfl_35_idx ;
                              edtTTBUS_UsuarioBaja_Internalname = "TTBUS_USUARIOBAJA_"+sGXsfl_35_idx ;
                              edtTTBUS_MaquinaBaja_Internalname = "TTBUS_MAQUINABAJA_"+sGXsfl_35_idx ;
                              AV20visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV20visualizacion));
                              A14IdIdentificador = (int)(context.localUtil.CToN( cgiGet( edtIdIdentificador_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
                              AV31NumeroIdentificador = cgiGet( edtavNumeroidentificador_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31NumeroIdentificador", AV31NumeroIdentificador);
                              A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                              A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                              A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
                              A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
                              A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
                              cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
                              cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
                              A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
                              A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
                              n16TTBUS_FechaBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
                              A43TTBUS_MotivoBaja = StringUtil.Upper( cgiGet( edtTTBUS_MotivoBaja_Internalname)) ;
                              n43TTBUS_MotivoBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
                              A195TTBUS_UsuarioBaja = cgiGet( edtTTBUS_UsuarioBaja_Internalname) ;
                              n195TTBUS_UsuarioBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
                              A196TTBUS_MaquinaBaja = cgiGet( edtTTBUS_MaquinaBaja_Internalname) ;
                              n196TTBUS_MaquinaBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196TTBUS_MaquinaBaja", A196TTBUS_MaquinaBaja);
                              OldWc_bajasconfirmarrechazar = cgiGet( "W0067") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bajasconfirmarrechazar_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bajasconfirmarrechazar)) )
                              {
                                 WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bajasconfirmarrechazar, new Object[] {context} );
                                 WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
                                 WebComp_Wc_bajasconfirmarrechazar.Name = "OldWc_bajasconfirmarrechazar";
                                 WebComp_Wc_bajasconfirmarrechazar_Component = OldWc_bajasconfirmarrechazar ;
                                 WebComp_Wc_bajasconfirmarrechazar.componentrestorestate("W0067", "");
                              }
                              OldWc_bajasconfirmarrechazar = cgiGet( "W0067") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bajasconfirmarrechazar_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bajasconfirmarrechazar)) )
                              {
                                 WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bajasconfirmarrechazar, new Object[] {context} );
                                 WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
                                 WebComp_Wc_bajasconfirmarrechazar.Name = "OldWc_bajasconfirmarrechazar";
                                 WebComp_Wc_bajasconfirmarrechazar_Component = OldWc_bajasconfirmarrechazar ;
                                 WebComp_Wc_bajasconfirmarrechazar.componentrestorestate("W0067", "");
                              }
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E131F2 */
                                    E131F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E141F2 */
                                    E141F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'LISTAR MOVIMIENTOS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121F2 */
                                    E121F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111F2 */
                                    E111F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Fididentificador Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vFIDIDENTIFICADOR"), ",", ".") != Convert.ToDecimal( AV29fIdIdentificador )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Fnumeroidentificador Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vFNUMEROIDENTIFICADOR"), AV30fNumeroIdentificador) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ttbus_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_ID"), ",", ".") != Convert.ToDecimal( AV15TTBUS_Id )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ttbus7_pos Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV18TTBUS7_Pos )) )
                                       {
                                          Rfr0gs = true ;
                                       }
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4) ;
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                        nCmpId = (short)(NumberUtil.Val( sEvtType, ".")) ;
                        if ( nCmpId == 67 )
                        {
                           OldWc_bajasconfirmarrechazar = cgiGet( "W0067") ;
                           if ( ( StringUtil.Len( OldWc_bajasconfirmarrechazar) == 0 ) || ( StringUtil.StrCmp(OldWc_bajasconfirmarrechazar, WebComp_Wc_bajasconfirmarrechazar_Component) != 0 ) )
                           {
                              WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bajasconfirmarrechazar, new Object[] {context} );
                              WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
                              WebComp_Wc_bajasconfirmarrechazar.Name = "OldWc_bajasconfirmarrechazar";
                              WebComp_Wc_bajasconfirmarrechazar_Component = OldWc_bajasconfirmarrechazar ;
                           }
                           if ( StringUtil.Len( WebComp_Wc_bajasconfirmarrechazar_Component) != 0 )
                           {
                              WebComp_Wc_bajasconfirmarrechazar.componentprocess("W0067", "", sEvt);
                           }
                           WebComp_Wc_bajasconfirmarrechazar_Component = OldWc_bajasconfirmarrechazar ;
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE1F2( )
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

      protected void PA1F2( )
      {
         if ( nDonePA == 0 )
         {
            dynavFididentificador.Name = "vFIDIDENTIFICADOR" ;
            dynavFididentificador.WebTags = "" ;
            dynavFididentificador.removeAllItems();
            /* Using cursor H001F3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               dynavFididentificador.addItem(StringUtil.Str( (decimal)(H001F3_A20TTBUS5_IdIdentificador[0]), 8, 0), H001F3_A21TTBUS5_DescIdentificador[0], 0);
               pr_default.readNext(1);
            }
            pr_default.close(1);
            if ( ( dynavFididentificador.ItemCount > 0 ) && (0==AV29fIdIdentificador) )
            {
               AV29fIdIdentificador = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29fIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29fIdIdentificador), 8, 0)));
            }
            cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
            cmbavTtbus7_pos.WebTags = "" ;
            if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV18TTBUS7_Pos) )
            {
               AV18TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TTBUS7_Pos), 3, 0)));
            }
            GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_35_idx ;
            chkTTBUS_Alquilado.Name = GXCCtl ;
            chkTTBUS_Alquilado.WebTags = "" ;
            chkTTBUS_Alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
            chkTTBUS_Alquilado.CheckedValue = "0" ;
            GXCCtl = "TTBUS_ESTADO_" + sGXsfl_35_idx ;
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
            GX_FocusControl = dynavFididentificador_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGATTBUS_DESCRIPCION1F0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS_DESCRIPCION_data1F0( A12TTBUS_Descripcion) ;
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

      protected void GXSGATTBUS_DESCRIPCION_data1F0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H001F4 */
         pr_default.execute(2, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001F4_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001F4_A12TTBUS_Descripcion[0]));
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_35_idx ,
                                       String sGXsfl_35_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_35_idx ;
         edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_35_idx ;
         edtavNumeroidentificador_Internalname = "vNUMEROIDENTIFICADOR_"+sGXsfl_35_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_35_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_35_idx ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_35_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_35_idx ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_35_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_35_idx ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_35_idx ;
         edtTTBUS_MotivoBaja_Internalname = "TTBUS_MOTIVOBAJA_"+sGXsfl_35_idx ;
         edtTTBUS_UsuarioBaja_Internalname = "TTBUS_USUARIOBAJA_"+sGXsfl_35_idx ;
         edtTTBUS_MaquinaBaja_Internalname = "TTBUS_MAQUINABAJA_"+sGXsfl_35_idx ;
         while ( nGXsfl_35_idx <= nRC_Grid1 )
         {
            sendrow_352( ) ;
            nGXsfl_35_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_35_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_35_idx+1)) ;
            sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_35_idx ;
            edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_35_idx ;
            edtavNumeroidentificador_Internalname = "vNUMEROIDENTIFICADOR_"+sGXsfl_35_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_35_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_35_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_35_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_35_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_35_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_35_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_35_idx ;
            edtTTBUS_MotivoBaja_Internalname = "TTBUS_MOTIVOBAJA_"+sGXsfl_35_idx ;
            edtTTBUS_UsuarioBaja_Internalname = "TTBUS_USUARIOBAJA_"+sGXsfl_35_idx ;
            edtTTBUS_MaquinaBaja_Internalname = "TTBUS_MAQUINABAJA_"+sGXsfl_35_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize35 ,
                                        int AV29fIdIdentificador ,
                                        String AV30fNumeroIdentificador ,
                                        int AV15TTBUS_Id ,
                                        short AV18TTBUS7_Pos ,
                                        String AV19USUARIO ,
                                        String AV12SISTEMA ,
                                        String AV10SEC_CRE )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize35) ;
         RF1F2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1F2( ) ;
         /* End function Refresh */
      }

      protected void RF1F2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 35 ;
         nGXsfl_35_idx = 1 ;
         sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0") ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_35_idx ;
         edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_35_idx ;
         edtavNumeroidentificador_Internalname = "vNUMEROIDENTIFICADOR_"+sGXsfl_35_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_35_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_35_idx ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_35_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_35_idx ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_35_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_35_idx ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_35_idx ;
         edtTTBUS_MotivoBaja_Internalname = "TTBUS_MOTIVOBAJA_"+sGXsfl_35_idx ;
         edtTTBUS_UsuarioBaja_Internalname = "TTBUS_USUARIOBAJA_"+sGXsfl_35_idx ;
         edtTTBUS_MaquinaBaja_Internalname = "TTBUS_MAQUINABAJA_"+sGXsfl_35_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( StringUtil.StrCmp(WebComp_Wc_bajasconfirmarrechazar_Component, "") == 0 )
            {
               WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", "htbus003_b", new Object[] {context} );
               WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
               WebComp_Wc_bajasconfirmarrechazar.Name = "HTBUS003_b";
               WebComp_Wc_bajasconfirmarrechazar_Component = "HTBUS003_b" ;
            }
            if ( ( StringUtil.StrCmp(OldWc_bajasconfirmarrechazar, WebComp_Wc_bajasconfirmarrechazar_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wc_bajasconfirmarrechazar_Component, "HTBUS003_b") == 0 ) )
            {
               WebComp_Wc_bajasconfirmarrechazar.setjustcreated();
            }
            if ( ( StringUtil.Len( WebComp_Wc_bajasconfirmarrechazar_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wc_bajasconfirmarrechazar_Component, "HTBUS003_b") == 0 ) )
            {
               WebComp_Wc_bajasconfirmarrechazar.componentprepare(new Object[] {(String)"W0067",(String)"",(String)AV19USUARIO,(String)AV12SISTEMA});
               WebComp_Wc_bajasconfirmarrechazar.componentbind(new Object[] {(String)"",(String)""});
            }
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Wc_bajasconfirmarrechazar_Component) != 0 )
               {
                  WebComp_Wc_bajasconfirmarrechazar.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_35_idx ;
            edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_35_idx ;
            edtavNumeroidentificador_Internalname = "vNUMEROIDENTIFICADOR_"+sGXsfl_35_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_35_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_35_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_35_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_35_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_35_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_35_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_35_idx ;
            edtTTBUS_MotivoBaja_Internalname = "TTBUS_MOTIVOBAJA_"+sGXsfl_35_idx ;
            edtTTBUS_UsuarioBaja_Internalname = "TTBUS_USUARIOBAJA_"+sGXsfl_35_idx ;
            edtTTBUS_MaquinaBaja_Internalname = "TTBUS_MAQUINABAJA_"+sGXsfl_35_idx ;
            pr_default.dynParam(3, new Object[]{ new Object[]{
                                                 AV18TTBUS7_Pos ,
                                                 AV30fNumeroIdentificador ,
                                                 A37TTBUS_CodPosicion ,
                                                 A15NumeroIdentificador ,
                                                 AV31NumeroIdentificador ,
                                                 A16TTBUS_FechaBaja ,
                                                 A23TTBUS_Estado ,
                                                 AV15TTBUS_Id ,
                                                 AV29fIdIdentificador },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.INT, TypeConstants.INT
                                                 }
            });
            lV31NumeroIdentificador = StringUtil.PadR( StringUtil.RTrim( AV31NumeroIdentificador), 80, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31NumeroIdentificador", AV31NumeroIdentificador);
            /* Using cursor H001F5 */
            pr_default.execute(3, new Object[] {AV15TTBUS_Id, AV29fIdIdentificador, AV18TTBUS7_Pos, lV31NumeroIdentificador});
            nGXsfl_35_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(3) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A15NumeroIdentificador = H001F5_A15NumeroIdentificador[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
               A37TTBUS_CodPosicion = H001F5_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A196TTBUS_MaquinaBaja = H001F5_A196TTBUS_MaquinaBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196TTBUS_MaquinaBaja", A196TTBUS_MaquinaBaja);
               n196TTBUS_MaquinaBaja = H001F5_n196TTBUS_MaquinaBaja[0] ;
               A195TTBUS_UsuarioBaja = H001F5_A195TTBUS_UsuarioBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
               n195TTBUS_UsuarioBaja = H001F5_n195TTBUS_UsuarioBaja[0] ;
               A43TTBUS_MotivoBaja = H001F5_A43TTBUS_MotivoBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
               n43TTBUS_MotivoBaja = H001F5_n43TTBUS_MotivoBaja[0] ;
               A16TTBUS_FechaBaja = H001F5_A16TTBUS_FechaBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               n16TTBUS_FechaBaja = H001F5_n16TTBUS_FechaBaja[0] ;
               A23TTBUS_Estado = H001F5_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A38TTBUS_DesPosicion = H001F5_A38TTBUS_DesPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               A13TTBUS_FechaCarga = H001F5_A13TTBUS_FechaCarga[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A29TTBUS_Alquilado = H001F5_A29TTBUS_Alquilado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A12TTBUS_Descripcion = H001F5_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A11TTBUS_Id = H001F5_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A14IdIdentificador = H001F5_A14IdIdentificador[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
               A37TTBUS_CodPosicion = H001F5_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A196TTBUS_MaquinaBaja = H001F5_A196TTBUS_MaquinaBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196TTBUS_MaquinaBaja", A196TTBUS_MaquinaBaja);
               n196TTBUS_MaquinaBaja = H001F5_n196TTBUS_MaquinaBaja[0] ;
               A195TTBUS_UsuarioBaja = H001F5_A195TTBUS_UsuarioBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
               n195TTBUS_UsuarioBaja = H001F5_n195TTBUS_UsuarioBaja[0] ;
               A43TTBUS_MotivoBaja = H001F5_A43TTBUS_MotivoBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
               n43TTBUS_MotivoBaja = H001F5_n43TTBUS_MotivoBaja[0] ;
               A16TTBUS_FechaBaja = H001F5_A16TTBUS_FechaBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               n16TTBUS_FechaBaja = H001F5_n16TTBUS_FechaBaja[0] ;
               A23TTBUS_Estado = H001F5_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A38TTBUS_DesPosicion = H001F5_A38TTBUS_DesPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               A13TTBUS_FechaCarga = H001F5_A13TTBUS_FechaCarga[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A29TTBUS_Alquilado = H001F5_A29TTBUS_Alquilado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A12TTBUS_Descripcion = H001F5_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               /* Execute user event: E141F2 */
               E141F2 ();
               pr_default.readNext(3);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(3) == 101) ? 1 : 0)) ;
            pr_default.close(3);
            wbEnd = 35 ;
            WB1F0( ) ;
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
         pr_default.dynParam(4, new Object[]{ new Object[]{
                                              AV18TTBUS7_Pos ,
                                              AV30fNumeroIdentificador ,
                                              A37TTBUS_CodPosicion ,
                                              A15NumeroIdentificador ,
                                              AV31NumeroIdentificador ,
                                              A16TTBUS_FechaBaja ,
                                              A23TTBUS_Estado ,
                                              AV15TTBUS_Id ,
                                              AV29fIdIdentificador },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.INT, TypeConstants.INT
                                              }
         });
         lV31NumeroIdentificador = StringUtil.PadR( StringUtil.RTrim( AV31NumeroIdentificador), 80, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31NumeroIdentificador", AV31NumeroIdentificador);
         /* Using cursor H001F6 */
         pr_default.execute(4, new Object[] {AV15TTBUS_Id, AV29fIdIdentificador, AV18TTBUS7_Pos, lV31NumeroIdentificador});
         GRID1_nRecordCount = H001F6_AGRID1_nRecordCount[0] ;
         pr_default.close(4);
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

      protected void STRUP1F0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E131F2 */
         E131F2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            dynavFididentificador.Name = dynavFididentificador_Internalname ;
            dynavFididentificador.CurrentValue = cgiGet( dynavFididentificador_Internalname) ;
            AV29fIdIdentificador = (int)(NumberUtil.Val( cgiGet( dynavFididentificador_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29fIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29fIdIdentificador), 8, 0)));
            AV30fNumeroIdentificador = cgiGet( edtavFnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30fNumeroIdentificador", AV30fNumeroIdentificador);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavTtbus_id_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vTTBUS_ID");
               GX_FocusControl = edtavTtbus_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV15TTBUS_Id = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS_Id), 8, 0)));
            }
            else
            {
               AV15TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS_Id), 8, 0)));
            }
            cmbavTtbus7_pos.Name = cmbavTtbus7_pos_Internalname ;
            cmbavTtbus7_pos.CurrentValue = cgiGet( cmbavTtbus7_pos_Internalname) ;
            AV18TTBUS7_Pos = (short)(NumberUtil.Val( cgiGet( cmbavTtbus7_pos_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TTBUS7_Pos), 3, 0)));
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV19USUARIO = cgiGet( "vUSUARIO") ;
            AV12SISTEMA = cgiGet( "vSISTEMA") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            OldWc_bajasconfirmarrechazar = cgiGet( "W0067") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bajasconfirmarrechazar_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bajasconfirmarrechazar)) )
            {
               WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bajasconfirmarrechazar, new Object[] {context} );
               WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
               WebComp_Wc_bajasconfirmarrechazar.Name = "OldWc_bajasconfirmarrechazar";
               WebComp_Wc_bajasconfirmarrechazar_Component = OldWc_bajasconfirmarrechazar ;
               WebComp_Wc_bajasconfirmarrechazar.componentrestorestate("W0067", "");
            }
            /* Read subfile selected row values. */
            nGXsfl_35_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_35_idx ;
            edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_35_idx ;
            edtavNumeroidentificador_Internalname = "vNUMEROIDENTIFICADOR_"+sGXsfl_35_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_35_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_35_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_35_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_35_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_35_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_35_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_35_idx ;
            edtTTBUS_MotivoBaja_Internalname = "TTBUS_MOTIVOBAJA_"+sGXsfl_35_idx ;
            edtTTBUS_UsuarioBaja_Internalname = "TTBUS_USUARIOBAJA_"+sGXsfl_35_idx ;
            edtTTBUS_MaquinaBaja_Internalname = "TTBUS_MAQUINABAJA_"+sGXsfl_35_idx ;
            if ( nGXsfl_35_idx > 0 )
            {
               AV20visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
               A14IdIdentificador = (int)(context.localUtil.CToN( cgiGet( edtIdIdentificador_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
               AV31NumeroIdentificador = cgiGet( edtavNumeroidentificador_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31NumeroIdentificador", AV31NumeroIdentificador);
               A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
               cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
               A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
               n16TTBUS_FechaBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               A43TTBUS_MotivoBaja = StringUtil.Upper( cgiGet( edtTTBUS_MotivoBaja_Internalname)) ;
               n43TTBUS_MotivoBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
               A195TTBUS_UsuarioBaja = cgiGet( edtTTBUS_UsuarioBaja_Internalname) ;
               n195TTBUS_UsuarioBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
               A196TTBUS_MaquinaBaja = cgiGet( edtTTBUS_MaquinaBaja_Internalname) ;
               n196TTBUS_MaquinaBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196TTBUS_MaquinaBaja", A196TTBUS_MaquinaBaja);
               OldWc_bajasconfirmarrechazar = cgiGet( "W0067") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bajasconfirmarrechazar_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bajasconfirmarrechazar)) )
               {
                  WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bajasconfirmarrechazar, new Object[] {context} );
                  WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
                  WebComp_Wc_bajasconfirmarrechazar.Name = "OldWc_bajasconfirmarrechazar";
                  WebComp_Wc_bajasconfirmarrechazar_Component = OldWc_bajasconfirmarrechazar ;
                  WebComp_Wc_bajasconfirmarrechazar.componentrestorestate("W0067", "");
               }
               OldWc_bajasconfirmarrechazar = cgiGet( "W0067") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bajasconfirmarrechazar_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bajasconfirmarrechazar)) )
               {
                  WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bajasconfirmarrechazar, new Object[] {context} );
                  WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
                  WebComp_Wc_bajasconfirmarrechazar.Name = "OldWc_bajasconfirmarrechazar";
                  WebComp_Wc_bajasconfirmarrechazar_Component = OldWc_bajasconfirmarrechazar ;
                  WebComp_Wc_bajasconfirmarrechazar.componentrestorestate("W0067", "");
               }
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
         /* Execute user event: E131F2 */
         E131F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131F2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV25Context) ;
         AV19USUARIO = AV25Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19USUARIO", AV19USUARIO);
         new pseg102(context ).execute( ref  AV19USUARIO) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19USUARIO", AV19USUARIO);
         AV26inicio = (short)(NumberUtil.Val( AV24SESION.Get("Inicio"), ".")) ;
         if ( AV26inicio < 2 )
         {
            AV26inicio = (short)(AV26inicio+1) ;
            AV24SESION.Set("Inicio", StringUtil.Str( (decimal)(AV26inicio), 1, 0));
            context.DoAjaxRefresh();
         }
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV27band_1 == 1 )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(WebComp_Wc_bajasconfirmarrechazar_Component, "HTBUS003_b") != 0 )
            {
               WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", "htbus003_b", new Object[] {context} );
               WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
               WebComp_Wc_bajasconfirmarrechazar.Name = "HTBUS003_b";
               WebComp_Wc_bajasconfirmarrechazar_Component = "HTBUS003_b" ;
            }
            if ( StringUtil.StrCmp(OldWc_bajasconfirmarrechazar, WebComp_Wc_bajasconfirmarrechazar_Component) != 0 )
            {
               WebComp_Wc_bajasconfirmarrechazar.setjustcreated();
            }
            if ( StringUtil.Len( WebComp_Wc_bajasconfirmarrechazar_Component) != 0 )
            {
               WebComp_Wc_bajasconfirmarrechazar.componentprepare(new Object[] {(String)"W0067",(String)"",(String)AV19USUARIO,(String)AV12SISTEMA});
               WebComp_Wc_bajasconfirmarrechazar.componentbind(new Object[] {(String)"",(String)""});
            }
            tblTbl_bajaspendientes_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTbl_bajaspendientes_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTbl_bajaspendientes_Visible), 5, 0)));
         }
         else
         {
            tblTbl_bajaspendientes_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTbl_bajaspendientes_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTbl_bajaspendientes_Visible), 5, 0)));
         }
         /* Execute user subroutine: S122 */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E141F2( )
      {
         /* Grid1_Load Routine */
         AV20visualizacion = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV20visualizacion));
         edtavVisualizacion_Link = formatLink("ttbus000.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim(AV10SEC_CRE)) + "," + UrlEncode("" +A23TTBUS_Estado) + "," + UrlEncode("" +3) + "," + UrlEncode(StringUtil.RTrim(AV12SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV19USUARIO)) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Link", edtavVisualizacion_Link);
         edtavVisualizacion_Linktarget = "_blank" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Linktarget", edtavVisualizacion_Linktarget);
         new ptbus009(context ).execute(  A11TTBUS_Id,  1, out  AV31NumeroIdentificador) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31NumeroIdentificador", AV31NumeroIdentificador);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 35 ;
         }
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_352( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void E121F2( )
      {
         /* 'Listar Movimientos' Routine */
         GXt_char3 = "PDF" ;
         new prep000(context ).execute( ref  AV23NOMBRE_REPORTE, ref  GXt_char3) ;
         context.wjLoc = formatLink("aptbus012.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV23NOMBRE_REPORTE)) + "," + UrlEncode(StringUtil.RTrim(AV19USUARIO)) + "," + UrlEncode("" +A11TTBUS_Id) ;
      }

      protected void S122( )
      {
         /* 'CARGA POSICIONES' Routine */
         AV6band = 0 ;
         /* Using cursor H001F7 */
         pr_default.execute(5, new Object[] {AV19USUARIO});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A40TTBUS8_CodUsuario = H001F7_A40TTBUS8_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
            AV6band = 1 ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(5);
         if ( ( ( AV6band == 1 ) ) || ( ( StringUtil.StrCmp(AV19USUARIO, "SUPERVISOR") == 0 ) ) )
         {
            cmbavTtbus7_pos.addItem(" -1", "TODAS", 0);
            /* Using cursor H001F8 */
            pr_default.execute(6);
            while ( (pr_default.getStatus(6) != 101) )
            {
               A31W53POS = H001F8_A31W53POS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               A32W53DES = H001F8_A32W53DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
               /* Using cursor H001F9 */
               pr_default.execute(7, new Object[] {A31W53POS});
               while ( (pr_default.getStatus(7) != 101) )
               {
                  A33TTBUS7_Pos = H001F9_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A34TTBUS7_Des = H001F9_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001F9_n34TTBUS7_Des[0] ;
                  A34TTBUS7_Des = H001F9_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001F9_n34TTBUS7_Des[0] ;
                  cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(7);
               pr_default.readNext(6);
            }
            pr_default.close(6);
         }
         else
         {
            /* Using cursor H001F10 */
            pr_default.execute(8);
            while ( (pr_default.getStatus(8) != 101) )
            {
               A31W53POS = H001F10_A31W53POS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               A32W53DES = H001F10_A32W53DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
               /* Using cursor H001F11 */
               pr_default.execute(9, new Object[] {A31W53POS});
               while ( (pr_default.getStatus(9) != 101) )
               {
                  BRK1F7 = false ;
                  A33TTBUS7_Pos = H001F11_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A34TTBUS7_Des = H001F11_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001F11_n34TTBUS7_Des[0] ;
                  A35TTBUS7_CodResp = H001F11_A35TTBUS7_CodResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                  A34TTBUS7_Des = H001F11_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001F11_n34TTBUS7_Des[0] ;
                  AV21vTTBUS7_Pos = A33TTBUS7_Pos ;
                  if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV19USUARIO) == 0 )
                  {
                     cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                  }
                  else
                  {
                     while ( (pr_default.getStatus(9) != 101) && ( H001F11_A33TTBUS7_Pos[0] == A33TTBUS7_Pos ) )
                     {
                        BRK1F7 = false ;
                        A34TTBUS7_Des = H001F11_A34TTBUS7_Des[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                        n34TTBUS7_Des = H001F11_n34TTBUS7_Des[0] ;
                        A35TTBUS7_CodResp = H001F11_A35TTBUS7_CodResp[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                        A34TTBUS7_Des = H001F11_A34TTBUS7_Des[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                        n34TTBUS7_Des = H001F11_n34TTBUS7_Des[0] ;
                        /* Using cursor H001F12 */
                        pr_default.execute(10, new Object[] {A31W53POS, AV19USUARIO, AV21vTTBUS7_Pos});
                        while ( (pr_default.getStatus(10) != 101) )
                        {
                           A39TTBUS7_CodUsuario = H001F12_A39TTBUS7_CodUsuario[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
                           A33TTBUS7_Pos = H001F12_A33TTBUS7_Pos[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                           cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(10);
                        BRK1F7 = true ;
                        pr_default.readNext(9);
                     }
                  }
                  if ( ! BRK1F7 )
                  {
                     BRK1F7 = true ;
                     pr_default.readNext(9);
                  }
               }
               pr_default.close(9);
               pr_default.readNext(8);
            }
            pr_default.close(8);
         }
      }

      protected void S112( )
      {
         /* 'VALIDACION SEGURIDAD' Routine */
         AV27band_1 = 0 ;
         if ( StringUtil.StrCmp(AV19USUARIO, "SUPERVISOR") == 0 )
         {
            AV27band_1 = 1 ;
         }
         if ( AV27band_1 == 0 )
         {
            /* Using cursor H001F13 */
            pr_default.execute(11, new Object[] {AV19USUARIO});
            while ( (pr_default.getStatus(11) != 101) )
            {
               A40TTBUS8_CodUsuario = H001F13_A40TTBUS8_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
               AV27band_1 = 1 ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(11);
         }
      }

      protected void E111F2( )
      {
         /* 'Buscar' Routine */
         AV31NumeroIdentificador = "%" + StringUtil.Upper( StringUtil.Trim( AV30fNumeroIdentificador)) + "%" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31NumeroIdentificador", AV31NumeroIdentificador);
      }

      protected void wb_table1_2_1F2( bool wbgen )
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
            wb_table2_8_1F2( true) ;
         }
         else
         {
            wb_table2_8_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_1F2e( bool wbgen )
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id Identificador") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Identificador") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Alquilado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Carga") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Última Posición") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Baja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Motivo Baja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Usuario Baja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Pc que Registró la Baja") ;
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
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV20visualizacion));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavVisualizacion_Link));
               Grid1Column.AddObjectProperty("Linktarget", StringUtil.RTrim( edtavVisualizacion_Linktarget));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14IdIdentificador), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV31NumeroIdentificador));
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
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A38TTBUS_DesPosicion));
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A195TTBUS_UsuarioBaja));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A196TTBUS_MaquinaBaja));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 35 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_35_idx-1) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton1_Internalname, "Ver Movimientos del Bien", "Ver Movimientos del Bien", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton1_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151f2_client"+"'", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(35), 3, 0)+","+"null"+");", "", "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton4_Internalname, "Listar Movimientos del Bien", "Listar Movimientos del Bien", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton4_Jsonclick, "E\\'LISTAR MOVIMIENTOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(35), 3, 0)+","+"null"+");", "", "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_61_1F2( true) ;
         }
         else
         {
            wb_table3_61_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table3_61_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1F2e( true) ;
         }
         else
         {
            wb_table1_2_1F2e( false) ;
         }
      }

      protected void wb_table3_61_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTbl_bajaspendientes_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(46), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(463), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTbl_bajaspendientes_Internalname, tblTbl_bajaspendientes_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:26px\">") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Bajas a Confirmar/Rechazar", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "W0067"+"", StringUtil.RTrim( WebComp_Wc_bajasconfirmarrechazar_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpW0067"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Wc_bajasconfirmarrechazar_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldWc_bajasconfirmarrechazar, WebComp_Wc_bajasconfirmarrechazar_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0067"+"");
               }
               WebComp_Wc_bajasconfirmarrechazar.componentdraw();
               if ( StringUtil.StrCmp(OldWc_bajasconfirmarrechazar, WebComp_Wc_bajasconfirmarrechazar_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_61_1F2e( true) ;
         }
         else
         {
            wb_table3_61_1F2e( false) ;
         }
      }

      protected void wb_table2_8_1F2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Tipo Identificador:", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_35_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavFididentificador, dynavFididentificador_Internalname, StringUtil.Str( (decimal)(AV29fIdIdentificador), 8, 0), "", "int", 1, 1, 0, 1, 0, 60, "chr", 0, "", StyleString, ClassString, "", 0, dynavFididentificador_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(13);\"", true, "HLP_HTBUS001b.htm");
            dynavFididentificador.CurrentValue = StringUtil.Str( (decimal)(AV29fIdIdentificador), 8, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavFididentificador_Internalname, "Values", (String)(dynavFididentificador.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "Nº Identificador:", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'" + sGXsfl_35_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFnumeroidentificador_Internalname, StringUtil.RTrim( AV30fNumeroIdentificador), "", 80, "chr", 1, "row", 80, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV30fNumeroIdentificador, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(18);\"", 0, edtavFnumeroidentificador_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:17px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Nº Bien:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_35_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15TTBUS_Id), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV15TTBUS_Id), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(23);\"", 0, edtavTtbus_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Posición:", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_35_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavTtbus7_pos, cmbavTtbus7_pos_Internalname, StringUtil.Str( (decimal)(AV18TTBUS7_Pos), 3, 0), "", "int", 1, 1, 0, 1, 0, 3, "chr", 0, "", StyleString, ClassString, "", 0, cmbavTtbus7_pos_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(28);\"", true, "HLP_HTBUS001b.htm");
            cmbavTtbus7_pos.CurrentValue = StringUtil.Str( (decimal)(AV18TTBUS7_Pos), 3, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTtbus7_pos_Internalname, "Values", (String)(cmbavTtbus7_pos.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td colspan=\"4\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton3_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton3_Jsonclick, "E\\'BUSCAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(35), 3, 0)+","+"null"+");", "", "HLP_HTBUS001b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_1F2e( true) ;
         }
         else
         {
            wb_table2_8_1F2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SISTEMA", AV12SISTEMA);
         AV19USUARIO = (String)getParm(obj,1) ;
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
         PA1F2( ) ;
         WS1F2( ) ;
         WE1F2( ) ;
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
         if ( StringUtil.StrCmp(WebComp_Wc_bajasconfirmarrechazar_Component, "") == 0 )
         {
            WebComp_Wc_bajasconfirmarrechazar = getWebComponent(GetType(), "GeneXus.Programs", "htbus003_b", new Object[] {context} );
            WebComp_Wc_bajasconfirmarrechazar.ComponentInit();
            WebComp_Wc_bajasconfirmarrechazar.Name = "HTBUS003_b";
            WebComp_Wc_bajasconfirmarrechazar_Component = "HTBUS003_b" ;
         }
         if ( ! ( WebComp_Wc_bajasconfirmarrechazar == null ) )
         {
            if ( StringUtil.Len( WebComp_Wc_bajasconfirmarrechazar_Component) != 0 )
            {
               WebComp_Wc_bajasconfirmarrechazar.componentthemes();
            }
         }
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?20373299");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbus001b.js", "?20373299");
         /* End function include_jscripts */
      }

      protected void sendrow_352( )
      {
         WB1F0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_35_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_35_idx) % (2)) == 0 )
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
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavVisualizacion_Internalname,(String)"",(String)AV20visualizacion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Visualización",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavVisualizacion_Link,(String)edtavVisualizacion_Linktarget,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtIdIdentificador_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A14IdIdentificador), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A14IdIdentificador), "ZZZZZZZ9"),(String)"",(short)0,(String)edtIdIdentificador_Jsonclick,(String)"",(short)35,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavNumeroidentificador_Internalname,StringUtil.RTrim( AV31NumeroIdentificador),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)80,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV31NumeroIdentificador, "")),(String)"",(short)0,(String)edtavNumeroidentificador_Jsonclick,(String)"",(short)35,(short)1,(short)-1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_Id_Jsonclick,(String)"",(short)35,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Descripcion_Internalname,StringUtil.RTrim( A12TTBUS_Descripcion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")),(String)"",(short)0,(String)edtTTBUS_Descripcion_Jsonclick,(String)"",(short)35,(short)1,(short)0,(bool)true,(String)"left"});
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaCarga_Internalname,context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaCarga_Jsonclick,(String)"",(short)35,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesPosicion_Internalname,StringUtil.RTrim( A38TTBUS_DesPosicion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesPosicion_Jsonclick,(String)"",(short)35,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            GXCCtl = "TTBUS_ESTADO_" + sGXsfl_35_idx ;
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
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTTBUS_Estado,(String)cmbTTBUS_Estado_Internalname,StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)1,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbTTBUS_Estado_Jsonclick,(String)"",(String)"",(bool)true});
            cmbTTBUS_Estado.CurrentValue = StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS_Estado_Internalname, "Values", (String)(cmbTTBUS_Estado.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaBaja_Internalname,context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaBaja_Jsonclick,(String)"",(short)35,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_MotivoBaja_Internalname,StringUtil.RTrim( A43TTBUS_MotivoBaja),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A43TTBUS_MotivoBaja, "@!")),(String)"",(short)0,(String)edtTTBUS_MotivoBaja_Jsonclick,(String)"",(short)35,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_UsuarioBaja_Internalname,StringUtil.RTrim( A195TTBUS_UsuarioBaja),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A195TTBUS_UsuarioBaja, "XXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_UsuarioBaja_Jsonclick,(String)"",(short)35,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_MaquinaBaja_Internalname,StringUtil.RTrim( A196TTBUS_MaquinaBaja),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A196TTBUS_MaquinaBaja, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_MaquinaBaja_Jsonclick,(String)"",(short)35,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_35_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_35_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_35_idx+1)) ;
            sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_35_idx ;
            edtIdIdentificador_Internalname = "IDIDENTIFICADOR_"+sGXsfl_35_idx ;
            edtavNumeroidentificador_Internalname = "vNUMEROIDENTIFICADOR_"+sGXsfl_35_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_35_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_35_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_35_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_35_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_35_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_35_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_35_idx ;
            edtTTBUS_MotivoBaja_Internalname = "TTBUS_MOTIVOBAJA_"+sGXsfl_35_idx ;
            edtTTBUS_UsuarioBaja_Internalname = "TTBUS_USUARIOBAJA_"+sGXsfl_35_idx ;
            edtTTBUS_MaquinaBaja_Internalname = "TTBUS_MAQUINABAJA_"+sGXsfl_35_idx ;
         }
         /* End function sendrow_352 */
      }

      protected void init_default_properties( )
      {
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         dynavFididentificador_Internalname = "vFIDIDENTIFICADOR" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavFnumeroidentificador_Internalname = "vFNUMEROIDENTIFICADOR" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavTtbus_id_Internalname = "vTTBUS_ID" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         cmbavTtbus7_pos_Internalname = "vTTBUS7_POS" ;
         bttButton3_Internalname = "BUTTON3" ;
         tblTable3_Internalname = "TABLE3" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton4_Internalname = "BUTTON4" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         tblTbl_bajaspendientes_Internalname = "TBL_BAJASPENDIENTES" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtTTBUS_MaquinaBaja_Jsonclick = "" ;
         edtTTBUS_UsuarioBaja_Jsonclick = "" ;
         edtTTBUS_MotivoBaja_Jsonclick = "" ;
         edtTTBUS_FechaBaja_Jsonclick = "" ;
         cmbTTBUS_Estado_Jsonclick = "" ;
         edtTTBUS_DesPosicion_Jsonclick = "" ;
         edtTTBUS_FechaCarga_Jsonclick = "" ;
         edtTTBUS_Descripcion_Jsonclick = "" ;
         edtTTBUS_Id_Jsonclick = "" ;
         edtavNumeroidentificador_Jsonclick = "" ;
         edtIdIdentificador_Jsonclick = "" ;
         cmbavTtbus7_pos_Jsonclick = "" ;
         edtavTtbus_id_Jsonclick = "" ;
         edtavFnumeroidentificador_Jsonclick = "" ;
         dynavFididentificador_Jsonclick = "" ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         edtavVisualizacion_Linktarget = "" ;
         edtavVisualizacion_Link = "" ;
         tblTbl_bajaspendientes_Visible = 1 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Actualización de Bienes de Uso (Trazabilidad) - Bienes Dados de Baja" ;
         chkTTBUS_Alquilado.Caption = "" ;
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
         wcpOAV12SISTEMA = "" ;
         wcpOAV19USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A12TTBUS_Descripcion = "" ;
         scmdbuf = "" ;
         H001F2_A20TTBUS5_IdIdentificador = new int[1] ;
         H001F2_A21TTBUS5_DescIdentificador = new String[] {""} ;
         GXCCtl = "" ;
         chkTTBUS_Alquilado_Internalname = "" ;
         AV30fNumeroIdentificador = "" ;
         AV10SEC_CRE = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         OldWc_bajasconfirmarrechazar = "" ;
         WebComp_Wc_bajasconfirmarrechazar_Component = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavVisualizacion_Internalname = "" ;
         edtIdIdentificador_Internalname = "" ;
         edtavNumeroidentificador_Internalname = "" ;
         edtTTBUS_Id_Internalname = "" ;
         edtTTBUS_Descripcion_Internalname = "" ;
         edtTTBUS_FechaCarga_Internalname = "" ;
         edtTTBUS_DesPosicion_Internalname = "" ;
         cmbTTBUS_Estado_Internalname = "" ;
         edtTTBUS_FechaBaja_Internalname = "" ;
         edtTTBUS_MotivoBaja_Internalname = "" ;
         edtTTBUS_UsuarioBaja_Internalname = "" ;
         edtTTBUS_MaquinaBaja_Internalname = "" ;
         AV20visualizacion = "" ;
         AV31NumeroIdentificador = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A38TTBUS_DesPosicion = "" ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         A43TTBUS_MotivoBaja = "" ;
         A195TTBUS_UsuarioBaja = "" ;
         A196TTBUS_MaquinaBaja = "" ;
         H001F3_A20TTBUS5_IdIdentificador = new int[1] ;
         H001F3_A21TTBUS5_DescIdentificador = new String[] {""} ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         l12TTBUS_Descripcion = "" ;
         H001F4_A12TTBUS_Descripcion = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         A15NumeroIdentificador = "" ;
         lV31NumeroIdentificador = "" ;
         H001F5_A15NumeroIdentificador = new String[] {""} ;
         H001F5_A37TTBUS_CodPosicion = new short[1] ;
         H001F5_A196TTBUS_MaquinaBaja = new String[] {""} ;
         H001F5_n196TTBUS_MaquinaBaja = new bool[] {false} ;
         H001F5_A195TTBUS_UsuarioBaja = new String[] {""} ;
         H001F5_n195TTBUS_UsuarioBaja = new bool[] {false} ;
         H001F5_A43TTBUS_MotivoBaja = new String[] {""} ;
         H001F5_n43TTBUS_MotivoBaja = new bool[] {false} ;
         H001F5_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         H001F5_n16TTBUS_FechaBaja = new bool[] {false} ;
         H001F5_A23TTBUS_Estado = new short[1] ;
         H001F5_A38TTBUS_DesPosicion = new String[] {""} ;
         H001F5_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         H001F5_A29TTBUS_Alquilado = new short[1] ;
         H001F5_A12TTBUS_Descripcion = new String[] {""} ;
         H001F5_A11TTBUS_Id = new int[1] ;
         H001F5_A14IdIdentificador = new int[1] ;
         H001F6_AGRID1_nRecordCount = new int[1] ;
         AV25Context = new SdtContext(context);
         AV24SESION = new GxWebSession( context);
         AV23NOMBRE_REPORTE = "" ;
         H001F7_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         H001F8_A31W53POS = new short[1] ;
         H001F8_A32W53DES = new String[] {""} ;
         A32W53DES = "" ;
         H001F9_A33TTBUS7_Pos = new short[1] ;
         H001F9_A34TTBUS7_Des = new String[] {""} ;
         H001F9_n34TTBUS7_Des = new bool[] {false} ;
         A34TTBUS7_Des = "" ;
         H001F10_A31W53POS = new short[1] ;
         H001F10_A32W53DES = new String[] {""} ;
         H001F11_A33TTBUS7_Pos = new short[1] ;
         H001F11_A34TTBUS7_Des = new String[] {""} ;
         H001F11_n34TTBUS7_Des = new bool[] {false} ;
         H001F11_A35TTBUS7_CodResp = new String[] {""} ;
         A35TTBUS7_CodResp = "" ;
         H001F12_A39TTBUS7_CodUsuario = new String[] {""} ;
         H001F12_A33TTBUS7_Pos = new short[1] ;
         A39TTBUS7_CodUsuario = "" ;
         H001F13_A40TTBUS8_CodUsuario = new String[] {""} ;
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
         Grid1Column = new GXWebColumn();
         GXt_char12 = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         GXt_char13 = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char14 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus001b__default(),
            new Object[][] {
                new Object[] {
               H001F2_A20TTBUS5_IdIdentificador, H001F2_A21TTBUS5_DescIdentificador
               }
               , new Object[] {
               H001F3_A20TTBUS5_IdIdentificador, H001F3_A21TTBUS5_DescIdentificador
               }
               , new Object[] {
               H001F4_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001F5_A15NumeroIdentificador, H001F5_A37TTBUS_CodPosicion, H001F5_A196TTBUS_MaquinaBaja, H001F5_n196TTBUS_MaquinaBaja, H001F5_A195TTBUS_UsuarioBaja, H001F5_n195TTBUS_UsuarioBaja, H001F5_A43TTBUS_MotivoBaja, H001F5_n43TTBUS_MotivoBaja, H001F5_A16TTBUS_FechaBaja, H001F5_n16TTBUS_FechaBaja,
               H001F5_A23TTBUS_Estado, H001F5_A38TTBUS_DesPosicion, H001F5_A13TTBUS_FechaCarga, H001F5_A29TTBUS_Alquilado, H001F5_A12TTBUS_Descripcion, H001F5_A11TTBUS_Id, H001F5_A14IdIdentificador
               }
               , new Object[] {
               H001F6_AGRID1_nRecordCount
               }
               , new Object[] {
               H001F7_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               H001F8_A31W53POS, H001F8_A32W53DES
               }
               , new Object[] {
               H001F9_A33TTBUS7_Pos, H001F9_A34TTBUS7_Des, H001F9_n34TTBUS7_Des
               }
               , new Object[] {
               H001F10_A31W53POS, H001F10_A32W53DES
               }
               , new Object[] {
               H001F11_A33TTBUS7_Pos, H001F11_A34TTBUS7_Des, H001F11_n34TTBUS7_Des, H001F11_A35TTBUS7_CodResp
               }
               , new Object[] {
               H001F12_A39TTBUS7_CodUsuario, H001F12_A33TTBUS7_Pos
               }
               , new Object[] {
               H001F13_A40TTBUS8_CodUsuario
               }
            }
         );
         WebComp_Wc_bajasconfirmarrechazar = new GeneXus.Http.GXNullWebComponent();
         AV29fIdIdentificador = 1 ;
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_35_idx=1 ;
      private short AV18TTBUS7_Pos ;
      private short A23TTBUS_Estado ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A29TTBUS_Alquilado ;
      private short nCmpId ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short A37TTBUS_CodPosicion ;
      private short AV26inicio ;
      private short AV27band_1 ;
      private short AV6band ;
      private short A31W53POS ;
      private short A33TTBUS7_Pos ;
      private short AV21vTTBUS7_Pos ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize35 ;
      private int AV29fIdIdentificador ;
      private int AV15TTBUS_Id ;
      private int GRID1_nFirstRecordOnPage ;
      private int A14IdIdentificador ;
      private int A11TTBUS_Id ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int tblTbl_bajaspendientes_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String AV12SISTEMA ;
      private String AV19USUARIO ;
      private String wcpOAV12SISTEMA ;
      private String wcpOAV19USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_35_idx="0001" ;
      private String scmdbuf ;
      private String GXCCtl ;
      private String chkTTBUS_Alquilado_Internalname ;
      private String AV10SEC_CRE ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String OldWc_bajasconfirmarrechazar ;
      private String WebComp_Wc_bajasconfirmarrechazar_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavVisualizacion_Internalname ;
      private String edtIdIdentificador_Internalname ;
      private String edtavNumeroidentificador_Internalname ;
      private String edtTTBUS_Id_Internalname ;
      private String edtTTBUS_Descripcion_Internalname ;
      private String edtTTBUS_FechaCarga_Internalname ;
      private String edtTTBUS_DesPosicion_Internalname ;
      private String cmbTTBUS_Estado_Internalname ;
      private String edtTTBUS_FechaBaja_Internalname ;
      private String edtTTBUS_MotivoBaja_Internalname ;
      private String edtTTBUS_UsuarioBaja_Internalname ;
      private String edtTTBUS_MaquinaBaja_Internalname ;
      private String A38TTBUS_DesPosicion ;
      private String A195TTBUS_UsuarioBaja ;
      private String A196TTBUS_MaquinaBaja ;
      private String dynavFididentificador_Internalname ;
      private String gxwrpcisep ;
      private String edtavFnumeroidentificador_Internalname ;
      private String edtavTtbus_id_Internalname ;
      private String cmbavTtbus7_pos_Internalname ;
      private String subGrid1_Internalname ;
      private String tblTbl_bajaspendientes_Internalname ;
      private String edtavVisualizacion_Link ;
      private String edtavVisualizacion_Linktarget ;
      private String AV23NOMBRE_REPORTE ;
      private String A40TTBUS8_CodUsuario ;
      private String A32W53DES ;
      private String A34TTBUS7_Des ;
      private String A35TTBUS7_CodResp ;
      private String A39TTBUS7_CodUsuario ;
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
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String GXt_char13 ;
      private String tblTable3_Internalname ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String dynavFididentificador_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavFnumeroidentificador_Jsonclick ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavTtbus_id_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String cmbavTtbus7_pos_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String ROClassString ;
      private String edtIdIdentificador_Jsonclick ;
      private String edtavNumeroidentificador_Jsonclick ;
      private String edtTTBUS_Id_Jsonclick ;
      private String edtTTBUS_Descripcion_Jsonclick ;
      private String edtTTBUS_FechaCarga_Jsonclick ;
      private String edtTTBUS_DesPosicion_Jsonclick ;
      private String cmbTTBUS_Estado_Jsonclick ;
      private String edtTTBUS_FechaBaja_Jsonclick ;
      private String edtTTBUS_MotivoBaja_Jsonclick ;
      private String edtTTBUS_UsuarioBaja_Jsonclick ;
      private String edtTTBUS_MaquinaBaja_Jsonclick ;
      private String GXt_char14 ;
      private DateTime A13TTBUS_FechaCarga ;
      private DateTime A16TTBUS_FechaBaja ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n16TTBUS_FechaBaja ;
      private bool n43TTBUS_MotivoBaja ;
      private bool n195TTBUS_UsuarioBaja ;
      private bool n196TTBUS_MaquinaBaja ;
      private bool returnInSub ;
      private bool n34TTBUS7_Des ;
      private bool BRK1F7 ;
      private String A12TTBUS_Descripcion ;
      private String AV30fNumeroIdentificador ;
      private String AV31NumeroIdentificador ;
      private String A43TTBUS_MotivoBaja ;
      private String l12TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String lV31NumeroIdentificador ;
      private String AV20visualizacion ;
      private GxWebSession AV24SESION ;
      private GXWebComponent WebComp_Wc_bajasconfirmarrechazar ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private GXCombobox dynavFididentificador ;
      private GXCombobox cmbavTtbus7_pos ;
      private GXCheckbox chkTTBUS_Alquilado ;
      private GXCombobox cmbTTBUS_Estado ;
      private IDataStoreProvider pr_default ;
      private int[] H001F2_A20TTBUS5_IdIdentificador ;
      private String[] H001F2_A21TTBUS5_DescIdentificador ;
      private int[] H001F3_A20TTBUS5_IdIdentificador ;
      private String[] H001F3_A21TTBUS5_DescIdentificador ;
      private String[] H001F4_A12TTBUS_Descripcion ;
      private String[] H001F5_A15NumeroIdentificador ;
      private short[] H001F5_A37TTBUS_CodPosicion ;
      private String[] H001F5_A196TTBUS_MaquinaBaja ;
      private bool[] H001F5_n196TTBUS_MaquinaBaja ;
      private String[] H001F5_A195TTBUS_UsuarioBaja ;
      private bool[] H001F5_n195TTBUS_UsuarioBaja ;
      private String[] H001F5_A43TTBUS_MotivoBaja ;
      private bool[] H001F5_n43TTBUS_MotivoBaja ;
      private DateTime[] H001F5_A16TTBUS_FechaBaja ;
      private bool[] H001F5_n16TTBUS_FechaBaja ;
      private short[] H001F5_A23TTBUS_Estado ;
      private String[] H001F5_A38TTBUS_DesPosicion ;
      private DateTime[] H001F5_A13TTBUS_FechaCarga ;
      private short[] H001F5_A29TTBUS_Alquilado ;
      private String[] H001F5_A12TTBUS_Descripcion ;
      private int[] H001F5_A11TTBUS_Id ;
      private int[] H001F5_A14IdIdentificador ;
      private int[] H001F6_AGRID1_nRecordCount ;
      private String[] H001F7_A40TTBUS8_CodUsuario ;
      private short[] H001F8_A31W53POS ;
      private String[] H001F8_A32W53DES ;
      private short[] H001F9_A33TTBUS7_Pos ;
      private String[] H001F9_A34TTBUS7_Des ;
      private bool[] H001F9_n34TTBUS7_Des ;
      private short[] H001F10_A31W53POS ;
      private String[] H001F10_A32W53DES ;
      private short[] H001F11_A33TTBUS7_Pos ;
      private String[] H001F11_A34TTBUS7_Des ;
      private bool[] H001F11_n34TTBUS7_Des ;
      private String[] H001F11_A35TTBUS7_CodResp ;
      private String[] H001F12_A39TTBUS7_CodUsuario ;
      private short[] H001F12_A33TTBUS7_Pos ;
      private String[] H001F13_A40TTBUS8_CodUsuario ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtContext AV25Context ;
   }

   public class htbus001b__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001F5( short AV18TTBUS7_Pos ,
                                             String AV30fNumeroIdentificador ,
                                             short A37TTBUS_CodPosicion ,
                                             String A15NumeroIdentificador ,
                                             String AV31NumeroIdentificador ,
                                             DateTime A16TTBUS_FechaBaja ,
                                             short A23TTBUS_Estado ,
                                             int AV15TTBUS_Id ,
                                             int AV29fIdIdentificador )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int15 ;
         GXv_int15 = new short [4] ;
         Object[] GXv_Object16 ;
         GXv_Object16 = new Object [2] ;
         scmdbuf = "SELECT T1.[NumeroIdentificador], T2.[TTBUS_CodPosicion], T2.[TTBUS_MaquinaBaja], T2.[TTBUS_UsuarioBaja], T2.[TTBUS_MotivoBaja], T2.[TTBUS_FechaBaja], T2.[TTBUS_Estado], T2.[TTBUS_DesPosicion], T2.[TTBUS_FechaCarga], T2.[TTBUS_Alquilado], T2.[TTBUS_Descripcion], T1.[TTBUS_Id], T1.[IdIdentificador] FROM ([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS_Id] >= @AV15TTBUS_Id and T1.[IdIdentificador] = @AV29fIdIdentificador)" ;
         scmdbuf = scmdbuf + " and (Not (T2.[TTBUS_FechaBaja] = convert( DATETIME, '17530101', 112 )))" ;
         scmdbuf = scmdbuf + " and (T2.[TTBUS_Estado] = 4)" ;
         if ( AV18TTBUS7_Pos != -1 )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_CodPosicion] = @AV18TTBUS7_Pos)" ;
         }
         else
         {
            GXv_int15[2] = 1 ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30fNumeroIdentificador)) )
         {
            sWhereString = sWhereString + " and (T1.[NumeroIdentificador] like @AV31NumeroIdentificador)" ;
         }
         else
         {
            GXv_int15[3] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 11)" ;
         GXv_Object16[0] = scmdbuf ;
         GXv_Object16[1] = (Object)(GXv_int15) ;
         return GXv_Object16 ;
      }

      protected Object[] conditional_H001F6( short AV18TTBUS7_Pos ,
                                             String AV30fNumeroIdentificador ,
                                             short A37TTBUS_CodPosicion ,
                                             String A15NumeroIdentificador ,
                                             String AV31NumeroIdentificador ,
                                             DateTime A16TTBUS_FechaBaja ,
                                             short A23TTBUS_Estado ,
                                             int AV15TTBUS_Id ,
                                             int AV29fIdIdentificador )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int17 ;
         GXv_int17 = new short [4] ;
         Object[] GXv_Object18 ;
         GXv_Object18 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS_Id] >= @AV15TTBUS_Id and T1.[IdIdentificador] = @AV29fIdIdentificador)" ;
         scmdbuf = scmdbuf + " and (Not (T2.[TTBUS_FechaBaja] = convert( DATETIME, '17530101', 112 )))" ;
         scmdbuf = scmdbuf + " and (T2.[TTBUS_Estado] = 4)" ;
         if ( AV18TTBUS7_Pos != -1 )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_CodPosicion] = @AV18TTBUS7_Pos)" ;
         }
         else
         {
            GXv_int17[2] = 1 ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30fNumeroIdentificador)) )
         {
            sWhereString = sWhereString + " and (T1.[NumeroIdentificador] like @AV31NumeroIdentificador)" ;
         }
         else
         {
            GXv_int17[3] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + "" ;
         GXv_Object18[0] = scmdbuf ;
         GXv_Object18[1] = (Object)(GXv_int17) ;
         return GXv_Object18 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 3 :
                     return conditional_H001F5( (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (short)dynConstraints[6] , (int)dynConstraints[7] , (int)dynConstraints[8] );
               case 4 :
                     return conditional_H001F6( (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] , (short)dynConstraints[6] , (int)dynConstraints[7] , (int)dynConstraints[8] );
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
          Object[] prmH001F2 ;
          prmH001F2 = new Object[] {
          } ;
          Object[] prmH001F3 ;
          prmH001F3 = new Object[] {
          } ;
          Object[] prmH001F4 ;
          prmH001F4 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH001F7 ;
          prmH001F7 = new Object[] {
          new Object[] {"@AV19USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001F8 ;
          prmH001F8 = new Object[] {
          } ;
          Object[] prmH001F9 ;
          prmH001F9 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001F10 ;
          prmH001F10 = new Object[] {
          } ;
          Object[] prmH001F11 ;
          prmH001F11 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001F12 ;
          prmH001F12 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV19USUARIO",SqlDbType.Char,16,0} ,
          new Object[] {"@AV21vTTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001F13 ;
          prmH001F13 = new Object[] {
          new Object[] {"@AV19USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001F5 ;
          prmH001F5 = new Object[] {
          new Object[] {"@AV15TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV29fIdIdentificador",SqlDbType.Int,8,0} ,
          new Object[] {"@AV18TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV31NumeroIdentificador",SqlDbType.VarChar,80,0}
          } ;
          Object[] prmH001F6 ;
          prmH001F6 = new Object[] {
          new Object[] {"@AV15TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV29fIdIdentificador",SqlDbType.Int,8,0} ,
          new Object[] {"@AV18TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV31NumeroIdentificador",SqlDbType.VarChar,80,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001F2", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) ORDER BY [TTBUS5_DescIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F2,0,0,true,false )
             ,new CursorDef("H001F3", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) ORDER BY [TTBUS5_DescIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F3,0,0,true,false )
             ,new CursorDef("H001F4", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F4,0,0,true,false )
             ,new CursorDef("H001F5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F5,11,0,true,false )
             ,new CursorDef("H001F6", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F6,1,0,true,false )
             ,new CursorDef("H001F7", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV19USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F7,1,0,true,true )
             ,new CursorDef("H001F8", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F8,100,0,true,false )
             ,new CursorDef("H001F9", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @W53POS ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F9,1,0,true,true )
             ,new CursorDef("H001F10", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F10,100,0,true,false )
             ,new CursorDef("H001F11", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_CodResp] FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @W53POS ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F11,100,0,true,false )
             ,new CursorDef("H001F12", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE ([TTBUS7_Pos] = @W53POS and [TTBUS7_CodUsuario] = @AV19USUARIO) AND ([TTBUS7_Pos] = @AV21vTTBUS7_Pos) ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F12,1,0,true,true )
             ,new CursorDef("H001F13", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV19USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F13,1,0,true,true )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 15) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((short[]) buf[10])[0] = rslt.getShort(7) ;
                ((String[]) buf[11])[0] = rslt.getString(8, 50) ;
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(9) ;
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(11) ;
                ((int[]) buf[15])[0] = rslt.getInt(12) ;
                ((int[]) buf[16])[0] = rslt.getInt(13) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 16) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
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
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                break;
             case 4 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
