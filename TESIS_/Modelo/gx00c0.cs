/*
               File: Gx00C0
        Description: Selection List Auxiliar para informe de bienes de uso por responsable
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:58.72
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
   public class gx00c0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00c0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00c0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pTTBUS14_CodResponsable ,
                           out int aP1_pTTBUS14_IdBien )
      {
         this.AV13pTTBUS14_CodResponsable = "" ;
         this.AV14pTTBUS14_IdBien = 0 ;
         executePrivate();
         aP0_pTTBUS14_CodResponsable=this.AV13pTTBUS14_CodResponsable;
         aP1_pTTBUS14_IdBien=this.AV14pTTBUS14_IdBien;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cTTBUS14_CodResponsable = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS14_CodResponsable", AV6cTTBUS14_CodResponsable);
               AV7cTTBUS14_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cTTBUS14_IdBien), 8, 0)));
               AV8cTTBUS14_Responsable = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS14_Responsable", AV8cTTBUS14_Responsable);
               AV9cTTBUS14_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS14_Descripcion", AV9cTTBUS14_Descripcion);
               AV10cTTBUS14_CodRubro = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cTTBUS14_CodRubro), 4, 0)));
               AV11cTTBUS14_Rubro = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS14_Rubro", AV11cTTBUS14_Rubro);
               AV12cTTBUS14_Proveedor = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS14_Proveedor", AV12cTTBUS14_Proveedor);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cTTBUS14_CodResponsable, AV7cTTBUS14_IdBien, AV8cTTBUS14_Responsable, AV9cTTBUS14_Descripcion, AV10cTTBUS14_CodRubro, AV11cTTBUS14_Rubro, AV12cTTBUS14_Proveedor) ;
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
               AV13pTTBUS14_CodResponsable = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTTBUS14_CodResponsable", AV13pTTBUS14_CodResponsable);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14pTTBUS14_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS14_IdBien), 8, 0)));
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
         PA2X2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2X2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00c0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pTTBUS14_CodResponsable)) + "," + UrlEncode("" +AV14pTTBUS14_IdBien)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS14_CODRESPONSABLE", StringUtil.RTrim( AV6cTTBUS14_CodResponsable));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS14_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cTTBUS14_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS14_RESPONSABLE", StringUtil.RTrim( AV8cTTBUS14_Responsable));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS14_DESCRIPCION", StringUtil.RTrim( AV9cTTBUS14_Descripcion));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS14_CODRUBRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cTTBUS14_CodRubro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS14_RUBRO", StringUtil.RTrim( AV11cTTBUS14_Rubro));
         GxWebStd.gx_hidden_field( context, "GXH_vCTTBUS14_PROVEEDOR", StringUtil.RTrim( AV12cTTBUS14_Proveedor));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS14_CODRESPONSABLE", StringUtil.RTrim( AV13pTTBUS14_CodResponsable));
         GxWebStd.gx_hidden_field( context, "vPTTBUS14_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pTTBUS14_IdBien), 8, 0, ",", "")));
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
            WE2X2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2X2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00C0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Auxiliar para informe de bienes de uso por responsable" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00c0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pTTBUS14_CodResponsable)) + "," + UrlEncode("" +AV14pTTBUS14_IdBien) ;
      }

      protected void WB2X0( )
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
            wb_table1_2_2X2( true) ;
         }
         else
         {
            wb_table1_2_2X2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2X2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2X2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List Auxiliar para informe de bienes de uso por responsable", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2X0( ) ;
      }

      protected void WS2X2( )
      {
         START2X2( ) ;
         EVT2X2( ) ;
      }

      protected void EVT2X2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_CODRESPONSABLE"), AV6cTTBUS14_CodResponsable) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS14_IDBIEN"), ",", ".") != Convert.ToDecimal( AV7cTTBUS14_IdBien )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_RESPONSABLE"), AV8cTTBUS14_Responsable) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_DESCRIPCION"), AV9cTTBUS14_Descripcion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS14_CODRUBRO"), ",", ".") != Convert.ToDecimal( AV10cTTBUS14_CodRubro )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_RUBRO"), AV11cTTBUS14_Rubro) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_PROVEEDOR"), AV12cTTBUS14_Proveedor) != 0 )
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
                              edtTTBUS14_CodResponsable_Internalname = "TTBUS14_CODRESPONSABLE_"+sGXsfl_51_idx ;
                              edtTTBUS14_IdBien_Internalname = "TTBUS14_IDBIEN_"+sGXsfl_51_idx ;
                              edtTTBUS14_Responsable_Internalname = "TTBUS14_RESPONSABLE_"+sGXsfl_51_idx ;
                              edtTTBUS14_CodRubro_Internalname = "TTBUS14_CODRUBRO_"+sGXsfl_51_idx ;
                              edtTTBUS14_Rubro_Internalname = "TTBUS14_RUBRO_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A213TTBUS14_CodResponsable = cgiGet( edtTTBUS14_CodResponsable_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
                              A201TTBUS14_IdBien = (int)(context.localUtil.CToN( cgiGet( edtTTBUS14_IdBien_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
                              A209TTBUS14_Responsable = cgiGet( edtTTBUS14_Responsable_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209TTBUS14_Responsable", A209TTBUS14_Responsable);
                              A214TTBUS14_CodRubro = (short)(context.localUtil.CToN( cgiGet( edtTTBUS14_CodRubro_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214TTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(A214TTBUS14_CodRubro), 4, 0)));
                              A203TTBUS14_Rubro = cgiGet( edtTTBUS14_Rubro_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TTBUS14_Rubro", A203TTBUS14_Rubro);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112X2 */
                                    E112X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122X2 */
                                    E122X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cttbus14_codresponsable Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_CODRESPONSABLE"), AV6cTTBUS14_CodResponsable) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus14_idbien Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS14_IDBIEN"), ",", ".") != Convert.ToDecimal( AV7cTTBUS14_IdBien )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus14_responsable Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_RESPONSABLE"), AV8cTTBUS14_Responsable) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus14_descripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_DESCRIPCION"), AV9cTTBUS14_Descripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus14_codrubro Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTTBUS14_CODRUBRO"), ",", ".") != Convert.ToDecimal( AV10cTTBUS14_CodRubro )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus14_rubro Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_RUBRO"), AV11cTTBUS14_Rubro) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cttbus14_proveedor Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTTBUS14_PROVEEDOR"), AV12cTTBUS14_Proveedor) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132X2 */
                                          E132X2 ();
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

      protected void WE2X2( )
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

      protected void PA2X2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCttbus14_codresponsable_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_51_idx ,
                                       String sGXsfl_51_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtTTBUS14_CodResponsable_Internalname = "TTBUS14_CODRESPONSABLE_"+sGXsfl_51_idx ;
         edtTTBUS14_IdBien_Internalname = "TTBUS14_IDBIEN_"+sGXsfl_51_idx ;
         edtTTBUS14_Responsable_Internalname = "TTBUS14_RESPONSABLE_"+sGXsfl_51_idx ;
         edtTTBUS14_CodRubro_Internalname = "TTBUS14_CODRUBRO_"+sGXsfl_51_idx ;
         edtTTBUS14_Rubro_Internalname = "TTBUS14_RUBRO_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS14_CodResponsable_Internalname = "TTBUS14_CODRESPONSABLE_"+sGXsfl_51_idx ;
            edtTTBUS14_IdBien_Internalname = "TTBUS14_IDBIEN_"+sGXsfl_51_idx ;
            edtTTBUS14_Responsable_Internalname = "TTBUS14_RESPONSABLE_"+sGXsfl_51_idx ;
            edtTTBUS14_CodRubro_Internalname = "TTBUS14_CODRUBRO_"+sGXsfl_51_idx ;
            edtTTBUS14_Rubro_Internalname = "TTBUS14_RUBRO_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cTTBUS14_CodResponsable ,
                                        int AV7cTTBUS14_IdBien ,
                                        String AV8cTTBUS14_Responsable ,
                                        String AV9cTTBUS14_Descripcion ,
                                        short AV10cTTBUS14_CodRubro ,
                                        String AV11cTTBUS14_Rubro ,
                                        String AV12cTTBUS14_Proveedor )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF2X2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2X2( ) ;
         /* End function Refresh */
      }

      protected void RF2X2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtTTBUS14_CodResponsable_Internalname = "TTBUS14_CODRESPONSABLE_"+sGXsfl_51_idx ;
         edtTTBUS14_IdBien_Internalname = "TTBUS14_IDBIEN_"+sGXsfl_51_idx ;
         edtTTBUS14_Responsable_Internalname = "TTBUS14_RESPONSABLE_"+sGXsfl_51_idx ;
         edtTTBUS14_CodRubro_Internalname = "TTBUS14_CODRUBRO_"+sGXsfl_51_idx ;
         edtTTBUS14_Rubro_Internalname = "TTBUS14_RUBRO_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS14_CodResponsable_Internalname = "TTBUS14_CODRESPONSABLE_"+sGXsfl_51_idx ;
            edtTTBUS14_IdBien_Internalname = "TTBUS14_IDBIEN_"+sGXsfl_51_idx ;
            edtTTBUS14_Responsable_Internalname = "TTBUS14_RESPONSABLE_"+sGXsfl_51_idx ;
            edtTTBUS14_CodRubro_Internalname = "TTBUS14_CODRUBRO_"+sGXsfl_51_idx ;
            edtTTBUS14_Rubro_Internalname = "TTBUS14_RUBRO_"+sGXsfl_51_idx ;
            lV6cTTBUS14_CodResponsable = StringUtil.PadR( StringUtil.RTrim( AV6cTTBUS14_CodResponsable), 15, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS14_CodResponsable", AV6cTTBUS14_CodResponsable);
            lV8cTTBUS14_Responsable = StringUtil.PadR( StringUtil.RTrim( AV8cTTBUS14_Responsable), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS14_Responsable", AV8cTTBUS14_Responsable);
            lV9cTTBUS14_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV9cTTBUS14_Descripcion), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS14_Descripcion", AV9cTTBUS14_Descripcion);
            lV11cTTBUS14_Rubro = StringUtil.PadR( StringUtil.RTrim( AV11cTTBUS14_Rubro), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS14_Rubro", AV11cTTBUS14_Rubro);
            lV12cTTBUS14_Proveedor = StringUtil.PadR( StringUtil.RTrim( AV12cTTBUS14_Proveedor), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS14_Proveedor", AV12cTTBUS14_Proveedor);
            /* Using cursor H002X2 */
            pr_default.execute(0, new Object[] {lV6cTTBUS14_CodResponsable, AV7cTTBUS14_IdBien, lV8cTTBUS14_Responsable, lV9cTTBUS14_Descripcion, AV10cTTBUS14_CodRubro, lV11cTTBUS14_Rubro, lV12cTTBUS14_Proveedor});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A202TTBUS14_Descripcion = H002X2_A202TTBUS14_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TTBUS14_Descripcion", A202TTBUS14_Descripcion);
               A204TTBUS14_Proveedor = H002X2_A204TTBUS14_Proveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204TTBUS14_Proveedor", A204TTBUS14_Proveedor);
               A203TTBUS14_Rubro = H002X2_A203TTBUS14_Rubro[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TTBUS14_Rubro", A203TTBUS14_Rubro);
               A214TTBUS14_CodRubro = H002X2_A214TTBUS14_CodRubro[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214TTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(A214TTBUS14_CodRubro), 4, 0)));
               A209TTBUS14_Responsable = H002X2_A209TTBUS14_Responsable[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209TTBUS14_Responsable", A209TTBUS14_Responsable);
               A201TTBUS14_IdBien = H002X2_A201TTBUS14_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
               A213TTBUS14_CodResponsable = H002X2_A213TTBUS14_CodResponsable[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
               /* Execute user event: E122X2 */
               E122X2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB2X0( ) ;
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
         lV6cTTBUS14_CodResponsable = StringUtil.PadR( StringUtil.RTrim( AV6cTTBUS14_CodResponsable), 15, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS14_CodResponsable", AV6cTTBUS14_CodResponsable);
         lV8cTTBUS14_Responsable = StringUtil.PadR( StringUtil.RTrim( AV8cTTBUS14_Responsable), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS14_Responsable", AV8cTTBUS14_Responsable);
         lV9cTTBUS14_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV9cTTBUS14_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS14_Descripcion", AV9cTTBUS14_Descripcion);
         lV11cTTBUS14_Rubro = StringUtil.PadR( StringUtil.RTrim( AV11cTTBUS14_Rubro), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS14_Rubro", AV11cTTBUS14_Rubro);
         lV12cTTBUS14_Proveedor = StringUtil.PadR( StringUtil.RTrim( AV12cTTBUS14_Proveedor), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS14_Proveedor", AV12cTTBUS14_Proveedor);
         /* Using cursor H002X3 */
         pr_default.execute(1, new Object[] {lV6cTTBUS14_CodResponsable, AV7cTTBUS14_IdBien, lV8cTTBUS14_Responsable, lV9cTTBUS14_Descripcion, AV10cTTBUS14_CodRubro, lV11cTTBUS14_Rubro, lV12cTTBUS14_Proveedor});
         GRID1_nRecordCount = H002X3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
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

      protected void STRUP2X0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112X2 */
         E112X2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cTTBUS14_CodResponsable = cgiGet( edtavCttbus14_codresponsable_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTTBUS14_CodResponsable", AV6cTTBUS14_CodResponsable);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus14_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus14_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus14_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS14_IDBIEN");
               GX_FocusControl = edtavCttbus14_idbien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cTTBUS14_IdBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cTTBUS14_IdBien), 8, 0)));
            }
            else
            {
               AV7cTTBUS14_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavCttbus14_idbien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cTTBUS14_IdBien), 8, 0)));
            }
            AV8cTTBUS14_Responsable = cgiGet( edtavCttbus14_responsable_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTTBUS14_Responsable", AV8cTTBUS14_Responsable);
            AV9cTTBUS14_Descripcion = cgiGet( edtavCttbus14_descripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTTBUS14_Descripcion", AV9cTTBUS14_Descripcion);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCttbus14_codrubro_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCttbus14_codrubro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCttbus14_codrubro_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTTBUS14_CODRUBRO");
               GX_FocusControl = edtavCttbus14_codrubro_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cTTBUS14_CodRubro = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cTTBUS14_CodRubro), 4, 0)));
            }
            else
            {
               AV10cTTBUS14_CodRubro = (short)(context.localUtil.CToN( cgiGet( edtavCttbus14_codrubro_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cTTBUS14_CodRubro), 4, 0)));
            }
            AV11cTTBUS14_Rubro = cgiGet( edtavCttbus14_rubro_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTTBUS14_Rubro", AV11cTTBUS14_Rubro);
            AV12cTTBUS14_Proveedor = cgiGet( edtavCttbus14_proveedor_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTTBUS14_Proveedor", AV12cTTBUS14_Proveedor);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV13pTTBUS14_CodResponsable = cgiGet( "vPTTBUS14_CODRESPONSABLE") ;
            AV14pTTBUS14_IdBien = (int)(context.localUtil.CToN( cgiGet( "vPTTBUS14_IDBIEN"), ",", ".")) ;
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
         /* Execute user event: E112X2 */
         E112X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112X2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Auxiliar para informe de bienes de uso por responsable", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122X2( )
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
         /* Execute user event: E132X2 */
         E132X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132X2( )
      {
         /* Enter Routine */
         AV13pTTBUS14_CodResponsable = A213TTBUS14_CodResponsable ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTTBUS14_CodResponsable", AV13pTTBUS14_CodResponsable);
         AV14pTTBUS14_IdBien = A201TTBUS14_IdBien ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS14_IdBien), 8, 0)));
         context.setWebReturnParms(new Object[] {(String)AV13pTTBUS14_CodResponsable,(int)AV14pTTBUS14_IdBien});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2X2( bool wbgen )
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
            wb_table2_9_2X2( true) ;
         }
         else
         {
            wb_table2_9_2X2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2X2e( bool wbgen )
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
            wb_table3_48_2X2( true) ;
         }
         else
         {
            wb_table3_48_2X2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_2X2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2X2e( true) ;
         }
         else
         {
            wb_table1_2_2X2e( false) ;
         }
      }

      protected void wb_table3_48_2X2( bool wbgen )
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Código de Responsable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Id bien de uso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Rubro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Rubro del bien") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A213TTBUS14_CodResponsable));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A201TTBUS14_IdBien), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A209TTBUS14_Responsable));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTTBUS14_Responsable_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A214TTBUS14_CodRubro), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A203TTBUS14_Rubro));
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
            wb_table4_60_2X2( true) ;
         }
         else
         {
            wb_table4_60_2X2( false) ;
         }
         return  ;
      }

      protected void wb_table4_60_2X2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_2X2e( true) ;
         }
         else
         {
            wb_table3_48_2X2e( false) ;
         }
      }

      protected void wb_table4_60_2X2( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_60_2X2e( true) ;
         }
         else
         {
            wb_table4_60_2X2e( false) ;
         }
      }

      protected void wb_table2_9_2X2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_codresponsable_Internalname, 1, 1, 0, "Código de Responsable", "", "", "", 0, lblTextblockttbus14_codresponsable_Jsonclick, "", StyleString, ClassString, "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus14_codresponsable_Internalname, StringUtil.RTrim( AV6cTTBUS14_CodResponsable), "", 15, "chr", 1, "row", 15, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6cTTBUS14_CodResponsable, "XXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", 0, edtavCttbus14_codresponsable_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_idbien_Internalname, 1, 1, 0, "Id bien de uso", "", "", "", 0, lblTextblockttbus14_idbien_Jsonclick, "", StyleString, ClassString, "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus14_idbien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cTTBUS14_IdBien), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cTTBUS14_IdBien), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", 0, edtavCttbus14_idbien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_responsable_Internalname, 1, 1, 0, "Responsable", "", "", "", 0, lblTextblockttbus14_responsable_Jsonclick, "", StyleString, ClassString, "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus14_responsable_Internalname, StringUtil.RTrim( AV8cTTBUS14_Responsable), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cTTBUS14_Responsable, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtavCttbus14_responsable_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_descripcion_Internalname, 1, 1, 0, "Descripción del bien", "", "", "", 0, lblTextblockttbus14_descripcion_Jsonclick, "", StyleString, ClassString, "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus14_descripcion_Internalname, StringUtil.RTrim( AV9cTTBUS14_Descripcion), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9cTTBUS14_Descripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", 0, edtavCttbus14_descripcion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_codrubro_Internalname, 1, 1, 0, "Rubro", "", "", "", 0, lblTextblockttbus14_codrubro_Jsonclick, "", StyleString, ClassString, "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus14_codrubro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cTTBUS14_CodRubro), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV10cTTBUS14_CodRubro), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(34);\"", 0, edtavCttbus14_codrubro_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_rubro_Internalname, 1, 1, 0, "Rubro del bien", "", "", "", 0, lblTextblockttbus14_rubro_Jsonclick, "", StyleString, ClassString, "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus14_rubro_Internalname, StringUtil.RTrim( AV11cTTBUS14_Rubro), "", 30, "chr", 1, "row", 30, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV11cTTBUS14_Rubro, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", 0, edtavCttbus14_rubro_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_proveedor_Internalname, 1, 1, 0, "Proveedor", "", "", "", 0, lblTextblockttbus14_proveedor_Jsonclick, "", StyleString, ClassString, "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCttbus14_proveedor_Internalname, StringUtil.RTrim( AV12cTTBUS14_Proveedor), "", 30, "chr", 1, "row", 30, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV12cTTBUS14_Proveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(44);\"", 0, edtavCttbus14_proveedor_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00C0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2X2e( true) ;
         }
         else
         {
            wb_table2_9_2X2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pTTBUS14_CodResponsable = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTTBUS14_CodResponsable", AV13pTTBUS14_CodResponsable);
         AV14pTTBUS14_IdBien = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS14_IdBien), 8, 0)));
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
         PA2X2( ) ;
         WS2X2( ) ;
         WE2X2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11465916");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00c0.js", "?11465917");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB2X0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A213TTBUS14_CodResponsable))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A201TTBUS14_IdBien), 8, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS14_CodResponsable_Internalname,StringUtil.RTrim( A213TTBUS14_CodResponsable),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A213TTBUS14_CodResponsable, "XXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS14_CodResponsable_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS14_IdBien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A201TTBUS14_IdBien), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A201TTBUS14_IdBien), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS14_IdBien_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtTTBUS14_Responsable_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A213TTBUS14_CodResponsable))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A201TTBUS14_IdBien), 8, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_Responsable_Internalname, "Link", edtTTBUS14_Responsable_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS14_Responsable_Internalname,StringUtil.RTrim( A209TTBUS14_Responsable),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtTTBUS14_Responsable_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A209TTBUS14_Responsable, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS14_Responsable_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS14_CodRubro_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A214TTBUS14_CodRubro), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A214TTBUS14_CodRubro), "ZZZ9"),(String)"",(short)0,(String)edtTTBUS14_CodRubro_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS14_Rubro_Internalname,StringUtil.RTrim( A203TTBUS14_Rubro),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A203TTBUS14_Rubro, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS14_Rubro_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTTBUS14_CodResponsable_Internalname = "TTBUS14_CODRESPONSABLE_"+sGXsfl_51_idx ;
            edtTTBUS14_IdBien_Internalname = "TTBUS14_IDBIEN_"+sGXsfl_51_idx ;
            edtTTBUS14_Responsable_Internalname = "TTBUS14_RESPONSABLE_"+sGXsfl_51_idx ;
            edtTTBUS14_CodRubro_Internalname = "TTBUS14_CODRUBRO_"+sGXsfl_51_idx ;
            edtTTBUS14_Rubro_Internalname = "TTBUS14_RUBRO_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockttbus14_codresponsable_Internalname = "TEXTBLOCKTTBUS14_CODRESPONSABLE" ;
         edtavCttbus14_codresponsable_Internalname = "vCTTBUS14_CODRESPONSABLE" ;
         lblTextblockttbus14_idbien_Internalname = "TEXTBLOCKTTBUS14_IDBIEN" ;
         edtavCttbus14_idbien_Internalname = "vCTTBUS14_IDBIEN" ;
         lblTextblockttbus14_responsable_Internalname = "TEXTBLOCKTTBUS14_RESPONSABLE" ;
         edtavCttbus14_responsable_Internalname = "vCTTBUS14_RESPONSABLE" ;
         lblTextblockttbus14_descripcion_Internalname = "TEXTBLOCKTTBUS14_DESCRIPCION" ;
         edtavCttbus14_descripcion_Internalname = "vCTTBUS14_DESCRIPCION" ;
         lblTextblockttbus14_codrubro_Internalname = "TEXTBLOCKTTBUS14_CODRUBRO" ;
         edtavCttbus14_codrubro_Internalname = "vCTTBUS14_CODRUBRO" ;
         lblTextblockttbus14_rubro_Internalname = "TEXTBLOCKTTBUS14_RUBRO" ;
         edtavCttbus14_rubro_Internalname = "vCTTBUS14_RUBRO" ;
         lblTextblockttbus14_proveedor_Internalname = "TEXTBLOCKTTBUS14_PROVEEDOR" ;
         edtavCttbus14_proveedor_Internalname = "vCTTBUS14_PROVEEDOR" ;
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
         edtTTBUS14_Rubro_Jsonclick = "" ;
         edtTTBUS14_CodRubro_Jsonclick = "" ;
         edtTTBUS14_Responsable_Jsonclick = "" ;
         edtTTBUS14_IdBien_Jsonclick = "" ;
         edtTTBUS14_CodResponsable_Jsonclick = "" ;
         edtavCttbus14_proveedor_Jsonclick = "" ;
         edtavCttbus14_rubro_Jsonclick = "" ;
         edtavCttbus14_codrubro_Jsonclick = "" ;
         edtavCttbus14_descripcion_Jsonclick = "" ;
         edtavCttbus14_responsable_Jsonclick = "" ;
         edtavCttbus14_idbien_Jsonclick = "" ;
         edtavCttbus14_codresponsable_Jsonclick = "" ;
         edtTTBUS14_Responsable_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Auxiliar para informe de bienes de uso por responsable" ;
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
         AV6cTTBUS14_CodResponsable = "" ;
         AV8cTTBUS14_Responsable = "" ;
         AV9cTTBUS14_Descripcion = "" ;
         AV11cTTBUS14_Rubro = "" ;
         AV12cTTBUS14_Proveedor = "" ;
         AV13pTTBUS14_CodResponsable = "" ;
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
         edtTTBUS14_CodResponsable_Internalname = "" ;
         edtTTBUS14_IdBien_Internalname = "" ;
         edtTTBUS14_Responsable_Internalname = "" ;
         edtTTBUS14_CodRubro_Internalname = "" ;
         edtTTBUS14_Rubro_Internalname = "" ;
         AV5LinkSelection = "" ;
         A213TTBUS14_CodResponsable = "" ;
         A209TTBUS14_Responsable = "" ;
         A203TTBUS14_Rubro = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cTTBUS14_CodResponsable = "" ;
         lV8cTTBUS14_Responsable = "" ;
         lV9cTTBUS14_Descripcion = "" ;
         lV11cTTBUS14_Rubro = "" ;
         lV12cTTBUS14_Proveedor = "" ;
         H002X2_A202TTBUS14_Descripcion = new String[] {""} ;
         H002X2_A204TTBUS14_Proveedor = new String[] {""} ;
         H002X2_A203TTBUS14_Rubro = new String[] {""} ;
         H002X2_A214TTBUS14_CodRubro = new short[1] ;
         H002X2_A209TTBUS14_Responsable = new String[] {""} ;
         H002X2_A201TTBUS14_IdBien = new int[1] ;
         H002X2_A213TTBUS14_CodResponsable = new String[] {""} ;
         A202TTBUS14_Descripcion = "" ;
         A204TTBUS14_Proveedor = "" ;
         H002X3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockttbus14_codresponsable_Jsonclick = "" ;
         lblTextblockttbus14_idbien_Jsonclick = "" ;
         lblTextblockttbus14_responsable_Jsonclick = "" ;
         lblTextblockttbus14_descripcion_Jsonclick = "" ;
         lblTextblockttbus14_codrubro_Jsonclick = "" ;
         lblTextblockttbus14_rubro_Jsonclick = "" ;
         lblTextblockttbus14_proveedor_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00c0__default(),
            new Object[][] {
                new Object[] {
               H002X2_A202TTBUS14_Descripcion, H002X2_A204TTBUS14_Proveedor, H002X2_A203TTBUS14_Rubro, H002X2_A214TTBUS14_CodRubro, H002X2_A209TTBUS14_Responsable, H002X2_A201TTBUS14_IdBien, H002X2_A213TTBUS14_CodResponsable
               }
               , new Object[] {
               H002X3_AGRID1_nRecordCount
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
      private short AV10cTTBUS14_CodRubro ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A214TTBUS14_CodRubro ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int AV7cTTBUS14_IdBien ;
      private int AV14pTTBUS14_IdBien ;
      private int GRID1_nFirstRecordOnPage ;
      private int A201TTBUS14_IdBien ;
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
      private String AV6cTTBUS14_CodResponsable ;
      private String AV8cTTBUS14_Responsable ;
      private String AV11cTTBUS14_Rubro ;
      private String AV12cTTBUS14_Proveedor ;
      private String AV13pTTBUS14_CodResponsable ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtTTBUS14_CodResponsable_Internalname ;
      private String edtTTBUS14_IdBien_Internalname ;
      private String edtTTBUS14_Responsable_Internalname ;
      private String edtTTBUS14_CodRubro_Internalname ;
      private String edtTTBUS14_Rubro_Internalname ;
      private String A213TTBUS14_CodResponsable ;
      private String A209TTBUS14_Responsable ;
      private String A203TTBUS14_Rubro ;
      private String edtavCttbus14_codresponsable_Internalname ;
      private String scmdbuf ;
      private String lV6cTTBUS14_CodResponsable ;
      private String lV8cTTBUS14_Responsable ;
      private String lV11cTTBUS14_Rubro ;
      private String lV12cTTBUS14_Proveedor ;
      private String A204TTBUS14_Proveedor ;
      private String edtavCttbus14_idbien_Internalname ;
      private String edtavCttbus14_responsable_Internalname ;
      private String edtavCttbus14_descripcion_Internalname ;
      private String edtavCttbus14_codrubro_Internalname ;
      private String edtavCttbus14_rubro_Internalname ;
      private String edtavCttbus14_proveedor_Internalname ;
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
      private String edtTTBUS14_Responsable_Link ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus14_codresponsable_Internalname ;
      private String lblTextblockttbus14_codresponsable_Jsonclick ;
      private String edtavCttbus14_codresponsable_Jsonclick ;
      private String lblTextblockttbus14_idbien_Internalname ;
      private String lblTextblockttbus14_idbien_Jsonclick ;
      private String edtavCttbus14_idbien_Jsonclick ;
      private String lblTextblockttbus14_responsable_Internalname ;
      private String lblTextblockttbus14_responsable_Jsonclick ;
      private String edtavCttbus14_responsable_Jsonclick ;
      private String lblTextblockttbus14_descripcion_Internalname ;
      private String lblTextblockttbus14_descripcion_Jsonclick ;
      private String edtavCttbus14_descripcion_Jsonclick ;
      private String lblTextblockttbus14_codrubro_Internalname ;
      private String lblTextblockttbus14_codrubro_Jsonclick ;
      private String edtavCttbus14_codrubro_Jsonclick ;
      private String lblTextblockttbus14_rubro_Internalname ;
      private String lblTextblockttbus14_rubro_Jsonclick ;
      private String edtavCttbus14_rubro_Jsonclick ;
      private String lblTextblockttbus14_proveedor_Internalname ;
      private String lblTextblockttbus14_proveedor_Jsonclick ;
      private String edtavCttbus14_proveedor_Jsonclick ;
      private String ROClassString ;
      private String edtTTBUS14_CodResponsable_Jsonclick ;
      private String edtTTBUS14_IdBien_Jsonclick ;
      private String edtTTBUS14_Responsable_Jsonclick ;
      private String edtTTBUS14_CodRubro_Jsonclick ;
      private String edtTTBUS14_Rubro_Jsonclick ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV9cTTBUS14_Descripcion ;
      private String lV9cTTBUS14_Descripcion ;
      private String A202TTBUS14_Descripcion ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H002X2_A202TTBUS14_Descripcion ;
      private String[] H002X2_A204TTBUS14_Proveedor ;
      private String[] H002X2_A203TTBUS14_Rubro ;
      private short[] H002X2_A214TTBUS14_CodRubro ;
      private String[] H002X2_A209TTBUS14_Responsable ;
      private int[] H002X2_A201TTBUS14_IdBien ;
      private String[] H002X2_A213TTBUS14_CodResponsable ;
      private int[] H002X3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pTTBUS14_CodResponsable ;
      private int aP1_pTTBUS14_IdBien ;
      private GXWebForm Form ;
   }

   public class gx00c0__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002X2 ;
          prmH002X2 = new Object[] {
          new Object[] {"@AV6cTTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@AV7cTTBUS14_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@AV8cTTBUS14_Responsable",SqlDbType.Char,50,0} ,
          new Object[] {"@AV9cTTBUS14_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV10cTTBUS14_CodRubro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cTTBUS14_Rubro",SqlDbType.Char,30,0} ,
          new Object[] {"@AV12cTTBUS14_Proveedor",SqlDbType.Char,30,0}
          } ;
          Object[] prmH002X3 ;
          prmH002X3 = new Object[] {
          new Object[] {"@AV6cTTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@AV7cTTBUS14_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@AV8cTTBUS14_Responsable",SqlDbType.Char,50,0} ,
          new Object[] {"@AV9cTTBUS14_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV10cTTBUS14_CodRubro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cTTBUS14_Rubro",SqlDbType.Char,30,0} ,
          new Object[] {"@AV12cTTBUS14_Proveedor",SqlDbType.Char,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002X2", "SELECT [TTBUS14_Descripcion], [TTBUS14_Proveedor], [TTBUS14_Rubro], [TTBUS14_CodRubro], [TTBUS14_Responsable], [TTBUS14_IdBien], [TTBUS14_CodResponsable] FROM [TTBUS014_1] WITH (NOLOCK) WHERE ([TTBUS14_CodResponsable] like @AV6cTTBUS14_CodResponsable) AND ([TTBUS14_IdBien] >= @AV7cTTBUS14_IdBien) AND ([TTBUS14_Responsable] like @AV8cTTBUS14_Responsable) AND ([TTBUS14_Descripcion] like @AV9cTTBUS14_Descripcion) AND ([TTBUS14_CodRubro] >= @AV10cTTBUS14_CodRubro) AND ([TTBUS14_Rubro] like @AV11cTTBUS14_Rubro) AND ([TTBUS14_Proveedor] like @AV12cTTBUS14_Proveedor) ORDER BY [TTBUS14_CodResponsable], [TTBUS14_IdBien]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002X2,11,0,false,false )
             ,new CursorDef("H002X3", "SELECT COUNT(*) FROM [TTBUS014_1] WITH (NOLOCK) WHERE ([TTBUS14_CodResponsable] like @AV6cTTBUS14_CodResponsable) AND ([TTBUS14_IdBien] >= @AV7cTTBUS14_IdBien) AND ([TTBUS14_Responsable] like @AV8cTTBUS14_Responsable) AND ([TTBUS14_Descripcion] like @AV9cTTBUS14_Descripcion) AND ([TTBUS14_CodRubro] >= @AV10cTTBUS14_CodRubro) AND ([TTBUS14_Rubro] like @AV11cTTBUS14_Rubro) AND ([TTBUS14_Proveedor] like @AV12cTTBUS14_Proveedor) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002X3,1,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 50) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 15) ;
                break;
             case 1 :
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
