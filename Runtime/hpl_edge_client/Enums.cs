namespace HplEdgeClient.Enums
{
  public enum MintAsKind
  {
    MplCore,
    MplMetadata,
    MplBubblegum,
    TokenExtensions
  }

  public enum CharacterSourceKind
  {
    Wrapped,
    Assembled
  }

  public enum AssetCriteriaKind
  {
    Prepopulated,
    Collection,
    Creator,
    MerkleTree
  }

  public enum SourceKind
  {
    Assembled,
    MplMetadata,
    MplBubblegum,
    TokenExtensions,
    MplCoreAsset
  }

  public enum CivicGateway
  {
    LivenessPass,
    UniquenessPass,
    IdVerificationPass
  }

  public enum BadgesCondition
  {
    Public
  }

  public enum RemoveSocialsInput
  {
    Twitter,
    Discord,
    Steam,
    All
  }

  public enum HiveControlPermissionInput
  {
    ManageCriterias,
    ManageServices,
    ManageIndexing,
    ManageProfiles
  }

  public enum AssetAssemblerPermissionInput
  {
    ManageAssembler,
    UpdateBlock,
    UpdateBlockDefinition,
    UpdateNFT,
    InitialArtGeneration
  }

  public enum AssetManagerPermissionInput
  {
    ManageAssets
  }

  public enum ResourceManagerPermissionInput
  {
    CreateResources,
    MintResources,
    BurnResources
  }

  public enum NectarStakingPermissionInput
  {
    ManageStakingPool,
    WithdrawStakingPoolRewards
  }

  public enum NectarMissionsPermissionInput
  {
    ManageMissionPool,
    WithdrawMissionPoolRewards
  }

  public enum BuzzGuildPermissionInput
  {
    ManageGuildKit
  }

  public enum LockTypeEnum
  {
    Freeze,
    Custody
  }

  public enum RewardKind
  {
    Xp,
    Resource
  }

  public enum ResourceStorageEnum
  {
    AccountState,
    LedgerState
  }

  public enum ResourceCustodyEnum
  {
    Authority,
    Supply
  }

}

