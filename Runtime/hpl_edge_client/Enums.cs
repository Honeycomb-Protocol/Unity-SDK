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
    ManageProjectDriver,
    UpdatePlatformData
  }

  public enum CharacterManagerPermissionInput
  {
    ManageAssemblerConfig,
    ManageCharacterModels,
    AssignCharacterTraits
  }

  public enum ResourceManagerPermissionInput
  {
    CreateResources,
    MintResources,
    BurnResources,
    CreateFaucet,
    CreateRecipe
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

