/*
               File: Gx0010
        Description: Selection List Maestro de Bienes de Uso Trazabilizados
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:0.84
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
   public class gx0010 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0010( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx0010( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pTTBUS_Id )
      {
         this.AV14pTTBUS_Id = 0 ;
         executePrivate();
         aP0_pTTBUS_Id=this.AV14pTTBUS_Id;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCttbus_estado = new GXCombobox();
         chkavCttbus_alquilado = new GXCheckbox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vCTTBUS_DESCRIPCION") == 0 )
            {
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvCTTBUS_DESCRIPCION2H0( A12TTBUS_Descripcion) ;
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
               GXSGATTBUS_DESCRIPCION2H0( A12TTBUS_Descripcion) ;
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
               nGXsfl_51_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_51_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_51_idx, sGXsfl_51_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               cmbavCttbus_estado.Name = "vCTTBUS_ESTADO" ;
               cmbavCttbus_estado.WebTags = "" ;
               cmbavCttbus_estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
               cmbavCttbus_estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
               cmbavCttbus_estado.addItem("3", "BAJA A CONFIRMAR", 0);
               cmbavCttbus_estado.addItem("4", "BAJA", 0);
               if ( ( cmbavCttbus_estado.ItemCount > 0 ) && (0==AV9cTTBUS_Estado) )
               {
                  AV9cTTBUS_Estado = (short)(NumberUtil.Val( cmbavCttbus_estado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS_Estado", StringUtil.Str( (decimal)(AV9cTTBUS_Estado), 1, 0));
               }
               chkavCttbus_alquilado.Name = "vCTTBUS_ALQUILADO" ;
               chkavCttbus_alquilado.WebTags = "" ;
               chkavCttbus_alquilado.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCttbus_alquilado_Internalname, "Caption", chkavCttbus_alquilado.Caption);
               chkavCttbus_alquilado.CheckedValue = "0" ;
               GXCCtl = "TTBUS_ESTADO_" + sGXsfl_51_idx ;
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
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cTTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS_Id), 8, 0)));
               AV7cTTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS_Descripcion", AV7cTTBUS_Descripcion);
               AV8cTTBUS_FechaCarga = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS_FechaCarga", context.localUtil.Format(AV8cTTBUS_FechaCarga, "99/99/9999"));
               AV9cTTBUS_Estado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS_Estado", StringUtil.Str( (decimal)(AV9cTTBUS_Estado), 1, 0));
               AV10cTTBUS_CodProveedor = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cTTBUS_CodProveedor), 8, 0)));
               AV12cTTBUS_Alquilado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS_Alquilado", StringUtil.Str( (decimal)(AV12cTTBUS_Alquilado), 1, 0));
               AV13cTTBUS_CodPosicion = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cTTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13cTTBUS_CodPosicion), 3, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cTTBUS_Id, AV7cTTBUS_Descripcion, AV8cTTBUS_FechaCarga, AV9cTTBUS_Estado, AV10cTTBUS_CodProveedor, AV12cTTBUS_Alquilado, AV13cTTBUS_CodPosicion) ;
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
               AV14pTTBUS_Id = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS_Id), 8, 0)));
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
            MasterPageObj.setDataArea(this,true);
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
         PA2H2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2H2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx0010.aspx") + "?" + UrlEncode("" +AV14pTTBUS_Id)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS_DESCRIPCION", StringUtil.RTrim( AV7cTTBUS_Descripcion));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS_FECHACARGA", context.localUtil.Format(AV8cTTBUS_FechaCarga, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS_ESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cTTBUS_Estado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS_CODPROVEEDOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cTTBUS_CodProveedor), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS_ALQUILADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cTTBUS_Alquilado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS_CODPOSICION", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13cTTBUS_CodPosicion), 3, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pTTBUS_Id), 8, 0, ",", "")));
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
            WE2H2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2H2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx0010" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Maestro de Bienes de Uso Trazabilizados" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0010.aspx") + "?" + UrlEncode("" +AV14pTTBUS_Id) ;
      }

      protected void WB2H0( )
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
            wb_table1_2_2H2( true) ;
         }
         else
         {
            wb_table1_2_2H2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2H2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2H2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List Maestro de Bienes de Uso Trazabilizados", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2H0( ) ;
      }

      protected void WS2H2( )
      {
         START2H2( ) ;
         EVT2H2( ) ;
      }

      protected void EVT2H2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_ID"), ",", ".") != Convert.ToDecimal( AV6cTTBUS_Id )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS_DESCRIPCION"), AV7cTTBUS_Descripcion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCTTBUS_FECHACARGA"), 4) != AV8cTTBUS_FechaCarga )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_ESTADO"), ",", ".") != Convert.ToDecimal( AV9cTTBUS_Estado )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_CODPROVEEDOR"), ",", ".") != Convert.ToDecimal( AV10cTTBUS_CodProveedor )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_ALQUILADO"), ",", ".") != Convert.ToDecimal( AV12cTTBUS_Alquilado )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_CODPOSICION"), ",", ".") != Convert.ToDecimal( AV13cTTBUS_CodPosicion )) )
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
                              edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_51_idx ;
                              edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_51_idx ;
                              edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_51_idx ;
                              cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_51_idx ;
                              edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                              A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                              A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
                              cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
                              cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
                              A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
                              A27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".")) ;
                              n27TTBUS_CodProveedor = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112H2 */
                                    E112H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122H2 */
                                    E122H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cttbus_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_ID"), ",", ".") != Convert.ToDecimal( AV6cTTBUS_Id )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus_descripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS_DESCRIPCION"), AV7cTTBUS_Descripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus_fechacarga Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCTTBUS_FECHACARGA"), 4) != AV8cTTBUS_FechaCarga )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus_estado Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_ESTADO"), ",", ".") != Convert.ToDecimal( AV9cTTBUS_Estado )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus_codproveedor Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_CODPROVEEDOR"), ",", ".") != Convert.ToDecimal( AV10cTTBUS_CodProveedor )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus_alquilado Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_ALQUILADO"), ",", ".") != Convert.ToDecimal( AV12cTTBUS_Alquilado )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus_codposicion Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS_CODPOSICION"), ",", ".") != Convert.ToDecimal( AV13cTTBUS_CodPosicion )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132H2 */
                                          E132H2 ();
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

      protected void WE2H2( )
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

      protected void PA2H2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCttbus_estado.Name = "vCTTBUS_ESTADO" ;
            cmbavCttbus_estado.WebTags = "" ;
            cmbavCttbus_estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
            cmbavCttbus_estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
            cmbavCttbus_estado.addItem("3", "BAJA A CONFIRMAR", 0);
            cmbavCttbus_estado.addItem("4", "BAJA", 0);
            if ( ( cmbavCttbus_estado.ItemCount > 0 ) && (0==AV9cTTBUS_Estado) )
            {
               AV9cTTBUS_Estado = (short)(NumberUtil.Val( cmbavCttbus_estado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS_Estado", StringUtil.Str( (decimal)(AV9cTTBUS_Estado), 1, 0));
            }
            chkavCttbus_alquilado.Name = "vCTTBUS_ALQUILADO" ;
            chkavCttbus_alquilado.WebTags = "" ;
            chkavCttbus_alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCttbus_alquilado_Internalname, "Caption", chkavCttbus_alquilado.Caption);
            chkavCttbus_alquilado.CheckedValue = "0" ;
            GXCCtl = "TTBUS_ESTADO_" + sGXsfl_51_idx ;
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
            GX_FocusControl = edtavCttbus_id_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGVvCTTBUS_DESCRIPCION2H0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvCTTBUS_DESCRIPCION_data2H0( A12TTBUS_Descripcion) ;
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

      protected void GXSGVvCTTBUS_DESCRIPCION_data2H0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H002H2 */
         pr_default.execute(0, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H002H2_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002H2_A12TTBUS_Descripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXSGATTBUS_DESCRIPCION2H0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS_DESCRIPCION_data2H0( A12TTBUS_Descripcion) ;
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

      protected void GXSGATTBUS_DESCRIPCION_data2H0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H002H3 */
         pr_default.execute(1, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H002H3_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002H3_A12TTBUS_Descripcion[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_51_idx ,
                                       String sGXsfl_51_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_51_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_51_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_51_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_51_idx ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_51_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_51_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_51_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_51_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        int AV6cTTBUS_Id ,
                                        String AV7cTTBUS_Descripcion ,
                                        DateTime AV8cTTBUS_FechaCarga ,
                                        short AV9cTTBUS_Estado ,
                                        int AV10cTTBUS_CodProveedor ,
                                        short AV12cTTBUS_Alquilado ,
                                        short AV13cTTBUS_CodPosicion )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF2H2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2H2( ) ;
         /* End function Refresh */
      }

      protected void RF2H2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_51_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_51_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_51_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_51_idx ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_51_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_51_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_51_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_51_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_51_idx ;
            lV7cTTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV7cTTBUS_Descripcion), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS_Descripcion", AV7cTTBUS_Descripcion);
            /* Using cursor H002H4 */
            pr_default.execute(2, new Object[] {AV6cTTBUS_Id, lV7cTTBUS_Descripcion, AV8cTTBUS_FechaCarga, AV9cTTBUS_Estado, AV10cTTBUS_CodProveedor, AV12cTTBUS_Alquilado, AV13cTTBUS_CodPosicion});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(2) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A29TTBUS_Alquilado = H002H4_A29TTBUS_Alquilado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A37TTBUS_CodPosicion = H002H4_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A27TTBUS_CodProveedor = H002H4_A27TTBUS_CodProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               n27TTBUS_CodProveedor = H002H4_n27TTBUS_CodProveedor[0] ;
               A23TTBUS_Estado = H002H4_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A13TTBUS_FechaCarga = H002H4_A13TTBUS_FechaCarga[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A12TTBUS_Descripcion = H002H4_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A11TTBUS_Id = H002H4_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               /* Execute user event: E122H2 */
               E122H2 ();
               pr_default.readNext(2);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(2) == 101) ? 1 : 0)) ;
            pr_default.close(2);
            wbEnd = 51 ;
            WB2H0( ) ;
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
         lV7cTTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV7cTTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS_Descripcion", AV7cTTBUS_Descripcion);
         /* Using cursor H002H5 */
         pr_default.execute(3, new Object[] {AV6cTTBUS_Id, lV7cTTBUS_Descripcion, AV8cTTBUS_FechaCarga, AV9cTTBUS_Estado, AV10cTTBUS_CodProveedor, AV12cTTBUS_Alquilado, AV13cTTBUS_CodPosicion});
         GRID1_nRecordCount = H002H5_AGRID1_nRecordCount[0] ;
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

      protected void STRUP2H0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112H2 */
         E112H2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus_id_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus_id_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS_ID");
               GX_FocusControl = edtavCttbus_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cTTBUS_Id = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS_Id), 8, 0)));
            }
            else
            {
               AV6cTTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtavCttbus_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTTBUS_Id), 8, 0)));
            }
            AV7cTTBUS_Descripcion = StringUtil.Upper( cgiGet( edtavCttbus_descripcion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS_Descripcion", AV7cTTBUS_Descripcion);
            if ( context.localUtil.VCDate( cgiGet( edtavCttbus_fechacarga_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha de Carga"}), 1, "vCTTBUS_FECHACARGA");
               GX_FocusControl = edtavCttbus_fechacarga_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cTTBUS_FechaCarga = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS_FechaCarga", context.localUtil.Format(AV8cTTBUS_FechaCarga, "99/99/9999"));
            }
            else
            {
               AV8cTTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtavCttbus_fechacarga_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS_FechaCarga", context.localUtil.Format(AV8cTTBUS_FechaCarga, "99/99/9999"));
            }
            cmbavCttbus_estado.Name = cmbavCttbus_estado_Internalname ;
            cmbavCttbus_estado.CurrentValue = cgiGet( cmbavCttbus_estado_Internalname) ;
            AV9cTTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbavCttbus_estado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS_Estado", StringUtil.Str( (decimal)(AV9cTTBUS_Estado), 1, 0));
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus_codproveedor_Internalname), "ZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus_codproveedor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus_codproveedor_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS_CODPROVEEDOR");
               GX_FocusControl = edtavCttbus_codproveedor_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cTTBUS_CodProveedor = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cTTBUS_CodProveedor), 8, 0)));
            }
            else
            {
               AV10cTTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtavCttbus_codproveedor_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cTTBUS_CodProveedor), 8, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( chkavCttbus_alquilado_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavCttbus_alquilado_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavCttbus_alquilado_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS_ALQUILADO");
               GX_FocusControl = chkavCttbus_alquilado_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12cTTBUS_Alquilado = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS_Alquilado", StringUtil.Str( (decimal)(AV12cTTBUS_Alquilado), 1, 0));
            }
            else
            {
               AV12cTTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkavCttbus_alquilado_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS_Alquilado", StringUtil.Str( (decimal)(AV12cTTBUS_Alquilado), 1, 0));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus_codposicion_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus_codposicion_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus_codposicion_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS_CODPOSICION");
               GX_FocusControl = edtavCttbus_codposicion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV13cTTBUS_CodPosicion = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cTTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13cTTBUS_CodPosicion), 3, 0)));
            }
            else
            {
               AV13cTTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtavCttbus_codposicion_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13cTTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13cTTBUS_CodPosicion), 3, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV14pTTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "vPTTBUS_ID"), ",", ".")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
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
         /* Execute user event: E112H2 */
         E112H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112H2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Maestro de Bienes de Uso Trazabilizados", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122H2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_512( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E132H2 */
         E132H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132H2( )
      {
         /* Enter Routine */
         AV14pTTBUS_Id = A11TTBUS_Id ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS_Id), 8, 0)));
         context.setWebReturnParms(new Object[] {(int)AV14pTTBUS_Id});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
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
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_2H2( true) ;
         }
         else
         {
            wb_table2_9_2H2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_48_2H2( true) ;
         }
         else
         {
            wb_table3_48_2H2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_2H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2H2e( true) ;
         }
         else
         {
            wb_table1_2_2H2e( false) ;
         }
      }

      protected void wb_table3_48_2H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
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
               context.SendWebValue( "Id del bien de uso:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha de Carga:") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "de uso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Proveedor") ;
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
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A12TTBUS_Descripcion));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTTBUS_Descripcion_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23TTBUS_Estado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 51 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_51_idx-1) ;
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_60_2H2( true) ;
         }
         else
         {
            wb_table4_60_2H2( false) ;
         }
         return  ;
      }

      protected void wb_table4_60_2H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_2H2e( true) ;
         }
         else
         {
            wb_table3_48_2H2e( false) ;
         }
      }

      protected void wb_table4_60_2H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_60_2H2e( true) ;
         }
         else
         {
            wb_table4_60_2H2e( false) ;
         }
      }

      protected void wb_table2_9_2H2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_id_Internalname, 1, 1, 0, "Id del bien de uso", "", "", "", 0, lblTextblockttbus_id_Jsonclick, "", StyleString, ClassString, "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTTBUS_Id), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cTTBUS_Id), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCttbus_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_descripcion_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblockttbus_descripcion_Jsonclick, "", StyleString, ClassString, "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus_descripcion_Internalname, StringUtil.RTrim( AV7cTTBUS_Descripcion), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7cTTBUS_Descripcion, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(19);\"", 0, edtavCttbus_descripcion_Jsonclick, "", 0, 1, 0, true, "left", "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_fechacarga_Internalname, 1, 1, 0, "Fecha de Carga", "", "", "", 0, lblTextblockttbus_fechacarga_Jsonclick, "", StyleString, ClassString, "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCttbus_fechacarga_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus_fechacarga_Internalname, context.localUtil.Format(AV8cTTBUS_FechaCarga, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV8cTTBUS_FechaCarga, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(24);\"", 0, edtavCttbus_fechacarga_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0010.htm");
            GxWebStd.gx_bitmap( context, edtavCttbus_fechacarga_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx0010.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_estado_Internalname, 1, 1, 0, "Estado de bien de uso", "", "", "", 0, lblTextblockttbus_estado_Jsonclick, "", StyleString, ClassString, "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCttbus_estado, cmbavCttbus_estado_Internalname, StringUtil.Str( (decimal)(AV9cTTBUS_Estado), 1, 0), "", "int", 1, 1, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbavCttbus_estado_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", true, "HLP_Gx0010.htm");
            cmbavCttbus_estado.CurrentValue = StringUtil.Str( (decimal)(AV9cTTBUS_Estado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCttbus_estado_Internalname, "Values", (String)(cmbavCttbus_estado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_codproveedor_Internalname, 1, 1, 0, "Cód. Proveedor", "", "", "", 0, lblTextblockttbus_codproveedor_Jsonclick, "", StyleString, ClassString, "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus_codproveedor_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cTTBUS_CodProveedor), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV10cTTBUS_CodProveedor), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(34);\"", 0, edtavCttbus_codproveedor_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_alquilado_Internalname, 1, 1, 0, "Marca Alquilado (SI/NO)", "", "", "", 0, lblTextblockttbus_alquilado_Jsonclick, "", StyleString, ClassString, "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkavCttbus_alquilado_Internalname, StringUtil.Str( (decimal)(AV12cTTBUS_Alquilado), 1, 0), "", 1, 1, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(39, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(39);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_codposicion_Internalname, 1, 1, 0, "Cod. Posición Actual Bien", "", "", "", 0, lblTextblockttbus_codposicion_Jsonclick, "", StyleString, ClassString, "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus_codposicion_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13cTTBUS_CodPosicion), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV13cTTBUS_CodPosicion), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"", 0, edtavCttbus_codposicion_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0010.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2H2e( true) ;
         }
         else
         {
            wb_table2_9_2H2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV14pTTBUS_Id = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS_Id), 8, 0)));
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
         PA2H2( ) ;
         WS2H2( ) ;
         WE2H2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1929139");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx0010.js", "?1929139");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB2H0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_51_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_51_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_Id_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtTTBUS_Descripcion_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_Descripcion_Internalname, "Link", edtTTBUS_Descripcion_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Descripcion_Internalname,StringUtil.RTrim( A12TTBUS_Descripcion),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtTTBUS_Descripcion_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")),(String)"",(short)0,(String)edtTTBUS_Descripcion_Jsonclick,(String)"",(short)51,(short)1,(short)0,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaCarga_Internalname,context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaCarga_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_51_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TTBUS_ESTADO_" + sGXsfl_51_idx ;
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
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTTBUS_Estado,(String)cmbTTBUS_Estado_Internalname,StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbTTBUS_Estado_Jsonclick,(String)"",(String)"",(bool)true});
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodProveedor_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A27TTBUS_CodProveedor), "ZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_CodProveedor_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_51_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_51_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_51_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_51_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockttbus_id_Internalname = "TEXTBLOCKTTBUS_ID" ;
         edtavCttbus_id_Internalname = "vCTTBUS_ID" ;
         lblTextblockttbus_descripcion_Internalname = "TEXTBLOCKTTBUS_DESCRIPCION" ;
         edtavCttbus_descripcion_Internalname = "vCTTBUS_DESCRIPCION" ;
         lblTextblockttbus_fechacarga_Internalname = "TEXTBLOCKTTBUS_FECHACARGA" ;
         edtavCttbus_fechacarga_Internalname = "vCTTBUS_FECHACARGA" ;
         lblTextblockttbus_estado_Internalname = "TEXTBLOCKTTBUS_ESTADO" ;
         cmbavCttbus_estado_Internalname = "vCTTBUS_ESTADO" ;
         lblTextblockttbus_codproveedor_Internalname = "TEXTBLOCKTTBUS_CODPROVEEDOR" ;
         edtavCttbus_codproveedor_Internalname = "vCTTBUS_CODPROVEEDOR" ;
         lblTextblockttbus_alquilado_Internalname = "TEXTBLOCKTTBUS_ALQUILADO" ;
         chkavCttbus_alquilado_Internalname = "vCTTBUS_ALQUILADO" ;
         lblTextblockttbus_codposicion_Internalname = "TEXTBLOCKTTBUS_CODPOSICION" ;
         edtavCttbus_codposicion_Internalname = "vCTTBUS_CODPOSICION" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtTTBUS_CodProveedor_Jsonclick = "" ;
         cmbTTBUS_Estado_Jsonclick = "" ;
         edtTTBUS_FechaCarga_Jsonclick = "" ;
         edtTTBUS_Descripcion_Jsonclick = "" ;
         edtTTBUS_Id_Jsonclick = "" ;
         edtavCttbus_codposicion_Jsonclick = "" ;
         edtavCttbus_codproveedor_Jsonclick = "" ;
         cmbavCttbus_estado_Jsonclick = "" ;
         edtavCttbus_fechacarga_Jsonclick = "" ;
         edtavCttbus_descripcion_Jsonclick = "" ;
         edtavCttbus_id_Jsonclick = "" ;
         edtTTBUS_Descripcion_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Maestro de Bienes de Uso Trazabilizados" ;
         chkavCttbus_alquilado.Caption = "" ;
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
         AV9cTTBUS_Estado = 1 ;
         GXCCtl = "" ;
         AV7cTTBUS_Descripcion = "" ;
         AV8cTTBUS_FechaCarga = DateTime.MinValue ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtTTBUS_Id_Internalname = "" ;
         edtTTBUS_Descripcion_Internalname = "" ;
         edtTTBUS_FechaCarga_Internalname = "" ;
         cmbTTBUS_Estado_Internalname = "" ;
         edtTTBUS_CodProveedor_Internalname = "" ;
         AV5LinkSelection = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l12TTBUS_Descripcion = "" ;
         H002H2_A12TTBUS_Descripcion = new String[] {""} ;
         H002H3_A12TTBUS_Descripcion = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         lV7cTTBUS_Descripcion = "" ;
         H002H4_A29TTBUS_Alquilado = new short[1] ;
         H002H4_A37TTBUS_CodPosicion = new short[1] ;
         H002H4_A27TTBUS_CodProveedor = new int[1] ;
         H002H4_n27TTBUS_CodProveedor = new bool[] {false} ;
         H002H4_A23TTBUS_Estado = new short[1] ;
         H002H4_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         H002H4_A12TTBUS_Descripcion = new String[] {""} ;
         H002H4_A11TTBUS_Id = new int[1] ;
         H002H5_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockttbus_id_Jsonclick = "" ;
         lblTextblockttbus_descripcion_Jsonclick = "" ;
         lblTextblockttbus_fechacarga_Jsonclick = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         lblTextblockttbus_estado_Jsonclick = "" ;
         lblTextblockttbus_codproveedor_Jsonclick = "" ;
         lblTextblockttbus_alquilado_Jsonclick = "" ;
         lblTextblockttbus_codposicion_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0010__default(),
            new Object[][] {
                new Object[] {
               H002H2_A12TTBUS_Descripcion
               }
               , new Object[] {
               H002H3_A12TTBUS_Descripcion
               }
               , new Object[] {
               H002H4_A29TTBUS_Alquilado, H002H4_A37TTBUS_CodPosicion, H002H4_A27TTBUS_CodProveedor, H002H4_n27TTBUS_CodProveedor, H002H4_A23TTBUS_Estado, H002H4_A13TTBUS_FechaCarga, H002H4_A12TTBUS_Descripcion, H002H4_A11TTBUS_Id
               }
               , new Object[] {
               H002H5_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_51_idx=1 ;
      private short AV9cTTBUS_Estado ;
      private short A23TTBUS_Estado ;
      private short AV12cTTBUS_Alquilado ;
      private short AV13cTTBUS_CodPosicion ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short A29TTBUS_Alquilado ;
      private short A37TTBUS_CodPosicion ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int AV6cTTBUS_Id ;
      private int AV10cTTBUS_CodProveedor ;
      private int AV14pTTBUS_Id ;
      private int GRID1_nFirstRecordOnPage ;
      private int A11TTBUS_Id ;
      private int A27TTBUS_CodProveedor ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
      private String chkavCttbus_alquilado_Internalname ;
      private String GXCCtl ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtTTBUS_Id_Internalname ;
      private String edtTTBUS_Descripcion_Internalname ;
      private String edtTTBUS_FechaCarga_Internalname ;
      private String cmbTTBUS_Estado_Internalname ;
      private String edtTTBUS_CodProveedor_Internalname ;
      private String edtavCttbus_id_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavCttbus_descripcion_Internalname ;
      private String edtavCttbus_fechacarga_Internalname ;
      private String cmbavCttbus_estado_Internalname ;
      private String edtavCttbus_codproveedor_Internalname ;
      private String edtavCttbus_codposicion_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String edtavLinkselection_Link ;
      private String edtTTBUS_Descripcion_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus_id_Internalname ;
      private String lblTextblockttbus_id_Jsonclick ;
      private String edtavCttbus_id_Jsonclick ;
      private String lblTextblockttbus_descripcion_Internalname ;
      private String lblTextblockttbus_descripcion_Jsonclick ;
      private String edtavCttbus_descripcion_Jsonclick ;
      private String lblTextblockttbus_fechacarga_Internalname ;
      private String lblTextblockttbus_fechacarga_Jsonclick ;
      private String GXt_char6 ;
      private String edtavCttbus_fechacarga_Jsonclick ;
      private String GXt_char5 ;
      private String lblTextblockttbus_estado_Internalname ;
      private String lblTextblockttbus_estado_Jsonclick ;
      private String cmbavCttbus_estado_Jsonclick ;
      private String lblTextblockttbus_codproveedor_Internalname ;
      private String lblTextblockttbus_codproveedor_Jsonclick ;
      private String edtavCttbus_codproveedor_Jsonclick ;
      private String lblTextblockttbus_alquilado_Internalname ;
      private String lblTextblockttbus_alquilado_Jsonclick ;
      private String lblTextblockttbus_codposicion_Internalname ;
      private String lblTextblockttbus_codposicion_Jsonclick ;
      private String edtavCttbus_codposicion_Jsonclick ;
      private String ROClassString ;
      private String edtTTBUS_Id_Jsonclick ;
      private String edtTTBUS_Descripcion_Jsonclick ;
      private String edtTTBUS_FechaCarga_Jsonclick ;
      private String cmbTTBUS_Estado_Jsonclick ;
      private String edtTTBUS_CodProveedor_Jsonclick ;
      private String GXt_char7 ;
      private DateTime AV8cTTBUS_FechaCarga ;
      private DateTime A13TTBUS_FechaCarga ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n27TTBUS_CodProveedor ;
      private bool returnInSub ;
      private String A12TTBUS_Descripcion ;
      private String AV7cTTBUS_Descripcion ;
      private String l12TTBUS_Descripcion ;
      private String lV7cTTBUS_Descripcion ;
      private String AV5LinkSelection ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCttbus_estado ;
      private GXCheckbox chkavCttbus_alquilado ;
      private GXCombobox cmbTTBUS_Estado ;
      private IDataStoreProvider pr_default ;
      private String[] H002H2_A12TTBUS_Descripcion ;
      private String[] H002H3_A12TTBUS_Descripcion ;
      private short[] H002H4_A29TTBUS_Alquilado ;
      private short[] H002H4_A37TTBUS_CodPosicion ;
      private int[] H002H4_A27TTBUS_CodProveedor ;
      private bool[] H002H4_n27TTBUS_CodProveedor ;
      private short[] H002H4_A23TTBUS_Estado ;
      private DateTime[] H002H4_A13TTBUS_FechaCarga ;
      private String[] H002H4_A12TTBUS_Descripcion ;
      private int[] H002H4_A11TTBUS_Id ;
      private int[] H002H5_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pTTBUS_Id ;
      private GXWebForm Form ;
   }

   public class gx0010__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002H2 ;
          prmH002H2 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH002H3 ;
          prmH002H3 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH002H4 ;
          prmH002H4 = new Object[] {
          new Object[] {"@AV6cTTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV7cTTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV8cTTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV9cTTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV10cTTBUS_CodProveedor",SqlDbType.Int,8,0} ,
          new Object[] {"@AV12cTTBUS_Alquilado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV13cTTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH002H5 ;
          prmH002H5 = new Object[] {
          new Object[] {"@AV6cTTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV7cTTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV8cTTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV9cTTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV10cTTBUS_CodProveedor",SqlDbType.Int,8,0} ,
          new Object[] {"@AV12cTTBUS_Alquilado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV13cTTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002H2", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002H2,0,0,true,false )
             ,new CursorDef("H002H3", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002H3,0,0,true,false )
             ,new CursorDef("H002H4", "SELECT [TTBUS_Alquilado], [TTBUS_CodPosicion], [TTBUS_CodProveedor], [TTBUS_Estado], [TTBUS_FechaCarga], [TTBUS_Descripcion], [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE ([TTBUS_Id] >= @AV6cTTBUS_Id) AND ([TTBUS_Descripcion] like @AV7cTTBUS_Descripcion) AND ([TTBUS_FechaCarga] >= @AV8cTTBUS_FechaCarga) AND ([TTBUS_Estado] >= @AV9cTTBUS_Estado) AND ([TTBUS_CodProveedor] >= @AV10cTTBUS_CodProveedor) AND ([TTBUS_Alquilado] >= @AV12cTTBUS_Alquilado) AND ([TTBUS_CodPosicion] >= @AV13cTTBUS_CodPosicion) ORDER BY [TTBUS_Id]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002H4,11,0,false,false )
             ,new CursorDef("H002H5", "SELECT COUNT(*) FROM [TTBUS000] WITH (NOLOCK) WHERE ([TTBUS_Id] >= @AV6cTTBUS_Id) AND ([TTBUS_Descripcion] like @AV7cTTBUS_Descripcion) AND ([TTBUS_FechaCarga] >= @AV8cTTBUS_FechaCarga) AND ([TTBUS_Estado] >= @AV9cTTBUS_Estado) AND ([TTBUS_CodProveedor] >= @AV10cTTBUS_CodProveedor) AND ([TTBUS_Alquilado] >= @AV12cTTBUS_Alquilado) AND ([TTBUS_CodPosicion] >= @AV13cTTBUS_CodPosicion) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002H5,1,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(5) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[7])[0] = rslt.getInt(7) ;
                break;
             case 3 :
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
